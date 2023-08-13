using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorTaskApp.Data
{

        public class JobService
        {
            #region Property
            private readonly AppDBContext _appDBContext;
            #endregion

            #region Constructor
            public JobService(AppDBContext appDBContext)
            {
                _appDBContext = appDBContext;
            }
            #endregion

            #region Get List of Jobs
            public async Task<List<Job>> GetAllJobsAsync()
            {
                return await _appDBContext.Jobs.ToListAsync();
            }
            #endregion

            #region Insert Job
            public async Task<bool> InsertJobAsync(Job Job)
            {
                await _appDBContext.Jobs.AddAsync(Job);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
            #endregion

            #region Get Job by Id
            public async Task<Job> GetJobAsync(int Id)
            {
                Job Job = await _appDBContext.Jobs.FirstOrDefaultAsync(c => c.Id.Equals(Id));
                return Job;
            }
            #endregion

            #region Update Job
            public async Task<bool> UpdateJobAsync(Job Job)
            {
                _appDBContext.Jobs.Update(Job);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
            #endregion

            #region DeleteJob
            public async Task<bool> DeleteJobAsync(Job Job)
            {
                _appDBContext.Remove(Job);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
            #endregion
        }
    }
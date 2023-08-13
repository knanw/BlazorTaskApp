using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTaskApp.Data
{
        public class Job
        {
        [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Status { get; set; }
            public DateTime DueDate { get; set; }
            public string Priority { get; set; }
            public string Size { get; set; }
            public int Master { get; set; }
            public string Description { get; set; }
            public string Note { get; set; }

        }
    }

#pragma checksum "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7654120c86d45e67e3000f59e6ae3069ca65ede"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTaskApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using BlazorTaskApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\_Imports.razor"
using BlazorTaskApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
using BlazorTaskApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/AddJob")]
    public partial class AddJob : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Job</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                obj.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Name = __value, obj.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Status\" class=\"control-label\">Status</label>\r\n                ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                obj.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Status = __value, obj.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value");
            __builder.AddContent(24, "-Select Status");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "open");
            __builder.AddContent(28, "open");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "process");
            __builder.AddContent(32, "process");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "closed");
            __builder.AddContent(36, "closed");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "<label for=\"DueDate\" class=\"control-label\">Due Date</label>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "form", "DueDate");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                   obj.DueDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.DueDate = __value, obj.DueDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group");
            __builder.AddMarkupContent(49, "<label for=\"Priority\" class=\"control-label\">Select Priority</label>\r\n                ");
            __builder.OpenElement(50, "select");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                obj.Priority

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Priority = __value, obj.Priority));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value");
            __builder.AddContent(56, "-Select Priority");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "open");
            __builder.AddContent(60, "low");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "process");
            __builder.AddContent(64, "middle");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "closed");
            __builder.AddContent(68, "high");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "form-group");
            __builder.AddMarkupContent(72, "<label for=\"Priority\" class=\"control-label\">Size</label>\r\n                ");
            __builder.OpenElement(73, "select");
            __builder.AddAttribute(74, "class", "form-control");
            __builder.AddAttribute(75, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                obj.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Size = __value, obj.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "value");
            __builder.AddContent(79, "-Select Size");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", "open");
            __builder.AddContent(83, "small");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "process");
            __builder.AddContent(87, "average");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "closed");
            __builder.AddContent(91, "big");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n            ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "<label for=\"Master\" class=\"control-label\">Master</label>\r\n                ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "form", "Master");
            __builder.AddAttribute(98, "class", "form-control");
            __builder.AddAttribute(99, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                  obj.Master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Master = __value, obj.Master));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group");
            __builder.AddMarkupContent(104, "<label for=\"Description\" class=\"control-label\">Description</label>\r\n                ");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "form", "Description");
            __builder.AddAttribute(107, "class", "form-control");
            __builder.AddAttribute(108, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                       obj.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Description = __value, obj.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group");
            __builder.AddMarkupContent(113, "<label for=\"Note\" class=\"control-label\">Note</label>\r\n                ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "form", "Description");
            __builder.AddAttribute(116, "class", "form-control");
            __builder.AddAttribute(117, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                       obj.Note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Note = __value, obj.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "row");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col-md-4");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "form-group");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "type", "button");
            __builder.AddAttribute(128, "class", "btn btn-primary");
            __builder.AddAttribute(129, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                        CreateJob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "type", "button");
            __builder.AddAttribute(134, "class", "btn btn-primary");
            __builder.AddAttribute(135, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\AddJob.razor"
       
    Job obj = new Job();
    protected async void CreateJob()
    {
        await JobService.InsertJobAsync(obj);
        NavigationManager.NavigateTo("Jobs");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Jobs");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JobService JobService { get; set; }
    }
}
#pragma warning restore 1591

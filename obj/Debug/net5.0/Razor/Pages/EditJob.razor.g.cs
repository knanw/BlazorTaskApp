#pragma checksum "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98e57b6fa51d8c257a5601e0eb952fad06187ce6"
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
#line 2 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
using BlazorTaskApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/EditJob/{Id}")]
    public partial class EditJob : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Job</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "form", "Name");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                obj.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Id = __value, obj.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "form", "Name");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                obj.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Name = __value, obj.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "<label for=\"Status\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                obj.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Status = __value, obj.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value");
            __builder.AddContent(32, "-Select Status");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "open");
            __builder.AddContent(36, "open");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "process");
            __builder.AddContent(40, "process");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "closed");
            __builder.AddContent(44, "closed");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.AddMarkupContent(48, "<label for=\"DueDate\" class=\"control-label\">Due Date</label>\r\n                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "form", "DueDate");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                   obj.DueDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.DueDate = __value, obj.DueDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "<label for=\"Priority\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                obj.Priority

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Priority = __value, obj.Priority));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value");
            __builder.AddContent(64, "-Select Priority");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "open");
            __builder.AddContent(68, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "process");
            __builder.AddContent(72, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "closed");
            __builder.AddContent(76, "3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group");
            __builder.AddMarkupContent(80, "<label for=\"Priority\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(81, "select");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                obj.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Size = __value, obj.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value");
            __builder.AddContent(87, "-Select Size");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "open");
            __builder.AddContent(91, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "process");
            __builder.AddContent(95, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "option");
            __builder.AddAttribute(98, "value", "closed");
            __builder.AddContent(99, "3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n            ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "form-group");
            __builder.AddMarkupContent(103, "<label for=\"Master\" class=\"control-label\">Master</label>\r\n                ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "form", "Master");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                  obj.Master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Master = __value, obj.Master));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n            ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group");
            __builder.AddMarkupContent(112, "<label for=\"Description\" class=\"control-label\">Description</label>\r\n                ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "form", "Description");
            __builder.AddAttribute(115, "class", "form-control");
            __builder.AddAttribute(116, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                       obj.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Description = __value, obj.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n            ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-group");
            __builder.AddMarkupContent(121, "<label for=\"Note\" class=\"control-label\">Note</label>\r\n                ");
            __builder.OpenElement(122, "input");
            __builder.AddAttribute(123, "form", "Description");
            __builder.AddAttribute(124, "class", "form-control");
            __builder.AddAttribute(125, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                       obj.Note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Note = __value, obj.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "row");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-md-4");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "form-group");
            __builder.OpenElement(134, "input");
            __builder.AddAttribute(135, "type", "button");
            __builder.AddAttribute(136, "class", "btn btn-primary");
            __builder.AddAttribute(137, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                        UpdateJob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                ");
            __builder.OpenElement(140, "input");
            __builder.AddAttribute(141, "type", "button");
            __builder.AddAttribute(142, "class", "btn btn-primary");
            __builder.AddAttribute(143, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Developer\Microsoft\source1\repos\BlazorTaskApp\Pages\EditJob.razor"
       
    [Parameter]
    public string Id { get; set; }
    Job obj = new Job();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => JobService.GetJobAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateJob()
    {
        await JobService.UpdateJobAsync(obj);
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

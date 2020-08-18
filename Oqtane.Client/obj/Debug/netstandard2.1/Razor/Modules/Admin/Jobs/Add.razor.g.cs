#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34b7af991cb9681692e2d9f0792cdd28936213b"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Jobs
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using System;

#line default
#line hidden
#line 2 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 3 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#line 4 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 7 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 8 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 9 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 11 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Models;

#line default
#line hidden
#line 12 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Modules;

#line default
#line hidden
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Modules.Controls;

#line default
#line hidden
#line 14 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Providers;

#line default
#line hidden
#line 15 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Security;

#line default
#line hidden
#line 16 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Services;

#line default
#line hidden
#line 17 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Shared;

#line default
#line hidden
#line 18 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Themes;

#line default
#line hidden
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Themes.Controls;

#line default
#line hidden
#line 20 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.UI;

#line default
#line hidden
#line 21 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/_Imports.razor"
using Oqtane.Enums;

#line default
#line hidden
    public partial class Add : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-borderless");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "td");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(7);
            __builder.AddAttribute(8, "For", "name");
            __builder.AddAttribute(9, "HelpText", "Enter the job name");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Name: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "id", "name");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                          _name

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _name = __value, _name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(28);
            __builder.AddAttribute(29, "For", "type");
            __builder.AddAttribute(30, "HelpText", "Enter the job type");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Type: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "id", "type");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 20 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                          _jobType

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _jobType = __value, _jobType));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n    ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(49);
            __builder.AddAttribute(50, "For", "enabled");
            __builder.AddAttribute(51, "HelpText", "Select whether you want the job enabled or not");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Enabled? ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "id", "enabled");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 28 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                              _isEnabled

#line default
#line hidden
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _isEnabled = __value, _isEnabled));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(63, "\n                ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "True");
            __builder.AddContent(66, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "False");
            __builder.AddContent(70, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n    ");
            __builder.OpenElement(75, "tr");
            __builder.AddMarkupContent(76, "\n        ");
            __builder.OpenElement(77, "td");
            __builder.AddMarkupContent(78, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(79);
            __builder.AddAttribute(80, "For", "runs-every");
            __builder.AddAttribute(81, "HelpText", "Select how often you want the job to run");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(83, "Runs Every: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n        ");
            __builder.OpenElement(86, "td");
            __builder.AddMarkupContent(87, "\n            ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "id", "runs-every");
            __builder.AddAttribute(90, "class", "form-control");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 39 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                                _interval

#line default
#line hidden
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _interval = __value, _interval));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n            ");
            __builder.OpenElement(94, "select");
            __builder.AddAttribute(95, "id", "runs-every");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 40 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                                 _frequency

#line default
#line hidden
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _frequency = __value, _frequency));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(99, "\n                ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "m");
            __builder.AddContent(102, "Minute(s)");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "H");
            __builder.AddContent(106, "Hour(s)");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n                ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "d");
            __builder.AddContent(110, "Day(s)");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n                ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "M");
            __builder.AddContent(114, "Month(s)");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n    ");
            __builder.OpenElement(119, "tr");
            __builder.AddMarkupContent(120, "\n        ");
            __builder.OpenElement(121, "td");
            __builder.AddMarkupContent(122, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(123);
            __builder.AddAttribute(124, "For", "starting");
            __builder.AddAttribute(125, "HelpText", "What time do you want the job to start");
            __builder.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(127, "Starting: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n        ");
            __builder.OpenElement(130, "td");
            __builder.AddMarkupContent(131, "\n            ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "id", "starting");
            __builder.AddAttribute(134, "class", "form-control");
            __builder.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 53 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                              _startDate

#line default
#line hidden
            ));
            __builder.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _startDate = __value, _startDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n    ");
            __builder.OpenElement(140, "tr");
            __builder.AddMarkupContent(141, "\n        ");
            __builder.OpenElement(142, "td");
            __builder.AddMarkupContent(143, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(144);
            __builder.AddAttribute(145, "For", "ending");
            __builder.AddAttribute(146, "HelpText", "When do you want the job to end");
            __builder.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(148, "Ending: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n        ");
            __builder.OpenElement(151, "td");
            __builder.AddMarkupContent(152, "\n            ");
            __builder.OpenElement(153, "input");
            __builder.AddAttribute(154, "id", "ending");
            __builder.AddAttribute(155, "class", "form-control");
            __builder.AddAttribute(156, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 61 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                            _endDate

#line default
#line hidden
            ));
            __builder.AddAttribute(157, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _endDate = __value, _endDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n    ");
            __builder.OpenElement(161, "tr");
            __builder.AddMarkupContent(162, "\n        ");
            __builder.OpenElement(163, "td");
            __builder.AddMarkupContent(164, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(165);
            __builder.AddAttribute(166, "For", "retention-log");
            __builder.AddAttribute(167, "HelpText", "What items do you want in the retention log");
            __builder.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(169, "Retention Log (Items): ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(170, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n        ");
            __builder.OpenElement(172, "td");
            __builder.AddMarkupContent(173, "\n            ");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "id", "retention-log");
            __builder.AddAttribute(176, "class", "form-control");
            __builder.AddAttribute(177, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 69 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                                   _retentionHistory

#line default
#line hidden
            ));
            __builder.AddAttribute(178, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _retentionHistory = __value, _retentionHistory));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\n");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "type", "button");
            __builder.AddAttribute(185, "class", "btn btn-success");
            __builder.AddAttribute(186, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 73 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                                        SaveJob

#line default
#line hidden
            ));
            __builder.AddContent(187, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(189);
            __builder.AddAttribute(190, "class", "btn btn-secondary");
            __builder.AddAttribute(191, "href", 
#line 74 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
                                          NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(192, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(193, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 76 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
       
    private string _name = string.Empty;
    private string _jobType = string.Empty;
    private string _isEnabled = "True";
    private string _interval = string.Empty;
    private string _frequency = string.Empty;
    private string _startDate = string.Empty;
    private string _endDate = string.Empty;
    private string _retentionHistory = "10";

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    private async Task SaveJob()
    {
        if (_name != string.Empty && !string.IsNullOrEmpty(_jobType) && _frequency != string.Empty && _interval != string.Empty && _retentionHistory != string.Empty)
        {
            var job = new Job();
            job.Name = _name;
            job.JobType = _jobType;
            job.IsEnabled = Boolean.Parse(_isEnabled);
            job.Frequency = _frequency;
            job.Interval = int.Parse(_interval);

            if (_startDate == string.Empty)
            {
                job.StartDate = null;
            }
            else
            {
                job.StartDate = DateTime.Parse(_startDate);
            }

            if (_endDate == string.Empty)
            {
                job.EndDate = null;
            }
            else
            {
                job.EndDate = DateTime.Parse(_endDate);
            }

            job.RetentionHistory = int.Parse(_retentionHistory);
            job.IsStarted = false;
            job.IsExecuting = false;
            job.NextExecution = null;

            try
            {
                job = await JobService.AddJobAsync(job);
                await logger.LogInformation("Job Added {Job}", job);
                NavigationManager.NavigateTo(NavigateUrl());
            }
            catch (Exception ex)
            {
                await logger.LogError(ex, "Error Adding Job {Job} {Error}", job, ex.Message);
                AddModuleMessage("Error Adding Job", MessageType.Error);
            }
        }
        else
        {
            AddModuleMessage("You Must Provide The Job Name, Type, Frequency, and Retention", MessageType.Warning);
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJobService JobService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b25b98c88726af680f8be2a5979c42270b4a017"
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
    public partial class Index : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
 if (_jobs == null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\n");
#line 8 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.ActionLink>(3);
            __builder.AddAttribute(4, "Action", "Add");
            __builder.AddAttribute(5, "Text", "Add Job");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.ActionLink>(7);
            __builder.AddAttribute(8, "Action", "Log");
            __builder.AddAttribute(9, "Class", "btn btn-secondary");
            __builder.AddAttribute(10, "Text", "View Logs");
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-secondary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                              (async () => await Refresh())

#line default
#line hidden
            ));
            __builder.AddContent(16, "Refresh");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    <br><br>\n");
            __builder.AddContent(18, "    ");
            __Blazor.Oqtane.Modules.Admin.Jobs.Index.TypeInference.CreatePager_0(__builder, 19, 20, 
#line 16 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                   _jobs

#line default
#line hidden
            , 21, (__builder2) => {
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.AddMarkupContent(23, "<th style=\"width: 1px;\">&nbsp;</th>\n            ");
                __builder2.AddMarkupContent(24, "<th style=\"width: 1px;\">&nbsp;</th>\n            ");
                __builder2.AddMarkupContent(25, "<th style=\"width: 1px;\">&nbsp;</th>\n            ");
                __builder2.AddMarkupContent(26, "<th>Name</th>\n            ");
                __builder2.AddMarkupContent(27, "<th>Status</th>\n            ");
                __builder2.AddMarkupContent(28, "<th>Frequency</th>\n            ");
                __builder2.AddMarkupContent(29, "<th>Next Execution</th>\n            ");
                __builder2.AddMarkupContent(30, "<th style=\"width: 1px;\">&nbsp;</th>\n        ");
            }
            , 31, (context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.OpenElement(33, "td");
                __builder2.OpenComponent<Oqtane.Modules.Controls.ActionLink>(34);
                __builder2.AddAttribute(35, "Action", "Edit");
                __builder2.AddAttribute(36, "Parameters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 28 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                        $"id=" + context.JobId.ToString()

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "td");
                __builder2.OpenComponent<Oqtane.Modules.Controls.ActionDialog>(39);
                __builder2.AddAttribute(40, "Header", "Delete Job");
                __builder2.AddAttribute(41, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 29 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                             "Are You Sure You Wish To Delete This Job?"

#line default
#line hidden
                ));
                __builder2.AddAttribute(42, "Action", "Delete");
                __builder2.AddAttribute(43, "Security", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Oqtane.Shared.SecurityAccessLevel?>(
#line 29 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                                                                                                     SecurityAccessLevel.Host

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "Class", "btn btn-danger");
                __builder2.AddAttribute(45, "OnClick", new System.Action(
#line 29 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                                                                                                                                                                 async () => await DeleteJob(context)

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.OpenElement(47, "td");
                __builder2.OpenComponent<Oqtane.Modules.Controls.ActionLink>(48);
                __builder2.AddAttribute(49, "Action", "Log");
                __builder2.AddAttribute(50, "Class", "btn btn-secondary");
                __builder2.AddAttribute(51, "Parameters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                                                 $"id=" + context.JobId.ToString()

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n            ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#line 31 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                 context.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n            ");
                __builder2.OpenElement(56, "td");
                __builder2.AddContent(57, 
#line 32 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                 DisplayStatus(context.IsEnabled, context.IsExecuting)

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n            ");
                __builder2.OpenElement(59, "td");
                __builder2.AddContent(60, 
#line 33 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                 DisplayFrequency(context.Interval, context.Frequency)

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#line 34 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                 context.NextExecution

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n            ");
                __builder2.OpenElement(65, "td");
                __builder2.AddMarkupContent(66, "\n");
#line 36 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                 if (context.IsStarted)
                {

#line default
#line hidden
                __builder2.AddContent(67, "                    ");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "type", "button");
                __builder2.AddAttribute(70, "class", "btn btn-danger");
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                                           (async () => await StopJob(context.JobId))

#line default
#line hidden
                ));
                __builder2.AddContent(72, "Stop");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n");
#line 39 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                }
                else
                {

#line default
#line hidden
                __builder2.AddContent(74, "                    ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "type", "button");
                __builder2.AddAttribute(77, "class", "btn btn-success");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                                                                            (async () => await StartJob(context.JobId))

#line default
#line hidden
                ));
                __builder2.AddContent(79, "Start");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n");
#line 43 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
                }

#line default
#line hidden
                __builder2.AddContent(81, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n        ");
            }
            );
            __builder.AddMarkupContent(83, "\n");
#line 47 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 49 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Index.razor"
       
    private List<Job> _jobs;
    
    public override SecurityAccessLevel SecurityAccessLevel { get { return SecurityAccessLevel.Host; } }

    protected override async Task OnParametersSetAsync()
    {
        _jobs = await JobService.GetJobsAsync();
    }

    private string DisplayStatus(bool isEnabled, bool isExecuting)
    {
        var status = string.Empty;
        if (!isEnabled)
        {
            status = "Disabled";
        }
        else
        {
            if (isExecuting)
            {
                status = "Executing";
            }
            else
            {
                status = "Idle";
            }
        }

        return status;
    }


    private string DisplayFrequency(int interval, string frequency)
    {
        var  result = "Every " + interval.ToString() + " ";
        switch (frequency)
        {
            case "m":
                result += "Minute";
                break;
            case "H":
                result += "Hour";
                break;
            case "d":
                result += "Day";
                break;
            case "M":
                result += "Month";
                break;
        }
        
        if (interval > 1)
        {
            result += "s";
        }
        
        return result;
    }

    private async Task DeleteJob(Job job)
    {
        try
        {
            await JobService.DeleteJobAsync(job.JobId);
            await logger.LogInformation("Job Deleted {Job}", job);
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Deleting Job {Job} {Error}", job, ex.Message);
            AddModuleMessage("Error Deleting Job", MessageType.Error);
        }
    }

    private async Task StartJob(int jobId)
    {
        await JobService.StartJobAsync(jobId);
    }

    private async Task StopJob(int jobId)
    {
        await JobService.StopJobAsync(jobId);
    }

    private async Task Refresh()
    {
        _jobs = await JobService.GetJobsAsync();
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJobService JobService { get; set; }
    }
}
namespace __Blazor.Oqtane.Modules.Admin.Jobs.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreatePager_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
        {
        __builder.OpenComponent<global::Oqtane.Modules.Controls.Pager<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Header", __arg1);
        __builder.AddAttribute(__seq2, "Row", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
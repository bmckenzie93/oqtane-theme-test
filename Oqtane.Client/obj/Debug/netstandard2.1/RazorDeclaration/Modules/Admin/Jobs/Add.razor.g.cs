#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Jobs/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34b7af991cb9681692e2d9f0792cdd28936213b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Jobs
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using System;

#line default
#line hidden
#line 2 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 3 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#line 4 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 6 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 7 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 8 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 9 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Models;

#line default
#line hidden
#line 12 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Modules;

#line default
#line hidden
#line 13 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Modules.Controls;

#line default
#line hidden
#line 14 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Providers;

#line default
#line hidden
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Security;

#line default
#line hidden
#line 16 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Services;

#line default
#line hidden
#line 17 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Shared;

#line default
#line hidden
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Themes;

#line default
#line hidden
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Themes.Controls;

#line default
#line hidden
#line 20 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.UI;

#line default
#line hidden
#line 21 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/_Imports.razor"
using Oqtane.Enums;

#line default
#line hidden
    public partial class Add : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 76 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Jobs/Add.razor"
       
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

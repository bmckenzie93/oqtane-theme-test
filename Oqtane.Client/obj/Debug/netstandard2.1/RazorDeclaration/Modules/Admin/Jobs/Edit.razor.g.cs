#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec513df3aba72bdd651ba9f8f54154610674e25a"
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
    public partial class Edit : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 84 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Jobs/Edit.razor"
       
    private int _jobId;
    private string _name = string.Empty;
    private string _jobType = string.Empty;
    private string _isEnabled = "True";
    private string _interval = string.Empty;
    private string _frequency = string.Empty;
    private string _startDate = string.Empty;
    private string _endDate = string.Empty;
    private string _retentionHistory = string.Empty;
    private string _nextExecution = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _jobId = Int32.Parse(PageState.QueryString["id"]);
            Job job = await JobService.GetJobAsync(_jobId);
            if (job != null)
            {
                _name = job.Name;
                _jobType = job.JobType;
                _isEnabled = job.IsEnabled.ToString();
                _interval = job.Interval.ToString();
                _frequency = job.Frequency;
                _startDate = (job.StartDate != null) ? job.StartDate.ToString() : string.Empty;
                _endDate = (job.EndDate != null) ? job.EndDate.ToString() : string.Empty;
                _retentionHistory = job.RetentionHistory.ToString();
                _nextExecution = job.NextExecution.ToString();
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Job {JobId} {Error}", _jobId, ex.Message);
            AddModuleMessage("Error Loading Job", MessageType.Error);
        }
    }

    private async Task SaveJob()
    {
        if (_name != string.Empty && !string.IsNullOrEmpty(_jobType) && _frequency != string.Empty && _interval != string.Empty && _retentionHistory != string.Empty)
        {
            var job = await JobService.GetJobAsync(_jobId);
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

            if (_nextExecution == string.Empty)
            {
                job.NextExecution = null;
            }
            else
            {
                job.NextExecution = DateTime.Parse(_nextExecution);
            }
            
            job.RetentionHistory = int.Parse(_retentionHistory);

            try
            {
                job = await JobService.UpdateJobAsync(job);
                await logger.LogInformation("Job Updated {Job}", job);
                NavigationManager.NavigateTo(NavigateUrl());
            }
            catch (Exception ex)
            {
                await logger.LogError(ex, "Error Udate Job {Job} {Error}", job, ex.Message);
                AddModuleMessage("Error Updating Job", MessageType.Error);
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
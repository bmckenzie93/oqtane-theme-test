#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleDefinitions/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b602f948adf71769d6c1165aa59fb5e528cc0ee9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.ModuleDefinitions
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
        }
        #pragma warning restore 1998
#line 49 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleDefinitions/Add.razor"
       
    private List<Package> _packages;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var moduledefinitions = await ModuleDefinitionService.GetModuleDefinitionsAsync(PageState.Site.SiteId);
            _packages = await PackageService.GetPackagesAsync("module");

            foreach (Package package in _packages.ToArray())
            {
                if (moduledefinitions.Exists(item => Utilities.GetTypeName(item.ModuleDefinitionName) == package.PackageId))
                {
                    _packages.Remove(package);
                }
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Packages {Error}", ex.Message);
            AddModuleMessage("Error Loading Packages", MessageType.Error);
        }
    }

    private async Task InstallModules()
    {
        try
        {
            ShowProgressIndicator();
            var interop = new Interop(JSRuntime);
            await interop.RedirectBrowser(NavigateUrl(), 10);
            await ModuleDefinitionService.InstallModuleDefinitionsAsync();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Installating Module");
        }
    }

    private async Task DownloadModule(string packageid, string version)
    {
        try
        {
            await PackageService.DownloadPackageAsync(packageid, version, "Modules");
            await logger.LogInformation("Module {ModuleDefinitionName} {Version} Downloaded Successfully", packageid, version);
            AddModuleMessage("Modules Downloaded Successfully. Click Install To Complete Installation.", MessageType.Success);
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Downloading Module {ModuleDefinitionName} {Version}", packageid, version);
            AddModuleMessage("Error Downloading Module", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPackageService PackageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleDefinitionService ModuleDefinitionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileService FileService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
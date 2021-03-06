#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adbeee587ef41e8e8e3dc1dc5adb8df4d6e0b02"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Sites
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
    public partial class Index : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 29 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Index.razor"
       
    private List<Alias> _sites;
    private string _scheme;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnParametersSetAsync()
    {
        var uri = new Uri(NavigationManager.Uri);
        _scheme = uri.Scheme + "://";

        var aliases = await AliasService.GetAliasesAsync();
        _sites = new List<Alias>();
        foreach (Alias alias in aliases)
        {
            if (!_sites.Exists(item => item.TenantId == alias.TenantId && item.SiteId == alias.SiteId))
            {
                _sites.Add(alias);
            }
        }
    }

    private async Task DeleteSite(Alias alias)
    {
        try
        {
            if (alias.SiteId != PageState.Site.SiteId || alias.TenantId != PageState.Site.TenantId)
            {
                SiteService.SetAlias(alias);
                await SiteService.DeleteSiteAsync(alias.SiteId);
                await Log(alias, LogLevel.Information, "", null, "Site Deleted {SiteId}", alias.SiteId);
                
                var aliases = await AliasService.GetAliasesAsync();
                foreach (Alias a in aliases.Where(item => item.SiteId == alias.SiteId && item.TenantId == alias.TenantId))
                {
                    await AliasService.DeleteAliasAsync(a.AliasId);
                }
                
                NavigationManager.NavigateTo(NavigateUrl());
            }
            else
            {
                AddModuleMessage("You Can Not Delete The Current Site", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await Log(alias, LogLevel.Error, "", ex, "Error Deleting Site {SiteId} {Error}", alias.SiteId, ex.Message);
            AddModuleMessage("Error Deleting Site", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISiteService SiteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAliasService AliasService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

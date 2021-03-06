#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Tenants/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c86bf84b13c4744034f5309c6b726be86bdad469"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Tenants
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
#line 27 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Tenants/Index.razor"
       
    private List<Tenant> tenants;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnParametersSetAsync()
    {
        tenants = await TenantService.GetTenantsAsync();
    }

    private async Task DeleteTenant(Tenant Tenant)
    {
        try
        {
            string message = string.Empty;
            var aliases = await AliasService.GetAliasesAsync();
            foreach (var alias in aliases)
            {
                if (alias.TenantId == Tenant.TenantId)
                {
                    message += ", " + alias.Name;
                }
            }
            if (string.IsNullOrEmpty(message))
            {
                await TenantService.DeleteTenantAsync(Tenant.TenantId);
                await logger.LogInformation("Tenant Deleted {Tenant}", Tenant);
                StateHasChanged();
            }
            else
            {
                AddModuleMessage("Tenant Cannot Be Deleted Until The Following Sites Are Deleted: " + message.Substring(2), MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Deleting Tenant {Tenant} {Error}", Tenant, ex.Message);
            AddModuleMessage("Error Deleting Tenant", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAliasService AliasService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
    }
}
#pragma warning restore 1591

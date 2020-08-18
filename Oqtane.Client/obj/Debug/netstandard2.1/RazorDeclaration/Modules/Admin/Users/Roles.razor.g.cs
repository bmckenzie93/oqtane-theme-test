#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d884eaaa8e8dc02760f35a2f9f2aefdcd9f0f1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Users
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
    public partial class Roles : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 76 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Roles.razor"
       
    private int userid;
    private string name = string.Empty;
    private List<Role> roles;
    private int roleid = -1;
    private string effectivedate = string.Empty;
    private string expirydate = string.Empty;
    private List<UserRole> userroles;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            userid = Int32.Parse(PageState.QueryString["id"]);
            User user = await UserService.GetUserAsync(userid, PageState.Site.SiteId);
            name = user.DisplayName;
            roles = await RoleService.GetRolesAsync(PageState.Site.SiteId);
            await GetUserRoles();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Roles {Error}", ex.Message);
            AddModuleMessage("Error Loading Roles", MessageType.Error);
        }
    }

    private async Task GetUserRoles()
    {
        try
        {
            userroles = await UserRoleService.GetUserRolesAsync(PageState.Site.SiteId);
            userroles = userroles.Where(item => item.UserId == userid).ToList();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading User Roles {UserId} {Error}", userid, ex.Message);
            AddModuleMessage("Error Loading User Roles", MessageType.Error);
        }
    }

    private async Task SaveUserRole()
    {
        try
        {
            if (roleid != -1)
            {
                var userrole = userroles.Where(item => item.UserId == userid && item.RoleId == roleid).FirstOrDefault();
                if (userrole != null)
                {
                    if (string.IsNullOrEmpty(effectivedate))
                    {
                        userrole.EffectiveDate = null;
                    }
                    else
                    {
                        userrole.EffectiveDate = DateTime.Parse(effectivedate);
                    }

                    if (string.IsNullOrEmpty(expirydate))
                    {
                        userrole.ExpiryDate = null;
                    }
                    else
                    {
                        userrole.ExpiryDate = DateTime.Parse(expirydate);
                    }
                    await UserRoleService.UpdateUserRoleAsync(userrole);
                }
                else
                {
                    userrole = new UserRole();
                    userrole.UserId = userid;
                    userrole.RoleId = roleid;

                    if (string.IsNullOrEmpty(effectivedate))
                    {
                        userrole.EffectiveDate = null;
                    }
                    else
                    {
                        userrole.EffectiveDate = DateTime.Parse(effectivedate);
                    }

                    if (string.IsNullOrEmpty(expirydate))
                    {
                        userrole.ExpiryDate = null;
                    }
                    else
                    {
                        userrole.ExpiryDate = DateTime.Parse(expirydate);
                    }

                    await UserRoleService.AddUserRoleAsync(userrole);
                }

                await GetUserRoles();
                await logger.LogInformation("User Assigned To Role {UserRole}", userrole);
                AddModuleMessage("User Assigned To Role", MessageType.Success);
            }
            else
            {
                AddModuleMessage("You Must Select A Role", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Saving User Roles {UserId} {Error}", userid, ex.Message);
            AddModuleMessage("Error Saving User Roles", MessageType.Error);
        }
    }

    private async Task DeleteUserRole(int UserRoleId)
    {
        try
        {
            await UserRoleService.DeleteUserRoleAsync(UserRoleId);
            await GetUserRoles();
            await logger.LogInformation("User Removed From Role {UserRoleId}", UserRoleId);
            AddModuleMessage("User Removed From Role", MessageType.Success);
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Removing User From Role {UserRoleId} {Error}", UserRoleId, ex.Message);
            AddModuleMessage("Error Removing User From Role", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRoleService UserRoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService RoleService { get; set; }
    }
}
#pragma warning restore 1591

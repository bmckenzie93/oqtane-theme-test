#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc51080b18760d53744b6ec1d245c2bfe6520ab6"
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
#line 96 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
       
    private string username = string.Empty;
    private string password = string.Empty;
    private string confirm = string.Empty;
    private string email = string.Empty;
    private string displayname = string.Empty;
    private List<Profile> profiles;
    private Dictionary<string, string> settings;
    private string category = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            profiles = await ProfileService.GetProfilesAsync(ModuleState.SiteId);
            settings = new Dictionary<string, string>();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading User Profile {Error}", ex.Message);
            AddModuleMessage("Error Loading User Profile", MessageType.Error);
        }
    }

    private string GetProfileValue(string SettingName, string DefaultValue)
        => SettingService.GetSetting(settings, SettingName, DefaultValue);

    private async Task SaveUser()
    {
        try
        {
            if (username != string.Empty && password != string.Empty && confirm != string.Empty && email != string.Empty && ValidateProfiles())
            {
                if (password == confirm)
                {
                    var user = new User();
                    user.SiteId = PageState.Site.SiteId;
                    user.Username = username;
                    user.Password = password;
                    user.Email = email;
                    user.DisplayName = string.IsNullOrWhiteSpace(displayname) ? username : displayname;
                    user.PhotoFileId = null;

                    user = await UserService.AddUserAsync(user);

                    if (user != null)
                    {
                        await SettingService.UpdateUserSettingsAsync(settings, user.UserId);
                        await logger.LogInformation("User Created {User}", user);
                        NavigationManager.NavigateTo(NavigateUrl());
                    }
                    else
                    {
                        await logger.LogError("Error Adding User {Username} {Email}", username, email);
                        AddModuleMessage("Error Adding User. Please Ensure Password Meets Complexity Requirements And Username Is Not Already In Use.", MessageType.Error);
                    }
                }
                else
                {
                    AddModuleMessage("Passwords Entered Do Not Match", MessageType.Warning);
                }
            }
            else
            {
                AddModuleMessage("You Must Provide A Username, Password, Email Address And All Required Profile Information", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Adding User {Username} {Email} {Error}", username, email, ex.Message);
            AddModuleMessage("Error Adding User", MessageType.Error);
        }
    }

    private bool ValidateProfiles()
    {
        bool valid = true;
        foreach (Profile profile in profiles)
        {
            if (string.IsNullOrEmpty(SettingService.GetSetting(settings, profile.Name, string.Empty)) && !string.IsNullOrEmpty(profile.DefaultValue))
            {
                settings = SettingService.SetSetting(settings, profile.Name, profile.DefaultValue);
            }
            if (profile.IsRequired && string.IsNullOrEmpty(SettingService.GetSetting(settings, profile.Name, string.Empty)))
            {
                valid = false;
            }
        }
        return valid;
    }
    
    private void ProfileChanged(ChangeEventArgs e, string SettingName)
    {
        var value = (string)e.Value;
        settings = SettingService.SetSetting(settings, SettingName, value);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISettingService SettingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProfileService ProfileService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

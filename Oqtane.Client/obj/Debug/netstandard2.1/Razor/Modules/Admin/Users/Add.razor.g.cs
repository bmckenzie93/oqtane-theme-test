#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc51080b18760d53744b6ec1d245c2bfe6520ab6"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Oqtane.Modules.Controls.TabStrip>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(3);
                __builder2.AddAttribute(4, "Name", "Identity");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\n");
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
         if (profiles != null)
        {

#line default
#line hidden
                    __builder3.AddContent(7, "            ");
                    __builder3.OpenElement(8, "table");
                    __builder3.AddAttribute(9, "class", "table table-borderless");
                    __builder3.AddMarkupContent(10, "\n                ");
                    __builder3.OpenElement(11, "tr");
                    __builder3.AddMarkupContent(12, "\n                    ");
                    __builder3.AddMarkupContent(13, "<td>\n                        <label class=\"control-label\">Username: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(14, "td");
                    __builder3.AddMarkupContent(15, "\n                        ");
                    __builder3.OpenElement(16, "input");
                    __builder3.AddAttribute(17, "class", "form-control");
                    __builder3.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 18 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                            username

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenElement(23, "tr");
                    __builder3.AddMarkupContent(24, "\n                    ");
                    __builder3.AddMarkupContent(25, "<td>\n                        <label class=\"control-label\">Password: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(26, "td");
                    __builder3.AddMarkupContent(27, "\n                        ");
                    __builder3.OpenElement(28, "input");
                    __builder3.AddAttribute(29, "type", "password");
                    __builder3.AddAttribute(30, "class", "form-control");
                    __builder3.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 26 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                            password

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\n                ");
                    __builder3.OpenElement(36, "tr");
                    __builder3.AddMarkupContent(37, "\n                    ");
                    __builder3.AddMarkupContent(38, "<td>\n                        <label class=\"control-label\">Confirm Password: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(39, "td");
                    __builder3.AddMarkupContent(40, "\n                        ");
                    __builder3.OpenElement(41, "input");
                    __builder3.AddAttribute(42, "type", "password");
                    __builder3.AddAttribute(43, "class", "form-control");
                    __builder3.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 34 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                            confirm

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirm = __value, confirm));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\n                ");
                    __builder3.OpenElement(49, "tr");
                    __builder3.AddMarkupContent(50, "\n                    ");
                    __builder3.AddMarkupContent(51, "<td>\n                        <label class=\"control-label\">Email: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(52, "td");
                    __builder3.AddMarkupContent(53, "\n                        ");
                    __builder3.OpenElement(54, "input");
                    __builder3.AddAttribute(55, "class", "form-control");
                    __builder3.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 42 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                            email

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenElement(61, "tr");
                    __builder3.AddMarkupContent(62, "\n                    ");
                    __builder3.AddMarkupContent(63, "<td>\n                        <label class=\"control-label\">Full Name: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(64, "td");
                    __builder3.AddMarkupContent(65, "\n                        ");
                    __builder3.OpenElement(66, "input");
                    __builder3.AddAttribute(67, "class", "form-control");
                    __builder3.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 50 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                            displayname

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayname = __value, displayname));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n");
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(74, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(76);
                __builder2.AddAttribute(77, "Name", "Profile");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "\n");
#line 57 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
         if (profiles != null)
        {

#line default
#line hidden
                    __builder3.AddContent(80, "        ");
                    __builder3.OpenElement(81, "table");
                    __builder3.AddAttribute(82, "class", "table table-borderless");
                    __builder3.AddMarkupContent(83, "\n");
#line 60 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
             foreach (Profile profile in profiles)
            {
                var p = profile;
                if (p.Category != category)
                {

#line default
#line hidden
                    __builder3.AddContent(84, "                    ");
                    __builder3.OpenElement(85, "tr");
                    __builder3.AddMarkupContent(86, "\n                        ");
                    __builder3.OpenElement(87, "th");
                    __builder3.AddAttribute(88, "colspan", "2");
                    __builder3.AddAttribute(89, "style", "text-align: center;");
                    __builder3.AddMarkupContent(90, "\n                            ");
                    __builder3.AddContent(91, 
#line 67 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                             p.Category

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(92, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n");
#line 70 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                    category = p.Category;
                }

#line default
#line hidden
                    __builder3.AddContent(95, "                ");
                    __builder3.OpenElement(96, "tr");
                    __builder3.AddMarkupContent(97, "\n                    ");
                    __builder3.OpenElement(98, "td");
                    __builder3.AddMarkupContent(99, "\n                        ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.Label>(100);
                    __builder3.AddAttribute(101, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 74 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                     p.Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(102, "HelpText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 74 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                        p.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(104, 
#line 74 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                        p.Title

#line default
#line hidden
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n                    ");
                    __builder3.OpenElement(107, "td");
                    __builder3.AddMarkupContent(108, "\n");
#line 77 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                         if (p.IsRequired)
                        {

#line default
#line hidden
                    __builder3.AddContent(109, "                            ");
                    __builder3.OpenElement(110, "input");
                    __builder3.AddAttribute(111, "id", 
#line 79 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                        p.Name

#line default
#line hidden
                    );
                    __builder3.AddAttribute(112, "class", "form-control");
                    __builder3.AddAttribute(113, "maxlength", 
#line 79 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                 p.MaxLength

#line default
#line hidden
                    );
                    __builder3.AddAttribute(114, "value", 
#line 79 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                                      GetProfileValue(p.Name, p.DefaultValue)

#line default
#line hidden
                    );
                    __builder3.AddAttribute(115, "required", true);
                    __builder3.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 79 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                                                                                                     e => ProfileChanged(e, p.Name)

#line default
#line hidden
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\n");
#line 80 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                        }
                        else
                        {

#line default
#line hidden
                    __builder3.AddContent(118, "                            ");
                    __builder3.OpenElement(119, "input");
                    __builder3.AddAttribute(120, "id", 
#line 83 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                        p.Name

#line default
#line hidden
                    );
                    __builder3.AddAttribute(121, "class", "form-control");
                    __builder3.AddAttribute(122, "maxlength", 
#line 83 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                 p.MaxLength

#line default
#line hidden
                    );
                    __builder3.AddAttribute(123, "value", 
#line 83 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                                      GetProfileValue(p.Name, p.DefaultValue)

#line default
#line hidden
                    );
                    __builder3.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 83 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                                                                                                                            e => ProfileChanged(e, p.Name)

#line default
#line hidden
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\n");
#line 84 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                        }

#line default
#line hidden
                    __builder3.AddContent(126, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(128, "\n");
#line 87 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
            }

#line default
#line hidden
                    __builder3.AddContent(129, "        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n");
#line 89 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(131, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(133, "\n\n");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "type", "button");
            __builder.AddAttribute(136, "class", "btn btn-primary");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 93 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                                        SaveUser

#line default
#line hidden
            ));
            __builder.AddContent(138, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(140);
            __builder.AddAttribute(141, "class", "btn btn-secondary");
            __builder.AddAttribute(142, "href", 
#line 94 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Users/Add.razor"
                                          NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(144, "Cancel");
            }
            ));
            __builder.CloseComponent();
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

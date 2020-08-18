#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3da7ad736e4d1c5ebc130acf294026c9b14e819"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Themes.Controls
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
    public partial class UserProfile : ThemeControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "class", "app-profile");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\n            ");
                __builder2.AddMarkupContent(6, "<text>...</text>\n        ");
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\n            ");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "type", "button");
                __builder2.AddAttribute(11, "class", "btn btn-primary");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
                                                                    UpdateProfile

#line default
#line hidden
                ));
                __builder2.AddContent(13, 
#line 12 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
                                                                                    context.User.Identity.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n        ");
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\n");
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
             if (PageState.Site.AllowRegistration)
            {

#line default
#line hidden
                __builder2.AddContent(17, "                ");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "type", "button");
                __builder2.AddAttribute(20, "class", "btn btn-primary");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
                                                                        RegisterUser

#line default
#line hidden
                ));
                __builder2.AddContent(22, "Register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n");
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
            }

#line default
#line hidden
                __builder2.AddContent(24, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 23 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/Controls/UserProfile.razor"
       

    private void RegisterUser()
    {
        NavigationManager.NavigateTo(NavigateUrl("register"));
    }

    private void UpdateProfile()
    {
        NavigationManager.NavigateTo(NavigateUrl("profile"));
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

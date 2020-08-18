#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/ActionDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf14ffd029c387421f8b2507f0e69885f26b1cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Controls
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
    public partial class ActionDialog : ModuleControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 41 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/ActionDialog.razor"
       
    private bool _visible = false;
    private bool _editmode = false;
    private bool _authorized = false;
    private string _iconSpan = string.Empty;

    [Parameter]
    public string Header { get; set; } // required

    [Parameter]
    public string Message { get; set; } // required

    [Parameter]
    public string Text { get; set; } // optional - defaults to Action if not specified

    [Parameter]
    public string Action { get; set; } // optional

    [Parameter]
    public SecurityAccessLevel? Security { get; set; } // optional - can be used to explicitly specify SecurityAccessLevel

    [Parameter]
    public string Class { get; set; } // optional

    [Parameter]
    public bool Disabled { get; set; } // optional

    [Parameter]
    public string EditMode { get; set; } // optional - specifies if an authorized user must be in edit mode to see the action - default is false

    [Parameter]
    public Action OnClick { get; set; } // required if an Action is specified - executes a method in the calling component

    [Parameter]
    public string IconName { get; set; } // optional - specifies an icon for the link - default is no icon

    protected override void OnParametersSet()
    {
        if (string.IsNullOrEmpty(Text))
        {
            Text = Action;
        }
        if (string.IsNullOrEmpty(Class))
        {
            Class = "btn btn-success";
        }

        if (!string.IsNullOrEmpty(EditMode))
        {
            _editmode = bool.Parse(EditMode);
        }

        if (!string.IsNullOrEmpty(IconName))
        {
            _iconSpan = $"<span class=\"oi oi-{IconName}\"></span>&nbsp;";
        }

        _authorized = IsAuthorized();
    }

    private bool IsAuthorized()
    {
        bool authorized = false;
        if (PageState.EditMode || !_editmode)
        {
            SecurityAccessLevel security = SecurityAccessLevel.Host;
            if (Security == null)
            {
                string typename = ModuleState.ModuleType.Replace(Utilities.GetTypeNameLastSegment(ModuleState.ModuleType, 0) + ",", Action + ",");
                Type moduleType = Type.GetType(typename);
                if (moduleType != null)
                {
                    var moduleobject = Activator.CreateInstance(moduleType) as IModuleControl;
                    security = moduleobject.SecurityAccessLevel;
                }
                else
                {
                    security = SecurityAccessLevel.Anonymous; // occurs when an action does not have a corresponding module control
                }
            }
            else
            {
                security = Security.Value;
            }
            switch (security)
            {
                case SecurityAccessLevel.Anonymous:
                    authorized = true;
                    break;
                case SecurityAccessLevel.View:
                    authorized = UserSecurity.IsAuthorized(PageState.User,PermissionNames.View, ModuleState.Permissions);
                    break;
                case SecurityAccessLevel.Edit:
                    authorized = UserSecurity.IsAuthorized(PageState.User,PermissionNames.Edit, ModuleState.Permissions);
                    break;
                case SecurityAccessLevel.Admin:
                    authorized = UserSecurity.IsAuthorized(PageState.User, Constants.AdminRole);
                    break;
                case SecurityAccessLevel.Host:
                    authorized = UserSecurity.IsAuthorized(PageState.User, Constants.HostRole);
                    break;
            }
        }
        return authorized;
    }

    private void DisplayModal()
    {
        _visible = !_visible;
        StateHasChanged();
    }

    private void Confirm()
    {
        DisplayModal();
        OnClick();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

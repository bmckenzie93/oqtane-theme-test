#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/Pane.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "987e4da4da1c6c0d224f139d1c09305739cf56d0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.UI
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
#line 1 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/Pane.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
    public partial class Pane : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/Pane.razor"
       
    private string _paneadminborder = "";
    private string _panetitle = "";

    [CascadingParameter]
    protected PageState PageState { get; set; }

    [Parameter]
    public string Name { get; set; }

    RenderFragment DynamicComponent { get; set; }

    protected override void OnParametersSet()
    {
        if (PageState.EditMode && UserSecurity.IsAuthorized(PageState.User,PermissionNames.Edit, PageState.Page.Permissions) && Name != Constants.AdminPane)
        {
            _paneadminborder = "app-pane-admin-border";
            _panetitle = "<div class=\"app-pane-admin-title\">" + Name + " Pane</div>";
        }
        else
        {
            _paneadminborder = "container";
            _panetitle = "";
        }

        DynamicComponent = builder =>
        {
            if (PageState.ModuleId != -1 && PageState.Action != Constants.DefaultAction)
            {
                if (Name.ToLower() == Constants.AdminPane.ToLower())
                {
                    Module module = PageState.Modules.FirstOrDefault(item => item.ModuleId == PageState.ModuleId);
                    if (module != null && !module.IsDeleted)
                    {
                        var typename = module.ModuleType;
                        // check for core module actions component
                        if (Constants.DefaultModuleActions.Contains(PageState.Action))
                        {
                            typename = Constants.DefaultModuleActionsTemplate.Replace(Constants.ActionToken, PageState.Action);
                        }

                        var moduleType = Type.GetType(typename);
                        if (moduleType != null)
                        {
                            bool authorized = false;
                            if (Constants.DefaultModuleActions.Contains(PageState.Action))
                            {
                                authorized = UserSecurity.IsAuthorized(PageState.User, PermissionNames.Edit, PageState.Page.Permissions);
                            }
                            else
                            {
                                switch (module.SecurityAccessLevel)
                                {
                                    case SecurityAccessLevel.Anonymous:
                                        authorized = true;
                                        break;
                                    case SecurityAccessLevel.View:
                                        authorized = UserSecurity.IsAuthorized(PageState.User, PermissionNames.View, module.Permissions);
                                        break;
                                    case SecurityAccessLevel.Edit:
                                        authorized = UserSecurity.IsAuthorized(PageState.User, PermissionNames.Edit, module.Permissions);
                                        break;
                                    case SecurityAccessLevel.Admin:
                                        authorized = UserSecurity.IsAuthorized(PageState.User, Constants.AdminRole);
                                        break;
                                    case SecurityAccessLevel.Host:
                                        authorized = UserSecurity.IsAuthorized(PageState.User, Constants.HostRole);
                                        break;
                                }
                            }

                            if (authorized)
                            {
                                if (!Constants.DefaultModuleActions.Contains(PageState.Action) && module.ControlTitle != "")
                                {
                                    module.Title = module.ControlTitle;
                                }
                                CreateComponent(builder, module);
                            }
                        }
                        else
                        {
                            // module control does not exist with name specified
                        }
                    }
                }
            }
            else
            {
                if (PageState.ModuleId != -1)
                {
                    Module module = PageState.Modules.FirstOrDefault(item => item.ModuleId == PageState.ModuleId);
                    if (module != null && module.Pane.ToLower() == Name.ToLower() && !module.IsDeleted)
                    {
                        // check if user is authorized to view module
                        if (UserSecurity.IsAuthorized(PageState.User, PermissionNames.View, module.Permissions))
                        {
                            CreateComponent(builder, module);
                        }
                    }
                }
                else
                {
                    foreach (Module module in PageState.Modules.Where(item => item.PageId == PageState.Page.PageId && item.Pane.ToLower() == Name.ToLower() && !item.IsDeleted).OrderBy(x => x.Order).ToArray())
                    {
                        // check if user is authorized to view module
                        if (UserSecurity.IsAuthorized(PageState.User, PermissionNames.View, module.Permissions))
                        {
                            CreateComponent(builder, module);
                        }
                    }
                }
            }
        };
    }

    private void CreateComponent(RenderTreeBuilder builder, Module module)
    {
        builder.OpenComponent(0, Type.GetType(Constants.ContainerComponent));
        builder.AddAttribute(1, "Module", module);
        builder.SetKey(module.PageModuleId);
        builder.CloseComponent();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleDefinitionService ModuleDefinitionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleService ModuleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591

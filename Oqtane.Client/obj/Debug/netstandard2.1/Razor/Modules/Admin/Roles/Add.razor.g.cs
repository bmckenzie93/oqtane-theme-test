#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe38e5f280070796ca28676e337452b750e8a0a"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Roles
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
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-borderless");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "td");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(7);
            __builder.AddAttribute(8, "For", "name");
            __builder.AddAttribute(9, "HelpText", "Name Of The Role");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Name:");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "id", "name");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
                                                          _name

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _name = __value, _name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(28);
            __builder.AddAttribute(29, "For", "description");
            __builder.AddAttribute(30, "HelpText", "A Short Description Of The Role Which Describes Its Purpose");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Description:");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "textarea");
            __builder.AddAttribute(38, "id", "description");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "rows", "5");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 20 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
                                                                    _description

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _description = __value, _description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\n        ");
            __builder.OpenElement(48, "td");
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(50);
            __builder.AddAttribute(51, "For", "isautoassigned");
            __builder.AddAttribute(52, "HelpText", "Indicates Whether Or Not New Users Are Automatically Assigned To This Role");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(54, "Auto Assigned?");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n        ");
            __builder.OpenElement(57, "td");
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "select");
            __builder.AddAttribute(60, "id", "isautoassigned");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 28 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
                                                                     _isautoassigned

#line default
#line hidden
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _isautoassigned = __value, _isautoassigned));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(64, "\n                ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "True");
            __builder.AddContent(67, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                ");
            __builder.OpenElement(69, "option");
            __builder.AddAttribute(70, "value", "False");
            __builder.AddContent(71, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "class", "btn btn-success");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 35 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
                                                        SaveRole

#line default
#line hidden
            ));
            __builder.AddContent(81, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
            __builder.AddAttribute(84, "class", "btn btn-secondary");
            __builder.AddAttribute(85, "href", 
#line 36 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
                                          NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(87, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 38 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Roles/Add.razor"
        
    private string _name = string.Empty;
    private string _description = string.Empty;
    private string _isautoassigned = "False";

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    private async Task SaveRole()
    {
        var role = new Role();
        role.SiteId = PageState.Page.SiteId;
        role.Name = _name;
        role.Description = _description;
        role.IsAutoAssigned = (_isautoassigned == null ? false : Boolean.Parse(_isautoassigned));
        role.IsSystem = false;

        try
        {
            role = await RoleService.AddRoleAsync(role);
            await logger.LogInformation("Role Added {Role}", role);

            NavigationManager.NavigateTo(NavigateUrl());
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Adding Role {Role} {Error}", role, ex.Message);
            AddModuleMessage("Error Adding Role", MessageType.Error);
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
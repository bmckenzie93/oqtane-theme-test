#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Modules/Export.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5be072c3c69a6dd936b3015968be19c9c1631c6"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Modules
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
    public partial class Export : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-borderless");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "tbody");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddMarkupContent(8, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(9);
            __builder.AddAttribute(10, "For", "content");
            __builder.AddAttribute(11, "HelpText", "Enter the module content");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, "Content: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "textarea");
            __builder.AddAttribute(19, "id", "content");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "rows", "5");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Modules/Export.razor"
                                                                    _content

#line default
#line hidden
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _content = __value, _content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-success");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Modules/Export.razor"
                                                        ExportModule

#line default
#line hidden
            ));
            __builder.AddContent(33, "Export");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "btn btn-secondary");
            __builder.AddAttribute(37, "href", 
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Modules/Export.razor"
                                          NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 22 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Modules/Export.razor"
       
    private string _content = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;
    public override string Title => "Export Module";


    private async Task ExportModule()
    {
        _content = await ModuleService.ExportModuleAsync(ModuleState.ModuleId);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleService ModuleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
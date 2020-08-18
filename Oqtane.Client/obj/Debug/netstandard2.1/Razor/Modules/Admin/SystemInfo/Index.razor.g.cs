#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ea2cd7a4f6401fdd81b848f1bda9ade44eb6d3"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.SystemInfo
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
    public partial class Index : ModuleBase
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
            __builder.AddAttribute(8, "For", "version");
            __builder.AddAttribute(9, "HelpText", "Framework Version");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Framework Version: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "id", "version");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "readonly", true);
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                             _version

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _version = __value, _version));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(29);
            __builder.AddAttribute(30, "For", "runtime");
            __builder.AddAttribute(31, "HelpText", "Blazor Runtime (Server or WebAssembly)");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Blazor Runtime: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "id", "runtime");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "readonly", true);
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                             _runtime

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _runtime = __value, _runtime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n    ");
            __builder.OpenElement(47, "tr");
            __builder.AddMarkupContent(48, "\n        ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(51);
            __builder.AddAttribute(52, "For", "clrversion");
            __builder.AddAttribute(53, "HelpText", "Common Language Runtime Version");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(55, "CLR Version: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\n            ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "id", "clrversion");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "readonly", true);
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 27 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                                _clrversion

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _clrversion = __value, _clrversion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n    ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\n        ");
            __builder.OpenElement(71, "td");
            __builder.AddMarkupContent(72, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(73);
            __builder.AddAttribute(74, "For", "osversion");
            __builder.AddAttribute(75, "HelpText", "Operating System Version");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(77, "OS Version: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n        ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "\n            ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "id", "osversion");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "readonly", true);
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 35 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                               _osversion

#line default
#line hidden
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _osversion = __value, _osversion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n    ");
            __builder.OpenElement(91, "tr");
            __builder.AddMarkupContent(92, "\n        ");
            __builder.OpenElement(93, "td");
            __builder.AddMarkupContent(94, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(95);
            __builder.AddAttribute(96, "For", "serverpath");
            __builder.AddAttribute(97, "HelpText", "Server Path");
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(99, "Server Path: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n        ");
            __builder.OpenElement(102, "td");
            __builder.AddMarkupContent(103, "\n            ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "id", "serverpath");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "readonly", true);
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 43 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                                _serverpath

#line default
#line hidden
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _serverpath = __value, _serverpath));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n    ");
            __builder.OpenElement(113, "tr");
            __builder.AddMarkupContent(114, "\n        ");
            __builder.OpenElement(115, "td");
            __builder.AddMarkupContent(116, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(117);
            __builder.AddAttribute(118, "For", "servertime");
            __builder.AddAttribute(119, "HelpText", "Server Time");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(121, "Server Time: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n        ");
            __builder.OpenElement(124, "td");
            __builder.AddMarkupContent(125, "\n            ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "id", "servertime");
            __builder.AddAttribute(128, "class", "form-control");
            __builder.AddAttribute(129, "readonly", true);
            __builder.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 51 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
                                                                _servertime

#line default
#line hidden
            ));
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _servertime = __value, _servertime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n");
            __builder.AddMarkupContent(136, "<a class=\"btn btn-primary\" href=\"swagger/index.html\" target=\"_new\">Access Framework API</a>");
        }
        #pragma warning restore 1998
#line 57 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/SystemInfo/Index.razor"
       
    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    private string _version = string.Empty;
    private string _runtime = string.Empty;
    private string _clrversion = string.Empty;
    private string _osversion = string.Empty;
    private string _serverpath = string.Empty;
    private string _servertime = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        _version = Constants.Version;
        _runtime = PageState.Runtime.ToString();

        Dictionary<string, string> systeminfo = await SystemService.GetSystemInfoAsync();
        if (systeminfo != null)
        {
            _clrversion = systeminfo["clrversion"];
            _osversion = systeminfo["osversion"];
            _serverpath = systeminfo["serverpath"];
            _servertime = systeminfo["servertime"];
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISystemService SystemService { get; set; }
    }
}
#pragma warning restore 1591

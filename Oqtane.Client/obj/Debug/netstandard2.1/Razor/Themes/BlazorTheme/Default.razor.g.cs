#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/BlazorTheme/Default.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eceabe7d394bede8a9811f3bc5ed1ce3ba7b8b38"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Themes.BlazorTheme
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
    public partial class Default : ThemeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "breadcrumbs");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Oqtane.Themes.Controls.Breadcrumbs>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "class", "navbar");
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenComponent<Oqtane.Themes.Controls.Logo>(12);
            __builder.CloseComponent();
            __builder.OpenComponent<Oqtane.Themes.Controls.Menu>(13);
            __builder.AddAttribute(14, "Orientation", "Vertical");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "main");
            __builder.AddMarkupContent(20, "\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "top-row px-4");
            __builder.AddMarkupContent(23, "\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "ml-md-auto");
            __builder.OpenComponent<Oqtane.Themes.Controls.UserProfile>(26);
            __builder.CloseComponent();
            __builder.AddContent(27, " ");
            __builder.OpenComponent<Oqtane.Themes.Controls.Login>(28);
            __builder.CloseComponent();
            __builder.AddContent(29, " ");
            __builder.OpenComponent<Oqtane.Themes.Controls.ControlPanel>(30);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container");
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row px-4");
            __builder.AddMarkupContent(38, "\n            ");
            __builder.OpenComponent<Oqtane.UI.Pane>(39);
            __builder.AddAttribute(40, "Name", "Content");
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row px-4");
            __builder.AddMarkupContent(45, "\n            ");
            __builder.OpenComponent<Oqtane.UI.Pane>(46);
            __builder.AddAttribute(47, "Name", "Admin");
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 28 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Themes/BlazorTheme/Default.razor"
       
    public override string Panes => "Content";

    public override List<Resource> Resources => new List<Resource>()
    {
        new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css", Integrity = "sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk", CrossOrigin = "anonymous" },
        new Resource { ResourceType = ResourceType.Stylesheet, Url = ThemePath() + "Theme.css" },
        new Resource { ResourceType = ResourceType.Script, Bundle = "Bootstrap", Url = "https://code.jquery.com/jquery-3.5.1.slim.min.js", Integrity = "sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj", CrossOrigin = "anonymous" },
        new Resource { ResourceType = ResourceType.Script, Bundle = "Bootstrap", Url = "https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js", Integrity = "sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo", CrossOrigin = "anonymous" },
        new Resource { ResourceType = ResourceType.Script, Bundle = "Bootstrap", Url = "https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js", Integrity = "sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI", CrossOrigin = "anonymous" }
    };


#line default
#line hidden
    }
}
#pragma warning restore 1591

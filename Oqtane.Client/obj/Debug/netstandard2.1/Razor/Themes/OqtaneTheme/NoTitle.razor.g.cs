#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Themes/OqtaneTheme/NoTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b80f48b974048d71036ce2cdd3a4b47d678a16fc"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Themes.OqtaneTheme
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
    public partial class NoTitle : ContainerBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\n");
#line 4 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Themes/OqtaneTheme/NoTitle.razor"
     if (PageState.EditMode)
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenComponent<Oqtane.Themes.Controls.ModuleActions>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
#line 7 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Themes/OqtaneTheme/NoTitle.razor"
    }

#line default
#line hidden
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<Oqtane.UI.ModuleInstance>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Themes/OqtaneTheme/NoTitle.razor"
       
    public override string Name => "No Header";

#line default
#line hidden
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510f0dfb4959f620f9342dcb63c320a28b878f6c"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Controls
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
    public partial class Label : ModuleControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
 if (!string.IsNullOrEmpty(HelpText))
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "class", "app-tooltip");
            __builder.AddAttribute(3, "data-tip", 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                          (MarkupString)HelpText

#line default
#line hidden
            );
            __builder.AddContent(4, 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                                                     (MarkupString)_openLabel

#line default
#line hidden
            );
            __builder.AddContent(5, 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                                                                               ChildContent

#line default
#line hidden
            );
            __builder.AddContent(6, 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                                                                                             (MarkupString)_closeLabel

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, " <img src=\"images/help.png\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
#line 7 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
}
else
{
    

#line default
#line hidden
            __builder.AddContent(9, 
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
      (MarkupString)_openLabel

#line default
#line hidden
            );
            __builder.AddContent(10, 
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                ChildContent

#line default
#line hidden
            );
            __builder.AddContent(11, 
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                              (MarkupString)_closeLabel

#line default
#line hidden
            );
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
                                                                        
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Label.razor"
       
    private string _openLabel = string.Empty;
    private string _closeLabel = "</label>";

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string For { get; set; } // optional - the id of the associated input control for accessibility

    [Parameter]
    public string Class { get; set; } // optional - the class for the label ( ie. control-label )

    [Parameter]
    public string HelpText { get; set; } // optional - tooltip for this label

    protected override void OnParametersSet()
    {
        _openLabel = "<label";
        if (!string.IsNullOrEmpty(For))
        {
            _openLabel += " for=\"" + For + "\"";
        }

        if (!string.IsNullOrEmpty(Class))
        {
            _openLabel += " class=\"" + Class + "\"";
        }

        _openLabel += ">";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

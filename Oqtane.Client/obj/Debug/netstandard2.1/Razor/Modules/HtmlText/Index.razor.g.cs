#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291d09c811164549373f21b924ed01e0ed8bb74d"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.HtmlText
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
#line 1 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor"
using Oqtane.Modules.HtmlText.Services;

#line default
#line hidden
    public partial class Index : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor"
  (MarkupString)content

#line default
#line hidden
            );
            __builder.AddMarkupContent(1, "\n\n");
#line 8 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor"
 if (PageState.EditMode)
{

#line default
#line hidden
            __builder.AddMarkupContent(2, "    <br>");
            __builder.OpenComponent<Oqtane.Modules.Controls.ActionLink>(3);
            __builder.AddAttribute(4, "Action", "Edit");
            __builder.AddAttribute(5, "EditMode", "true");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "<br><br>\n");
#line 11 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/HtmlText/Index.razor"
       
    public override List<Resource> Resources => new List<Resource>()
    {
        new Resource { ResourceType = ResourceType.Stylesheet, Url = ModulePath() + "Module.css" }
    };

    private string content = "";

    protected override async Task OnParametersSetAsync()
    {
        try
        {
            var htmltext = await HtmlTextService.GetHtmlTextAsync(ModuleState.ModuleId);
            if (htmltext != null)
            {
                content = htmltext.Content;
                content = content.Replace(Constants.ContentUrl, "/" + PageState.Alias.AliasId.ToString() + Constants.ContentUrl);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "An Error Occurred Loading Html/Text Content. " + ex.Message);
            AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHtmlTextService HtmlTextService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9d7a32129f10f7e4da73abf7d15ceacfe67ec6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.HtmlText
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
#line 1 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
using Oqtane.Modules.HtmlText.Services;

#line default
#line hidden
#line 2 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
using Oqtane.Modules.HtmlText.Models;

#line default
#line hidden
#line 3 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
using Oqtane.Modules.Controls;

#line default
#line hidden
    public partial class Edit : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 22 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
       
    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Edit;

    public override string Title => "Edit Html/Text";

    public override List<Resource> Resources => new List<Resource>()
    {
        new Resource { ResourceType = ResourceType.Stylesheet, Url = ModulePath() + "Module.css" },
        new Resource { ResourceType = ResourceType.Stylesheet, Url = "css/quill/quill1.3.6.bubble.css" },
        new Resource { ResourceType = ResourceType.Stylesheet, Url = "css/quill/quill1.3.6.snow.css" }
    };

    private RichTextEditor RichTextEditorHtml;
    private string _content = null;
    private string _createdby;
    private DateTime _createdon;
    private string _modifiedby;
    private DateTime _modifiedon;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var htmltext = await HtmlTextService.GetHtmlTextAsync(ModuleState.ModuleId);
            if (htmltext != null)
            {
                _content = htmltext.Content;
                _content = _content.Replace(Constants.ContentUrl, "/" + PageState.Alias.AliasId.ToString() + Constants.ContentUrl);
                _createdby = htmltext.CreatedBy;
                _createdon = htmltext.CreatedOn;
                _modifiedby = htmltext.ModifiedBy;
                _modifiedon = htmltext.ModifiedOn;
            }
            else
            {
                _content = string.Empty;
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "An Error Occurred Loading Html/Text Content. " + ex.Message);
            AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

    private async Task SaveContent()
    {
        string content = await RichTextEditorHtml.GetHtml();
        content = content.Replace("/" + PageState.Alias.AliasId.ToString() + Constants.ContentUrl, Constants.ContentUrl);

        try
        {
            var htmltext = await HtmlTextService.GetHtmlTextAsync(ModuleState.ModuleId);
            if (htmltext != null)
            {
                htmltext.Content = content;
                await HtmlTextService.UpdateHtmlTextAsync(htmltext);
            }
            else
            {
                htmltext = new HtmlTextInfo();
                htmltext.ModuleId = ModuleState.ModuleId;
                htmltext.Content = content;
                await HtmlTextService.AddHtmlTextAsync(htmltext);
            }

            await logger.LogInformation("Html/Text Content Saved {HtmlText}", htmltext);
            NavigationManager.NavigateTo(NavigateUrl());
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Saving Content {Error}", ex.Message);
            AddModuleMessage("Error Saving Content", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHtmlTextService HtmlTextService { get; set; }
    }
}
#pragma warning restore 1591

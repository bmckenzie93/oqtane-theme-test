#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9d7a32129f10f7e4da73abf7d15ceacfe67ec6"
// <auto-generated/>
#pragma warning disable 1591
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
#line 9 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
 if (_content != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.RichTextEditor>(1);
            __builder.AddAttribute(2, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                              _content

#line default
#line hidden
            ));
            __builder.AddComponentReferenceCapture(3, (__value) => {
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                               RichTextEditorHtml = (Oqtane.Modules.Controls.RichTextEditor)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                                            SaveContent

#line default
#line hidden
            ));
            __builder.AddContent(9, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "class", "btn btn-secondary");
            __builder.AddAttribute(13, "href", 
#line 13 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                              NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\n");
#line 14 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
     if (!string.IsNullOrEmpty(_content))
    {

#line default
#line hidden
            __builder.AddMarkupContent(17, "        <br>\n        <br>\n        ");
            __builder.OpenComponent<Oqtane.Modules.Controls.AuditInfo>(18);
            __builder.AddAttribute(19, "CreatedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                               _createdby

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "CreatedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                                       _createdon

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "ModifiedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                                                                _modifiedby

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "ModifiedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
                                                                                                          _modifiedon

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\n");
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
    }

#line default
#line hidden
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/HtmlText/Edit.razor"
     
}

#line default
#line hidden
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

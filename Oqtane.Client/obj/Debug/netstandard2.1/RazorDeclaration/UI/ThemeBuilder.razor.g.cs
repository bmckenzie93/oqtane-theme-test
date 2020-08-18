#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ThemeBuilder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa5ae4663e2c7aa069077da0e77198bb99cbb1d"
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
    public partial class ThemeBuilder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ThemeBuilder.razor"
       
    [CascadingParameter] PageState PageState { get; set; }

    RenderFragment DynamicComponent { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        var interop = new Interop(JsRuntime);

        // handle page redirection
        if (!string.IsNullOrEmpty(PageState.Page.Url))
        {
            NavigationManager.NavigateTo(PageState.Page.Url);
            return;
        }

        // set page title
        if (!string.IsNullOrEmpty(PageState.Page.Title))
        {
            await interop.UpdateTitle(PageState.Page.Title);
        }
        else
        {
            await interop.UpdateTitle(PageState.Site.Name + " - " + PageState.Page.Name);
        }

        // manage stylesheets for this page 
        string batch = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        var links = new List<object>();
        foreach (Resource resource in PageState.Page.Resources.Where(item => item.ResourceType == ResourceType.Stylesheet))
        {
            links.Add(new { id = "app-stylesheet-" + batch + "-" + (links.Count + 1).ToString("00"), rel = "stylesheet", href = resource.Url, type = "text/css", integrity = resource.Integrity ?? "", crossorigin = resource.CrossOrigin ?? "", key = "" });
        }
        await interop.IncludeLinks(links.ToArray());
        await interop.RemoveElementsById("app-stylesheet", "", "app-stylesheet-" + batch + "-00");

        // add favicon
        if (PageState.Site.FaviconFileId != null)
        {
            await interop.IncludeLink("app-favicon", "shortcut icon", Utilities.ContentUrl(PageState.Alias, PageState.Site.FaviconFileId.Value), "image/x-icon", "", "", "id");
        }
        // add PWA support
        if (PageState.Site.PwaIsEnabled)
        {
            await InitializePwa(interop);
        }

        DynamicComponent = builder =>
        {
            var themeType = Type.GetType(PageState.Page.ThemeType);
            builder.OpenComponent(0, themeType);
            builder.CloseComponent();
        };
    }

    private async Task InitializePwa(Interop interop)
    {
        // dynamically create manifest.json and add to page
        string manifest = "setTimeout(() => { " +
            "var manifest = { " +
            "\"name\": \"" + PageState.Site.Name + "\", " +
            "\"short_name\": \"" + PageState.Site.Name + "\", " +
            "\"start_url\": \"/\", " +
            "\"display\": \"standalone\", " +
            "\"background_color\": \"#fff\", " +
            "\"description\": \"" + PageState.Site.Name + "\", " +
            "\"icons\": [{ " +
                "\"src\": \"" + Utilities.ContentUrl(PageState.Alias, PageState.Site.PwaAppIconFileId.Value) + "\", " +
                "\"sizes\": \"192x192\", " +
                "\"type\": \"image/png\" " +
                "}, { " +
                "\"src\": \"" + Utilities.ContentUrl(PageState.Alias, PageState.Site.PwaSplashIconFileId.Value) + "\", " +
                "\"sizes\": \"512x512\", " +
                "\"type\": \"image/png\" " +
            "}] " +
            "} " +
            "const serialized = JSON.stringify(manifest); " +
            "const blob = new Blob([serialized], {type: 'application/javascript'}); " +
            "const url = URL.createObjectURL(blob); " +
            "document.getElementById('app-manifest').setAttribute('href', url); " +
            "} " +
            ", 1000);";
        await interop.IncludeScript("app-pwa", "", "", "", manifest, "body", "id");

        // service worker must be in root of site
        string serviceworker = "if ('serviceWorker' in navigator) { " +
            "navigator.serviceWorker.register('/service-worker.js').then(function(registration) { " +
                "console.log('ServiceWorker Registration Successful'); " +
            "}).catch (function(err) { " +
                "console.log('ServiceWorker Registration Failed ', err); " +
            "}); " +
            "}";
        await interop.IncludeScript("app-serviceworker", "", "", "", serviceworker, "body", "id");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7a4496d03aa72be3532615021bdb1257fa1756"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
 if (_initialized)
{
    

#line default
#line hidden
#line 5 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
     if (!_installed)
    {

#line default
#line hidden
            __builder.AddContent(0, "        ");
            __builder.OpenComponent<Oqtane.UI.Installer>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
#line 8 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n            ");
                __Blazor.Oqtane.App.TypeInference.CreateCascadingValue_0(__builder2, 7, 8, 
#line 12 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
                                    PageState

#line default
#line hidden
                , 9, (__builder3) => {
                    __builder3.AddMarkupContent(10, "\n                ");
                    __builder3.OpenComponent<Oqtane.UI.SiteRouter>(11);
                    __builder3.AddAttribute(12, "OnStateChange", new System.Action<Oqtane.UI.PageState>(
#line 13 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
                                            ChangeState

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\n            ");
                }
                );
                __builder2.AddMarkupContent(14, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n");
#line 16 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
    }

#line default
#line hidden
#line 16 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/App.razor"
       
    private bool _initialized;
    private bool _installed;

    private PageState PageState { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        var installation = await InstallationService.IsInstalled();
        _installed = installation.Success;
        _initialized = true;
    }

    private void ChangeState(PageState pageState)
    {
        PageState = pageState;
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstallationService InstallationService { get; set; }
    }
}
namespace __Blazor.Oqtane.App
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
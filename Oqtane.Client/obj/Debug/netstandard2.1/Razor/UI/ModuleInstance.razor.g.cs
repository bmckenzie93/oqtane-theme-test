#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5644f794032697b9e9f3b09b33960a9b1a780bf8"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ModuleInstance : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Oqtane.Modules.Controls.ModuleMessage>(0);
            __builder.AddAttribute(1, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
                         _message

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Oqtane.Modules.MessageType>(
#line 3 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
                                         MessageType.Error

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __Blazor.Oqtane.UI.ModuleInstance.TypeInference.CreateCascadingValue_0(__builder, 4, 5, 
#line 4 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
                       this

#line default
#line hidden
            , 6, (__builder2) => {
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.ModuleMessage>(8);
                __builder2.AddComponentReferenceCapture(9, (__value) => {
#line 5 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
                         ModuleMessage = (Oqtane.Modules.Controls.ModuleMessage)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.AddContent(11, 
#line 6 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
     DynamicComponent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(12, "\n");
            }
            );
            __builder.AddMarkupContent(13, "\n");
#line 8 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
 if (_progressindicator)
{

#line default
#line hidden
            __builder.AddMarkupContent(14, "    <div class=\"app-progress-indicator\"></div>\n");
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 13 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/ModuleInstance.razor"
       
    private string _message;
    private bool _progressindicator = false;

    [CascadingParameter]
    protected PageState PageState { get; set; }

    [CascadingParameter]
    private Module ModuleState { get; set; }

    private ModuleMessage ModuleMessage { get; set; }

    private RenderFragment DynamicComponent { get; set; }

    protected override void OnParametersSet()
    {
        DynamicComponent = builder =>
        {
            string typename = ModuleState.ModuleType;
            // check for core module actions component
            if (Constants.DefaultModuleActions.Contains(PageState.Action))
            {
                typename = Constants.DefaultModuleActionsTemplate.Replace(Constants.ActionToken, PageState.Action);
            }

            Type moduleType = null;
            if (typename != null)
            {
                moduleType = Type.GetType(typename);

                if (moduleType != null)
                {
                    builder.OpenComponent(0, moduleType);
                    builder.CloseComponent();
                }
                else
                {
                    // module does not exist with typename specified
                    _message = "Module Does Not Have A Component Named " + Utilities.GetTypeNameLastSegment(typename, 0) + ".razor";
                }
            }
            else
            {
                _message = "Something is wrong with moduletype";
            }

        };
    }

    public void AddModuleMessage(string message, MessageType type)
    {
        _progressindicator = false;
        StateHasChanged();
        ModuleMessage.SetModuleMessage(message, type);
    }

    public void ShowProgressIndicator()
    {
        _progressindicator = true;
        StateHasChanged();
    }

    public void HideProgressIndicator()
    {
        _progressindicator = false;
        StateHasChanged();
    }

#line default
#line hidden
    }
}
namespace __Blazor.Oqtane.UI.ModuleInstance
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

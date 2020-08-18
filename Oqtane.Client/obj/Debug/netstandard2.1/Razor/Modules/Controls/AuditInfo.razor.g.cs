#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/AuditInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829c7376ae0bf21172a5aeb8e2106988e1312b24"
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
    public partial class AuditInfo : ModuleControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/AuditInfo.razor"
 if (_text != string.Empty)
{
    

#line default
#line hidden
            __builder.AddContent(0, 
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/AuditInfo.razor"
      (MarkupString)_text

#line default
#line hidden
            );
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/AuditInfo.razor"
                          
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 9 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/AuditInfo.razor"
       

    private string _text = string.Empty;

    [Parameter]
    public string CreatedBy { get; set; }

    [Parameter]
    public DateTime CreatedOn { get; set; }

    [Parameter]
    public string ModifiedBy { get; set; }

    [Parameter]
    public DateTime ModifiedOn { get; set; }

    [Parameter]
    public string DeletedBy { get; set; }

    [Parameter]
    public DateTime? DeletedOn { get; set; }

    [Parameter]
    public bool IsDeleted { get; set; }

    [Parameter]
    public string Style { get; set; }

    protected override void OnParametersSet()
    {
        _text = string.Empty;
        if (!String.IsNullOrEmpty(CreatedBy) || CreatedOn != null)
        {
            _text += "<p style=\"" + Style + "\">Created ";

            if (!String.IsNullOrEmpty(CreatedBy))
            {
                _text += " by <b>" + CreatedBy + "</b>";
            }

            if (CreatedOn != null)
            {
                _text += " on <b>" + CreatedOn.ToString("MMM dd yyyy HH:mm:ss") + "</b>";
            }

            _text += "</p>";
        }

        if (!String.IsNullOrEmpty(ModifiedBy) || ModifiedOn != null)
        {
            _text += "<p style=\"" + Style + "\">Last modified ";

            if (!String.IsNullOrEmpty(ModifiedBy))
            {
                _text += " by <b>" + ModifiedBy + "</b>";
            }

            if (ModifiedOn != null)
            {
                _text += " on <b>" + ModifiedOn.ToString("MMM dd yyyy HH:mm:ss") + "</b>";
            }

            _text += "</p>";
        }

        if (!String.IsNullOrEmpty(DeletedBy) || DeletedOn.HasValue)
        {
            _text += "<p style=\"" + Style + "\">Deleted ";

            if (!String.IsNullOrEmpty(DeletedBy))
            {
                _text += " by <b>" + DeletedBy + "</b>";
            }

            if (DeletedOn != null)
            {
                _text += " on <b>" + DeletedOn.Value.ToString("MMM dd yyyy HH:mm:ss") + "</b>";
            }

            _text += "</p>";
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
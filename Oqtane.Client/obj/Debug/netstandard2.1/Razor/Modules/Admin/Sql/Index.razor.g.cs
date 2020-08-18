#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796b956919f615b9e01a5ba519dc446241d024e7"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Sql
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
    public partial class Index : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 7 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
 if (_tenants == null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\n");
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-borderless");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenElement(8, "td");
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(10);
            __builder.AddAttribute(11, "For", "tenant");
            __builder.AddAttribute(12, "HelpText", "Select the tenant for the SQL server");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(14, "Tenant: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "id", "teneant");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                                                 _tenantid

#line default
#line hidden
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _tenantid = __value, _tenantid));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "-1");
            __builder.AddContent(27, "<Select Tenant>");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#line 21 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                     foreach (Tenant tenant in _tenants)
                    {

#line default
#line hidden
            __builder.AddContent(29, "                        ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", 
#line 23 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                        tenant.TenantId

#line default
#line hidden
            );
            __builder.AddContent(32, 
#line 23 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                                          tenant.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#line 24 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                    }

#line default
#line hidden
            __builder.AddContent(34, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(42);
            __builder.AddAttribute(43, "For", "sqlQeury");
            __builder.AddAttribute(44, "HelpText", "Enter the query for the SQL server");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "SQL Query: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "textarea");
            __builder.AddAttribute(52, "id", "sqlQeury");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "rows", "5");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 33 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                                                     _sql

#line default
#line hidden
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _sql = __value, _sql));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n    ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "btn btn-success");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 37 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                                            Execute

#line default
#line hidden
            ));
            __builder.AddContent(65, "Execute");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    <br><br>\n");
#line 39 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
     if (!string.IsNullOrEmpty(_results))
    {
        

#line default
#line hidden
            __builder.AddContent(67, 
#line 41 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
          (MarkupString)_results

#line default
#line hidden
            );
#line 41 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
                                 
    }

#line default
#line hidden
#line 42 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 45 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sql/Index.razor"
       
    private List<Tenant> _tenants;
    private string _tenantid = "-1";
    private string _sql = string.Empty;
    private string _results = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnInitializedAsync()
    {
        _tenants = await TenantService.GetTenantsAsync();
    }

    private async Task Execute()
    {
        if (_tenantid != "-1" && !string.IsNullOrEmpty(_sql))
        {
            var sqlquery = new SqlQuery { TenantId = int.Parse(_tenantid), Query = _sql };
            sqlquery = await SqlService.ExecuteQueryAsync(sqlquery);
            _results = DisplayResults(sqlquery.Results);
        }
        else
        {
            AddModuleMessage("You Must Select A Tenant And Provide A SQL Query", MessageType.Warning);
        }
    }

    private string DisplayResults(List<Dictionary<string, string>> results)
    {
        var table = string.Empty;
        foreach (Dictionary<string, string> item in results)
        {
            if (table == string.Empty)
            {
                table = "<div class=\"table-responsive\">";
                table += "<table class=\"table table-bordered\"><thead><tr>";
                
                foreach (KeyValuePair<string, string> kvp in item)
                {
                    table += "<th scope=\"col\">" + kvp.Key + "</th>";
                }
                
                table += "</tr></thead><tbody>";
            }
            
            table += "<tr>";
            
            foreach (KeyValuePair<string, string> kvp in item)
            {
                table += "<td>" + kvp.Value + "</td>";
            }
            
            table += "</tr>";
        }
        
        if (table != string.Empty)
        {
            table += "</tbody></table></div>";
        }
        else
        {
            table = "No Results Returned";
        }
        
        return table;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlService SqlService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
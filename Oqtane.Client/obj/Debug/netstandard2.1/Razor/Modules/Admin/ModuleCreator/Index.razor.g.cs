#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632e77f48a2170972f34ba47a892e401acf4366e"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.ModuleCreator
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
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-borderless");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "td");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(7);
            __builder.AddAttribute(8, "For", "owner");
            __builder.AddAttribute(9, "HelpText", "Enter the name of the organization who is developing this module. It should not contain spaces or punctuation.");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Owner Name: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "id", "owner");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 14 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                           _owner

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _owner = __value, _owner));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(28);
            __builder.AddAttribute(29, "For", "module");
            __builder.AddAttribute(30, "HelpText", "Enter a name for this module. It should not contain spaces or punctuation.");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Module Name: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "id", "module");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 22 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                            _module

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _module = __value, _module));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n    ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(49);
            __builder.AddAttribute(50, "For", "description");
            __builder.AddAttribute(51, "HelpText", "Enter s short description for the module");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Description: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "textarea");
            __builder.AddAttribute(59, "id", "description");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "rows", "3");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 30 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                                    _description

#line default
#line hidden
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _description = __value, _description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "\n        ");
            __builder.OpenElement(69, "td");
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(71);
            __builder.AddAttribute(72, "For", "template");
            __builder.AddAttribute(73, "HelpText", "Select a module template. Internal modules are created inside of the Oqtane solution. External modules are created outside of the Oqtane solution.");
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(75, "Template: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n        ");
            __builder.OpenElement(78, "td");
            __builder.AddMarkupContent(79, "\n            ");
            __builder.OpenElement(80, "select");
            __builder.AddAttribute(81, "id", "template");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 38 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                                  (e => TemplateChanged(e))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(84, "\n                ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "-");
            __builder.AddContent(87, "<Select Template>");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n                ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "internal");
            __builder.AddContent(91, "Internal");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\n                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "external");
            __builder.AddContent(95, "External");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n");
#line 45 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
     if (!string.IsNullOrEmpty(_location))
    {

#line default
#line hidden
            __builder.AddContent(100, "        ");
            __builder.OpenElement(101, "tr");
            __builder.AddMarkupContent(102, "\n            ");
            __builder.OpenElement(103, "td");
            __builder.AddMarkupContent(104, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(105);
            __builder.AddAttribute(106, "For", "location");
            __builder.AddAttribute(107, "HelpText", "Location where the module will be created");
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(109, "Location: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n            ");
            __builder.OpenElement(112, "td");
            __builder.AddMarkupContent(113, "\n                ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "id", "module");
            __builder.AddAttribute(116, "class", "form-control");
            __builder.AddAttribute(117, "readonly", true);
            __builder.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 52 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                                _location

#line default
#line hidden
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _location = __value, _location));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\n");
#line 55 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n\n");
            __builder.OpenElement(124, "button");
            __builder.AddAttribute(125, "type", "button");
            __builder.AddAttribute(126, "class", "btn btn-success");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
                                                        CreateModule

#line default
#line hidden
            ));
            __builder.AddContent(128, "Create Module");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 60 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/ModuleCreator/Index.razor"
       
    private string _owner = string.Empty;
    private string _module = string.Empty;
    private string _description = string.Empty;
    private string _template = "-";
    private string _location = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override void OnInitialized()
    {
        AddModuleMessage("Please Note That Once You Select The Create Module Button The Application Must Restart In Order To Complete The Process. If You Create An External Module You Will Need To Compile The Source Code In Order To Make It Functional.", MessageType.Info);
    }

    private async Task CreateModule()
    {
        try
        {
            if (!string.IsNullOrEmpty(_owner) && !string.IsNullOrEmpty(_module) && _template != "-")
            {
                var moduleDefinition = new ModuleDefinition { Owner = _owner.Replace(" ", ""), Name = _module.Replace(" ", ""), Description = _description, Template = _template };
                await ModuleDefinitionService.CreateModuleDefinitionAsync(moduleDefinition, ModuleState.ModuleId);
            }
            else
            {
                AddModuleMessage("You Must Provide An Owner, Module Name, And Template", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Creating Module");
        }
    }

    private async void TemplateChanged(ChangeEventArgs e)
    {
        try
        {
            _location = string.Empty;
            _template = (string)e.Value;
            if (_template != "-")
            {
                Dictionary<string, string> systeminfo = await SystemService.GetSystemInfoAsync();
                if (systeminfo != null)
                {
                    string[] path = systeminfo["serverpath"].Split('\\');
                    if (_template == "internal")
                    {
                        _location = string.Join("\\", path, 0, path.Length - 1) + "\\Oqtane.Client\\Modules\\" + _owner + "." + _module + "s";
                    }
                    else
                    {
                        _location = string.Join("\\", path, 0, path.Length - 2) + "\\" + _owner + "." + _module + "s";
                    }
                }
            }
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Getting System Info {Error}", ex.Message);
            AddModuleMessage("Error Getting System Info", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISystemService SystemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleService ModuleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleDefinitionService ModuleDefinitionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf3aa9c12423039c0e00424ed2fdb76a401cfff"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Sites
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
    public partial class Edit : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 9 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
 if (_initialized)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-borderless");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\n            ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(8);
            __builder.AddAttribute(9, "For", "name");
            __builder.AddAttribute(10, "HelpText", "Enter the name of the site");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Name: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "id", "name");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                              _name

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _name = __value, _name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(29);
            __builder.AddAttribute(30, "For", "tenant");
            __builder.AddAttribute(31, "HelpText", "Enter the tenant for the site");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Tenant: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "id", "tenant");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "readonly", true);
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 25 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                _tenant

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _tenant = __value, _tenant));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "tr");
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(51);
            __builder.AddAttribute(52, "For", "alias");
            __builder.AddAttribute(53, "HelpText", "Enter the alias for the server");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(55, "Aliases: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\n                ");
            __builder.OpenElement(60, "textarea");
            __builder.AddAttribute(61, "id", "alias");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "rows", "3");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 33 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                  _urls

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _urls = __value, _urls));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n        ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenElement(71, "td");
            __builder.AddMarkupContent(72, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(73);
            __builder.AddAttribute(74, "For", "defaultTheme");
            __builder.AddAttribute(75, "HelpText", "Select the default theme for the website");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(77, "Default Theme: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n            ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "\n                ");
            __builder.OpenElement(82, "select");
            __builder.AddAttribute(83, "id", "defaultTheme");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 41 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                          (e => ThemeChanged(e))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(86, "\n                    ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "value", "-");
            __builder.AddContent(89, "<Select Theme>");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n");
#line 43 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                     foreach (var theme in _themes)
                    {
                        if (theme.TypeName == _themetype)
                        {

#line default
#line hidden
            __builder.AddContent(91, "                            ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", 
#line 47 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                            theme.TypeName

#line default
#line hidden
            );
            __builder.AddAttribute(94, "selected", true);
            __builder.AddContent(95, 
#line 47 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                      theme.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n");
#line 48 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                        }
                        else
                        {

#line default
#line hidden
            __builder.AddContent(97, "                            ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", 
#line 51 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                            theme.TypeName

#line default
#line hidden
            );
            __builder.AddContent(100, 
#line 51 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                             theme.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n");
#line 52 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                        }
                    }

#line default
#line hidden
            __builder.AddContent(102, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n");
#line 57 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
         if (_layouts.Count > 0)
        {

#line default
#line hidden
            __builder.AddContent(106, "            ");
            __builder.OpenElement(107, "tr");
            __builder.AddMarkupContent(108, "\n                ");
            __builder.OpenElement(109, "td");
            __builder.AddMarkupContent(110, "\n                    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(111);
            __builder.AddAttribute(112, "For", "defaultLayout");
            __builder.AddAttribute(113, "HelpText", "Select the default layout for the site");
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(115, "Default Layout: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n                ");
            __builder.OpenElement(118, "td");
            __builder.AddMarkupContent(119, "\n                    ");
            __builder.OpenElement(120, "select");
            __builder.AddAttribute(121, "id", "defaultLayout");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 64 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                            _layouttype

#line default
#line hidden
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _layouttype = __value, _layouttype));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(125, "\n                        ");
            __builder.OpenElement(126, "option");
            __builder.AddAttribute(127, "value", "-");
            __builder.AddContent(128, "<Select Layout>");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n");
#line 66 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                         foreach (var layout in _layouts)
                        {

#line default
#line hidden
            __builder.AddContent(130, "                            ");
            __builder.OpenElement(131, "option");
            __builder.AddAttribute(132, "value", 
#line 68 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                             layout.TypeName

#line default
#line hidden
            );
            __builder.AddContent(133, 
#line 68 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                 layout.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n");
#line 69 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                        }

#line default
#line hidden
            __builder.AddContent(135, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n");
#line 73 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
        }

#line default
#line hidden
            __builder.AddContent(139, "        ");
            __builder.OpenElement(140, "tr");
            __builder.AddMarkupContent(141, "\n            ");
            __builder.OpenElement(142, "td");
            __builder.AddMarkupContent(143, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(144);
            __builder.AddAttribute(145, "For", "defaultContainer");
            __builder.AddAttribute(146, "HelpText", "Select the default container for the site");
            __builder.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(148, "Default Container: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n            ");
            __builder.OpenElement(151, "td");
            __builder.AddMarkupContent(152, "\n                ");
            __builder.OpenElement(153, "select");
            __builder.AddAttribute(154, "id", "defaultIdea");
            __builder.AddAttribute(155, "class", "form-control");
            __builder.AddAttribute(156, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 79 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                      _containertype

#line default
#line hidden
            ));
            __builder.AddAttribute(157, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _containertype = __value, _containertype));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(158, "\n                    ");
            __builder.OpenElement(159, "option");
            __builder.AddAttribute(160, "value", "-");
            __builder.AddContent(161, "<Select Container>");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n");
#line 81 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                     foreach (var container in _containers)
                    {

#line default
#line hidden
            __builder.AddContent(163, "                        ");
            __builder.OpenElement(164, "option");
            __builder.AddAttribute(165, "value", 
#line 83 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                        container.TypeName

#line default
#line hidden
            );
            __builder.AddContent(166, 
#line 83 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                             container.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\n");
#line 84 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                    }

#line default
#line hidden
            __builder.AddContent(168, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n        ");
            __builder.OpenElement(172, "tr");
            __builder.AddMarkupContent(173, "\n            ");
            __builder.OpenElement(174, "td");
            __builder.AddMarkupContent(175, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(176);
            __builder.AddAttribute(177, "For", "isDeleted");
            __builder.AddAttribute(178, "HelpText", "Has this site been deleted?");
            __builder.AddAttribute(179, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(180, "Is Deleted? ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(181, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\n            ");
            __builder.OpenElement(183, "td");
            __builder.AddMarkupContent(184, "\n                ");
            __builder.OpenElement(185, "select");
            __builder.AddAttribute(186, "id", "isDeleted");
            __builder.AddAttribute(187, "class", "form-control");
            __builder.AddAttribute(188, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 93 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                    _isdeleted

#line default
#line hidden
            ));
            __builder.AddAttribute(189, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _isdeleted = __value, _isdeleted));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(190, "\n                    ");
            __builder.OpenElement(191, "option");
            __builder.AddAttribute(192, "value", "True");
            __builder.AddContent(193, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\n                    ");
            __builder.OpenElement(195, "option");
            __builder.AddAttribute(196, "value", "False");
            __builder.AddContent(197, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\n    <br>\n    ");
            __builder.OpenElement(203, "button");
            __builder.AddAttribute(204, "type", "button");
            __builder.AddAttribute(205, "class", "btn btn-success");
            __builder.AddAttribute(206, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 101 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                            SaveSite

#line default
#line hidden
            ));
            __builder.AddContent(207, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(209);
            __builder.AddAttribute(210, "class", "btn btn-secondary");
            __builder.AddAttribute(211, "href", 
#line 102 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                              NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(212, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(213, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(214, "\n    <br>\n    <br>\n    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.AuditInfo>(215);
            __builder.AddAttribute(216, "CreatedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                           _createdby

#line default
#line hidden
            ));
            __builder.AddAttribute(217, "CreatedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                   _createdon

#line default
#line hidden
            ));
            __builder.AddAttribute(218, "ModifiedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                            _modifiedby

#line default
#line hidden
            ));
            __builder.AddAttribute(219, "ModifiedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                                                      _modifiedon

#line default
#line hidden
            ));
            __builder.AddAttribute(220, "DeletedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                                                                               _deletedby

#line default
#line hidden
            ));
            __builder.AddAttribute(221, "DeletedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#line 105 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
                                                                                                                                                       _deletedon

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(222, "\n");
#line 106 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 108 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
       
    private bool _initialized = false;
    private List<Theme> _themeList;
    private List<ThemeControl> _themes = new List<ThemeControl>();
    private List<ThemeControl> _layouts = new List<ThemeControl>();
    private List<ThemeControl> _containers = new List<ThemeControl>();
    private Alias _alias;
    private string _name = string.Empty;
    private List<Tenant> _tenantList;
    private string _tenant = string.Empty;
    private List<Alias> _aliasList;
    private string _urls = string.Empty;
    private string _themetype;
    private string _layouttype;
    private string _containertype;
    private string _createdby;
    private DateTime _createdon;
    private string _modifiedby;
    private DateTime _modifiedon;
    private string _deletedby;
    private DateTime? _deletedon;
    private string _isdeleted;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _themeList = await ThemeService.GetThemesAsync();
            _aliasList = await AliasService.GetAliasesAsync();

            _alias = _aliasList.Find(item => item.AliasId == Int32.Parse(PageState.QueryString["id"]));
            SiteService.SetAlias(_alias);
            var site = await SiteService.GetSiteAsync(_alias.SiteId);
            if (site != null)
            {
                _name = site.Name;
                _tenantList = await TenantService.GetTenantsAsync();
                _tenant = _tenantList.Find(item => item.TenantId == site.TenantId).Name;

                foreach (Alias alias in _aliasList.Where(item => item.SiteId == site.SiteId && item.TenantId == site.TenantId).ToList())
                {
                    _urls += alias.Name + "\n";
                }

                _themes = ThemeService.GetThemeControls(_themeList);
                _themetype = site.DefaultThemeType;
                _layouts = ThemeService.GetLayoutControls(_themeList, _themetype);
                _layouttype = site.DefaultLayoutType;
                _containers = ThemeService.GetContainerControls(_themeList, _themetype);
                _containertype = site.DefaultContainerType;
                _createdby = site.CreatedBy;
                _createdon = site.CreatedOn;
                _modifiedby = site.ModifiedBy;
                _modifiedon = site.ModifiedOn;
                _deletedby = site.DeletedBy;
                _deletedon = site.DeletedOn;
                _isdeleted = site.IsDeleted.ToString();

                _initialized = true;
            }
        }
        catch (Exception ex)
        {
            await Log(_alias, LogLevel.Error, string.Empty, ex, "Error Loading Site {SiteId} {Error}", _alias.SiteId, ex.Message);
            AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

    private async void ThemeChanged(ChangeEventArgs e)
    {
        try
        {
            _themetype = (string)e.Value;
            if (_themetype != "-")
            {
                _layouts = ThemeService.GetLayoutControls(_themeList, _themetype);
                _containers = ThemeService.GetContainerControls(_themeList, _themetype);
            }
            else
            {
                _layouts = new List<ThemeControl>();
                _containers = new List<ThemeControl>();
            }
            _layouttype = "-";
            _containertype = "-";
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Pane Layouts For Theme {ThemeType} {Error}", _themetype, ex.Message);
            AddModuleMessage("Error Loading Pane Layouts For Theme", MessageType.Error);
        }
    }

    private async Task SaveSite()
    {
        try
        {
            if (_name != string.Empty && _urls != string.Empty && _themetype != "-" && (_layouts.Count == 0 || _layouttype != "-") && _containertype != "-")
            {
                var unique = true;
                foreach (string name in _urls.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (_aliasList.Exists(item => item.Name == name && item.SiteId != _alias.SiteId && item.TenantId != _alias.TenantId))
                    {
                        unique = false;
                    }
                }

                if (unique)
                {
                    SiteService.SetAlias(_alias);
                    var site = await SiteService.GetSiteAsync(_alias.SiteId);
                    if (site != null)
                    {
                        site.Name = _name;
                        site.LogoFileId = null;
                        site.DefaultThemeType = _themetype;
                        site.DefaultLayoutType = _layouttype ?? string.Empty;
                        site.DefaultContainerType = _containertype;
                        site.IsDeleted = (_isdeleted == null || Boolean.Parse(_isdeleted));

                        site = await SiteService.UpdateSiteAsync(site);

                        _urls = _urls.Replace("\n", ",");
                        var names = _urls.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (Alias alias in _aliasList.Where(item => item.SiteId == site.SiteId && item.TenantId == site.TenantId).ToList())
                        {
                            if (!names.Contains(alias.Name))
                            {
                                await AliasService.DeleteAliasAsync(alias.AliasId);
                            }
                        }

                        foreach (string name in names)
                        {
                            if (!_aliasList.Exists(item => item.Name == name))
                            {
                                Alias alias = new Alias
                                {
                                    Name = name,
                                    TenantId = site.TenantId,
                                    SiteId = site.SiteId
                                };
                                await AliasService.AddAliasAsync(alias);
                            }
                        }

                        await Log(_alias, LogLevel.Information,PermissionNames.Edit, null, "Site Saved {Site}", site);

                        NavigationManager.NavigateTo(NavigateUrl());
                    }
                }
                else
                {
                    AddModuleMessage("An Alias Specified Has Already Been Used For Another Site", MessageType.Warning);
                }
            }
            else
            {
                AddModuleMessage("You Must Provide A Site Name, Alias, And Default Theme/Container", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await Log(_alias, LogLevel.Error, string.Empty, ex, "Error Saving Site {SiteId} {Error}", _alias.SiteId, ex.Message);
            AddModuleMessage("Error Saving Site", MessageType.Error);
        }
    }
 

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IThemeService ThemeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAliasService AliasService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISiteService SiteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

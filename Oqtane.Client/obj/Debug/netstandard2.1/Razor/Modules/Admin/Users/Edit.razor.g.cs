#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf936217b1c0072e77a0164ec0c7708ff20cf038"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Users
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
#line 8 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
 if (PageState.User != null && photofileid != -1)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#line 10 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                ContentUrl(photofileid)

#line default
#line hidden
            );
            __builder.AddAttribute(3, "alt", 
#line 10 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                displayname

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", "max-width: 400px");
            __builder.AddAttribute(5, "class", "rounded-circle mx-auto d-block");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n");
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
}
else
{

#line default
#line hidden
            __builder.AddMarkupContent(7, "    <br>\n");
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
}

#line default
#line hidden
            __builder.OpenComponent<Oqtane.Modules.Controls.TabStrip>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(11);
                __builder2.AddAttribute(12, "Name", "Identity");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\n");
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
         if (profiles != null)
        {

#line default
#line hidden
                    __builder3.AddContent(15, "            ");
                    __builder3.OpenElement(16, "table");
                    __builder3.AddAttribute(17, "class", "table table-borderless");
                    __builder3.AddMarkupContent(18, "\n                ");
                    __builder3.OpenElement(19, "tr");
                    __builder3.AddMarkupContent(20, "\n                    ");
                    __builder3.AddMarkupContent(21, "<td>\n                        <label class=\"control-label\">Username: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(22, "td");
                    __builder3.AddMarkupContent(23, "\n                        ");
                    __builder3.OpenElement(24, "input");
                    __builder3.AddAttribute(25, "class", "form-control");
                    __builder3.AddAttribute(26, "readonly", true);
                    __builder3.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 26 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                            username

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenElement(32, "tr");
                    __builder3.AddMarkupContent(33, "\n                    ");
                    __builder3.AddMarkupContent(34, "<td>\n                        <label class=\"control-label\">Password: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(35, "td");
                    __builder3.AddMarkupContent(36, "\n                        ");
                    __builder3.OpenElement(37, "input");
                    __builder3.AddAttribute(38, "type", "password");
                    __builder3.AddAttribute(39, "class", "form-control");
                    __builder3.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 34 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                            password

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n                ");
                    __builder3.OpenElement(45, "tr");
                    __builder3.AddMarkupContent(46, "\n                    ");
                    __builder3.AddMarkupContent(47, "<td>\n                        <label class=\"control-label\">Confirm Password: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(48, "td");
                    __builder3.AddMarkupContent(49, "\n                        ");
                    __builder3.OpenElement(50, "input");
                    __builder3.AddAttribute(51, "type", "password");
                    __builder3.AddAttribute(52, "class", "form-control");
                    __builder3.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 42 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                            confirm

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirm = __value, confirm));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenElement(58, "tr");
                    __builder3.AddMarkupContent(59, "\n                    ");
                    __builder3.AddMarkupContent(60, "<td>\n                        <label class=\"control-label\">Email: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(61, "td");
                    __builder3.AddMarkupContent(62, "\n                        ");
                    __builder3.OpenElement(63, "input");
                    __builder3.AddAttribute(64, "class", "form-control");
                    __builder3.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 50 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                            email

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenElement(70, "tr");
                    __builder3.AddMarkupContent(71, "\n                    ");
                    __builder3.AddMarkupContent(72, "<td>\n                        <label class=\"control-label\">Full Name: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(73, "td");
                    __builder3.AddMarkupContent(74, "\n                        ");
                    __builder3.OpenElement(75, "input");
                    __builder3.AddAttribute(76, "class", "form-control");
                    __builder3.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 58 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                            displayname

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayname = __value, displayname));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenElement(82, "tr");
                    __builder3.AddMarkupContent(83, "\n                    ");
                    __builder3.AddMarkupContent(84, "<td>\n                        <label class=\"control-label\">Photo: </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(85, "td");
                    __builder3.AddMarkupContent(86, "\n                        ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.FileManager>(87);
                    __builder3.AddAttribute(88, "FileId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 66 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                              photofileid

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(89, (__value) => {
#line 66 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                 filemanager = (Oqtane.Modules.Controls.FileManager)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n                ");
                    __builder3.OpenElement(93, "tr");
                    __builder3.AddMarkupContent(94, "\n                    ");
                    __builder3.AddMarkupContent(95, "<td>\n                        <label class=\"control-label\">Is Deleted? </label>\n                    </td>\n                    ");
                    __builder3.OpenElement(96, "td");
                    __builder3.AddMarkupContent(97, "\n                        ");
                    __builder3.OpenElement(98, "select");
                    __builder3.AddAttribute(99, "class", "form-control");
                    __builder3.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 74 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                             isdeleted

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => isdeleted = __value, isdeleted));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.AddMarkupContent(102, "\n                            ");
                    __builder3.OpenElement(103, "option");
                    __builder3.AddAttribute(104, "value", "True");
                    __builder3.AddContent(105, "Yes");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n                            ");
                    __builder3.OpenElement(107, "option");
                    __builder3.AddAttribute(108, "value", "False");
                    __builder3.AddContent(109, "No");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\n");
#line 81 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(115, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(117);
                __builder2.AddAttribute(118, "Name", "Profile");
                __builder2.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(120, "\n");
#line 84 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
         if (profiles != null)
        {

#line default
#line hidden
                    __builder3.AddContent(121, "        ");
                    __builder3.OpenElement(122, "table");
                    __builder3.AddAttribute(123, "class", "table table-borderless");
                    __builder3.AddMarkupContent(124, "\n");
#line 87 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
             foreach (Profile profile in profiles)
            {
                var p = profile;
                if (p.Category != category)
                {

#line default
#line hidden
                    __builder3.AddContent(125, "                    ");
                    __builder3.OpenElement(126, "tr");
                    __builder3.AddMarkupContent(127, "\n                        ");
                    __builder3.OpenElement(128, "th");
                    __builder3.AddAttribute(129, "colspan", "2");
                    __builder3.AddAttribute(130, "style", "text-align: center;");
                    __builder3.AddMarkupContent(131, "\n                            ");
                    __builder3.AddContent(132, 
#line 94 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                             p.Category

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(133, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\n");
#line 97 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                    category = p.Category;
                }

#line default
#line hidden
                    __builder3.AddContent(136, "                ");
                    __builder3.OpenElement(137, "tr");
                    __builder3.AddMarkupContent(138, "\n                    ");
                    __builder3.OpenElement(139, "td");
                    __builder3.AddMarkupContent(140, "\n                        ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.Label>(141);
                    __builder3.AddAttribute(142, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 101 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                     p.Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(143, "HelpText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 101 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                        p.Description

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(145, 
#line 101 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                        p.Title

#line default
#line hidden
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n                    ");
                    __builder3.OpenElement(148, "td");
                    __builder3.AddMarkupContent(149, "\n");
#line 104 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                         if (p.IsRequired)
                        {

#line default
#line hidden
                    __builder3.AddContent(150, "                            ");
                    __builder3.OpenElement(151, "input");
                    __builder3.AddAttribute(152, "id", 
#line 106 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                        p.Name

#line default
#line hidden
                    );
                    __builder3.AddAttribute(153, "class", "form-control");
                    __builder3.AddAttribute(154, "maxlength", 
#line 106 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                 p.MaxLength

#line default
#line hidden
                    );
                    __builder3.AddAttribute(155, "value", 
#line 106 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                      GetProfileValue(p.Name, p.DefaultValue)

#line default
#line hidden
                    );
                    __builder3.AddAttribute(156, "required", true);
                    __builder3.AddAttribute(157, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 106 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                                                                                     e => ProfileChanged(e, p.Name)

#line default
#line hidden
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\n");
#line 107 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                        }
                        else
                        {

#line default
#line hidden
                    __builder3.AddContent(159, "                            ");
                    __builder3.OpenElement(160, "input");
                    __builder3.AddAttribute(161, "id", 
#line 110 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                        p.Name

#line default
#line hidden
                    );
                    __builder3.AddAttribute(162, "class", "form-control");
                    __builder3.AddAttribute(163, "maxlength", 
#line 110 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                 p.MaxLength

#line default
#line hidden
                    );
                    __builder3.AddAttribute(164, "value", 
#line 110 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                      GetProfileValue(p.Name, p.DefaultValue)

#line default
#line hidden
                    );
                    __builder3.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 110 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                                                                            e => ProfileChanged(e, p.Name)

#line default
#line hidden
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\n");
#line 111 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                        }

#line default
#line hidden
                    __builder3.AddContent(167, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(168, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(169, "\n");
#line 114 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
            }

#line default
#line hidden
                    __builder3.AddContent(170, "        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\n");
#line 116 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(172, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(173, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(174, "\n\n");
            __builder.OpenElement(175, "button");
            __builder.AddAttribute(176, "type", "button");
            __builder.AddAttribute(177, "class", "btn btn-primary");
            __builder.AddAttribute(178, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 120 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                        SaveUser

#line default
#line hidden
            ));
            __builder.AddContent(179, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(181);
            __builder.AddAttribute(182, "class", "btn btn-secondary");
            __builder.AddAttribute(183, "href", 
#line 121 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                          NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(184, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(185, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(186, "\n<br><br>\n");
            __builder.OpenComponent<Oqtane.Modules.Controls.AuditInfo>(187);
            __builder.AddAttribute(188, "CreatedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                       createdby

#line default
#line hidden
            ));
            __builder.AddAttribute(189, "CreatedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                              createdon

#line default
#line hidden
            ));
            __builder.AddAttribute(190, "ModifiedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                      modifiedby

#line default
#line hidden
            ));
            __builder.AddAttribute(191, "ModifiedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                               modifiedon

#line default
#line hidden
            ));
            __builder.AddAttribute(192, "DeletedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                                       deletedby

#line default
#line hidden
            ));
            __builder.AddAttribute(193, "DeletedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#line 123 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
                                                                                                                                              deletedon

#line default
#line hidden
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 125 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Users/Edit.razor"
       
    private int userid;
    private string username = string.Empty;
    private string password = string.Empty;
    private string confirm = string.Empty;
    private string email = string.Empty;
    private string displayname = string.Empty;
    private FileManager filemanager;
    private int photofileid = -1;
    private List<Profile> profiles;
    private Dictionary<string, string> settings;
    private string category = string.Empty;
    private string createdby;
    private DateTime createdon;
    private string modifiedby;
    private DateTime modifiedon;
    private string deletedby;
    private DateTime? deletedon;
    private string isdeleted;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            profiles = await ProfileService.GetProfilesAsync(PageState.Site.SiteId);

            userid = Int32.Parse(PageState.QueryString["id"]);
            var user = await UserService.GetUserAsync(userid, PageState.Site.SiteId);
            if (user != null)
            {
                username = user.Username;
                email = user.Email;
                displayname = user.DisplayName;

                if (user.PhotoFileId != null)
                {
                    photofileid = user.PhotoFileId.Value;
                }

                settings = await SettingService.GetUserSettingsAsync(user.UserId);
                createdby = user.CreatedBy;
                createdon = user.CreatedOn;
                modifiedby = user.ModifiedBy;
                modifiedon = user.ModifiedOn;
                deletedby = user.DeletedBy;
                deletedon = user.DeletedOn;
                isdeleted = user.IsDeleted.ToString();
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading User {UserId} {Error}", userid, ex.Message);
            AddModuleMessage("Error Loading User", MessageType.Error);
        }
    }

    private string GetProfileValue(string SettingName, string DefaultValue)
        => SettingService.GetSetting(settings, SettingName, DefaultValue);

    private async Task SaveUser()
    {
        try
        {
            if (username != string.Empty && email != string.Empty && ValidateProfiles())
            {
                if (password == confirm)
                {
                    var user = await UserService.GetUserAsync(userid, PageState.Site.SiteId);
                    user.SiteId = PageState.Site.SiteId;
                    user.Username = username;
                    user.Password = password;
                    user.Email = email;
                    user.DisplayName = string.IsNullOrWhiteSpace(displayname) ? username : displayname;
                    user.PhotoFileId = null;
                    photofileid = filemanager.GetFileId();

                    if (photofileid != -1)
                    {
                        user.PhotoFileId = photofileid;
                    }

                    user.IsDeleted = (isdeleted == null ? true : Boolean.Parse(isdeleted));

                    user = await UserService.UpdateUserAsync(user);
                    await SettingService.UpdateUserSettingsAsync(settings, user.UserId);
                    await logger.LogInformation("User Saved {User}", user);

                    NavigationManager.NavigateTo(NavigateUrl());
                }
                else
                {
                    AddModuleMessage("Passwords Entered Do Not Match", MessageType.Warning);
                }
            }
            else
            {
                AddModuleMessage("You Must Provide A Username, Password, Email Address, And All Required Profile Information", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Saving User {Username} {Email} {Error}", username, email, ex.Message);
            AddModuleMessage("Error Saving User", MessageType.Error);
        }
    }

    private bool ValidateProfiles()
    {
        bool valid = true;
        foreach (Profile profile in profiles)
        {
            if (string.IsNullOrEmpty(SettingService.GetSetting(settings, profile.Name, string.Empty)) && !string.IsNullOrEmpty(profile.DefaultValue))
            {
                settings = SettingService.SetSetting(settings, profile.Name, profile.DefaultValue);
            }
            if (profile.IsRequired && string.IsNullOrEmpty(SettingService.GetSetting(settings, profile.Name, string.Empty)))
            {
                valid = false;
            }
        }
        return valid;
    }
    
    private void ProfileChanged(ChangeEventArgs e, string SettingName)
    {
        var value = (string)e.Value;
        settings = SettingService.SetSetting(settings, SettingName, value);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISettingService SettingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProfileService ProfileService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

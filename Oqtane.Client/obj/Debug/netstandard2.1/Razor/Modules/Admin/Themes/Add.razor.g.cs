#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "418f517dfb4c407112c1f04fde46512735d1ff4e"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.Themes
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
    public partial class Add : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 8 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
 if (_packages != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Oqtane.Modules.Controls.TabStrip>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n");
#line 11 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
         if (_packages.Count > 0)
        {

#line default
#line hidden
                __builder2.AddContent(4, "            ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(5);
                __builder2.AddAttribute(6, "Name", "Download");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\n                ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.ModuleMessage>(9);
                    __builder3.AddAttribute(10, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Oqtane.Modules.MessageType>(
#line 14 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                     MessageType.Info

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(11, "Message", "Download one or more themes from the list below. Once you are ready click Install to complete the installation.");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\n                ");
                    __Blazor.Oqtane.Modules.Admin.Themes.Add.TypeInference.CreatePager_0(__builder3, 13, 14, 
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                               _packages

#line default
#line hidden
                    , 15, (__builder4) => {
                        __builder4.AddMarkupContent(16, "\n                        ");
                        __builder4.AddMarkupContent(17, "<th>Name</th>\n                        ");
                        __builder4.AddMarkupContent(18, "<th>Version</th>\n                        <th style=\"width: 1px;\"></th>\n                    ");
                    }
                    , 19, (context) => (__builder4) => {
                        __builder4.AddMarkupContent(20, "\n                        ");
                        __builder4.OpenElement(21, "td");
                        __builder4.AddContent(22, 
#line 22 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                             context.Name

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(23, "\n                        ");
                        __builder4.OpenElement(24, "td");
                        __builder4.AddContent(25, 
#line 23 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                             context.Version

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(26, "\n                        ");
                        __builder4.OpenElement(27, "td");
                        __builder4.AddMarkupContent(28, "\n                            ");
                        __builder4.OpenElement(29, "button");
                        __builder4.AddAttribute(30, "type", "button");
                        __builder4.AddAttribute(31, "class", "btn btn-primary");
                        __builder4.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                                                                     async () => await DownloadTheme(context.PackageId, context.Version)

#line default
#line hidden
                        ));
                        __builder4.AddContent(33, "Download");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(34, "\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(35, "\n                    ");
                    }
                    );
                    __builder3.AddMarkupContent(36, "\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n");
#line 30 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
        }

#line default
#line hidden
                __builder2.AddContent(38, "        ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(39);
                __builder2.AddAttribute(40, "Name", "Upload");
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenElement(43, "table");
                    __builder3.AddAttribute(44, "class", "table table-borderless");
                    __builder3.AddMarkupContent(45, "\n                ");
                    __builder3.OpenElement(46, "tr");
                    __builder3.AddMarkupContent(47, "\n                    ");
                    __builder3.OpenElement(48, "td");
                    __builder3.AddMarkupContent(49, "\n                        ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.Label>(50);
                    __builder3.AddAttribute(51, "HelpText", "Upload one or more theme packages. Once they are uploaded click Install to complete the installation.");
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(53, "Theme: ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n                    ");
                    __builder3.OpenElement(56, "td");
                    __builder3.AddMarkupContent(57, "\n                        ");
                    __builder3.OpenComponent<Oqtane.Modules.Controls.FileManager>(58);
                    __builder3.AddAttribute(59, "Filter", "nupkg");
                    __builder3.AddAttribute(60, "ShowFiles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 38 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                                               false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(61, "Folder", "Themes");
                    __builder3.AddAttribute(62, "UploadMultiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 38 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                                                                                       true

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\n");
            __builder.AddContent(69, "    ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "class", "btn btn-success");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                                            InstallThemes

#line default
#line hidden
            ));
            __builder.AddContent(74, "Install");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
            __builder.AddAttribute(77, "class", "btn btn-secondary");
            __builder.AddAttribute(78, "href", 
#line 46 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
                                              NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(80, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\n");
#line 47 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 49 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Themes/Add.razor"
       
    private List<Package> _packages;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Host;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var themes = await ThemeService.GetThemesAsync();
            _packages = await PackageService.GetPackagesAsync("theme");

            foreach (Package package in _packages.ToArray())
            {
                if (themes.Exists(item => Utilities.GetTypeName(item.ThemeName) == package.PackageId))
                {
                    _packages.Remove(package);
                }
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Packages {Error}", ex.Message);
            AddModuleMessage("Error Loading Packages", MessageType.Error);
        }
    }

    private async Task InstallThemes()
    {
        try
        {
            ShowProgressIndicator();
            var interop = new Interop(JSRuntime);
            await interop.RedirectBrowser(NavigateUrl(), 10);
            await ThemeService.InstallThemesAsync();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Installating Theme");
        }
    }

    private async Task DownloadTheme(string packageid, string version)
    {
        try
        {
            await PackageService.DownloadPackageAsync(packageid, version, "Themes");
            await logger.LogInformation("Theme {ThemeName} {Version} Downloaded Successfully", packageid, version);
            AddModuleMessage("Themes Downloaded Successfully. Click Install To Complete Installation.", MessageType.Success);
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Downloading Module {ThemeName} {Version}", packageid, version);
            AddModuleMessage("Error Downloading Theme", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPackageService PackageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IThemeService ThemeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileService FileService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Oqtane.Modules.Admin.Themes.Add
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreatePager_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
        {
        __builder.OpenComponent<global::Oqtane.Modules.Controls.Pager<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Header", __arg1);
        __builder.AddAttribute(__seq2, "Row", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

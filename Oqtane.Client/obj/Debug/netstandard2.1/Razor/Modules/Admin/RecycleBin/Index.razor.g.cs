#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54252f05112a761ce9f87a5c3b884ca653305701"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.RecycleBin
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
            __builder.OpenComponent<Oqtane.Modules.Controls.TabStrip>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(3);
                __builder2.AddAttribute(4, "Name", "Pages");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\n");
#line 10 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
         if (_pages == null)
        {

#line default
#line hidden
                    __builder3.AddMarkupContent(7, "            <br>\n            ");
                    __builder3.AddMarkupContent(8, "<p>No Deleted Pages</p>\n");
#line 14 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
        }
        else
        {

#line default
#line hidden
                    __builder3.AddContent(9, "            ");
                    __Blazor.Oqtane.Modules.Admin.RecycleBin.Index.TypeInference.CreatePager_0(__builder3, 10, 11, 
#line 17 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                           _pages

#line default
#line hidden
                    , 12, (__builder4) => {
                        __builder4.AddMarkupContent(13, "\n                    ");
                        __builder4.AddMarkupContent(14, "<th style=\"width: 1px;\">&nbsp;</th>\n                    ");
                        __builder4.AddMarkupContent(15, "<th style=\"width: 1px;\">&nbsp;</th>\n                    ");
                        __builder4.AddMarkupContent(16, "<th>Name</th>\n                    ");
                        __builder4.AddMarkupContent(17, "<th>Deleted By</th>\n                    ");
                        __builder4.AddMarkupContent(18, "<th>Deleted On</th>\n                ");
                    }
                    , 19, (context) => (__builder4) => {
                        __builder4.AddMarkupContent(20, "\n                    ");
                        __builder4.OpenElement(21, "td");
                        __builder4.OpenElement(22, "button");
                        __builder4.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                            () => RestorePage(context)

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(24, "class", "btn btn-info");
                        __builder4.AddAttribute(25, "title", "Restore");
                        __builder4.AddContent(26, "Restore");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(27, "\n                    ");
                        __builder4.OpenElement(28, "td");
                        __builder4.OpenComponent<Oqtane.Modules.Controls.ActionDialog>(29);
                        __builder4.AddAttribute(30, "Header", "Delete Page");
                        __builder4.AddAttribute(31, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 27 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                      "Are You Sure You Wish To Permanently Delete The " + context.Name + " Page?"

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(32, "Action", "Delete");
                        __builder4.AddAttribute(33, "Security", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Oqtane.Shared.SecurityAccessLevel?>(
#line 27 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                                                                                                                               SecurityAccessLevel.Admin

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(34, "Class", "btn btn-danger");
                        __builder4.AddAttribute(35, "OnClick", new System.Action(
#line 27 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                                                                                                                                                                                            async () => await DeletePage(context)

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(36, "\n                    ");
                        __builder4.OpenElement(37, "td");
                        __builder4.AddContent(38, 
#line 28 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.Name

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\n                    ");
                        __builder4.OpenElement(40, "td");
                        __builder4.AddContent(41, 
#line 29 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.DeletedBy

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(42, "\n                    ");
                        __builder4.OpenElement(43, "td");
                        __builder4.AddContent(44, 
#line 30 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.DeletedOn

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(45, "\n                ");
                    }
                    );
                    __builder3.AddMarkupContent(46, "\n");
#line 33 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(47, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n    ");
                __builder2.OpenComponent<Oqtane.Modules.Controls.TabPanel>(49);
                __builder2.AddAttribute(50, "Name", "Modules");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\n");
#line 36 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
         if (_modules == null)
        {

#line default
#line hidden
                    __builder3.AddMarkupContent(53, "            <br>\n            ");
                    __builder3.AddMarkupContent(54, "<p>No Deleted Modules</p>\n");
#line 40 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
        }
        else
        {

#line default
#line hidden
                    __builder3.AddContent(55, "            ");
                    __Blazor.Oqtane.Modules.Admin.RecycleBin.Index.TypeInference.CreatePager_1(__builder3, 56, 57, 
#line 43 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                           _modules

#line default
#line hidden
                    , 58, (__builder4) => {
                        __builder4.AddMarkupContent(59, "\n                    ");
                        __builder4.AddMarkupContent(60, "<th style=\"width: 1px;\">&nbsp;</th>\n                    ");
                        __builder4.AddMarkupContent(61, "<th style=\"width: 1px;\">&nbsp;</th>\n                    ");
                        __builder4.AddMarkupContent(62, "<th>Page</th>\n                    ");
                        __builder4.AddMarkupContent(63, "<th>Module</th>\n                    ");
                        __builder4.AddMarkupContent(64, "<th>Deleted By</th>\n                    ");
                        __builder4.AddMarkupContent(65, "<th>Deleted On</th>\n                ");
                    }
                    , 66, (context) => (__builder4) => {
                        __builder4.AddMarkupContent(67, "\n                    ");
                        __builder4.OpenElement(68, "td");
                        __builder4.OpenElement(69, "button");
                        __builder4.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 53 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                            () => RestoreModule(context)

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(71, "class", "btn btn-info");
                        __builder4.AddAttribute(72, "title", "Restore");
                        __builder4.AddContent(73, "Restore");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(74, "\n                    ");
                        __builder4.OpenElement(75, "td");
                        __builder4.OpenComponent<Oqtane.Modules.Controls.ActionDialog>(76);
                        __builder4.AddAttribute(77, "Header", "Delete Module");
                        __builder4.AddAttribute(78, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                        "Are You Sure You Wish To Permanently Delete The " + context.Title + " Module?"

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(79, "Action", "Delete");
                        __builder4.AddAttribute(80, "Security", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Oqtane.Shared.SecurityAccessLevel?>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                                                                                                                                    SecurityAccessLevel.Admin

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(81, "Class", "btn btn-danger");
                        __builder4.AddAttribute(82, "OnClick", new System.Action(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                                                                                                                                                                                                                                                 async () => await DeleteModule(context)

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(83, "\n                    ");
                        __builder4.OpenElement(84, "td");
                        __builder4.AddContent(85, 
#line 55 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         PageState.Pages.Find(item => item.PageId == context.PageId).Name

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(86, "\n                    ");
                        __builder4.OpenElement(87, "td");
                        __builder4.AddContent(88, 
#line 56 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.Title

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(89, "\n                    ");
                        __builder4.OpenElement(90, "td");
                        __builder4.AddContent(91, 
#line 57 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.DeletedBy

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(92, "\n                    ");
                        __builder4.OpenElement(93, "td");
                        __builder4.AddContent(94, 
#line 58 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
                         context.DeletedOn

#line default
#line hidden
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(95, "\n                ");
                    }
                    );
                    __builder3.AddMarkupContent(96, "\n");
#line 61 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(97, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 65 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/RecycleBin/Index.razor"
       
    private List<Page> _pages;
    private List<Module> _modules;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await Load();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Deleted Pages Or Modules {Error}", ex.Message);
            AddModuleMessage("Error Loading Deleted Pages Or Modules", MessageType.Error);
        }
    }

    private async Task Load()
    {
        _pages = await PageService.GetPagesAsync(PageState.Site.SiteId);
        _pages = _pages.Where(item => item.IsDeleted).ToList();

        _modules = await ModuleService.GetModulesAsync(PageState.Site.SiteId);
        _modules = _modules.Where(item => item.IsDeleted).ToList();
    }

    private async Task RestorePage(Page page)
    {
        try
        {
            page.IsDeleted = false;
            await PageService.UpdatePageAsync(page);
            await logger.LogInformation("Page Restored {Page}", page);
            await Load();
            StateHasChanged();
            NavigationManager.NavigateTo(NavigateUrl());
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Restoring Deleted Page {Page} {Error}", page, ex.Message);
            AddModuleMessage("Error Restoring Deleted Page", MessageType.Error);
        }
    }

    private async Task DeletePage(Page page)
    {
        try
        {
            await PageService.DeletePageAsync(page.PageId);
            await logger.LogInformation("Page Permanently Deleted {Page}", page);
            await Load();
            StateHasChanged();
            NavigationManager.NavigateTo(NavigateUrl());
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Permanently Deleting Page {Page} {Error}", page, ex.Message);
            AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

    private async Task RestoreModule(Module module)
    {
        try
        {
            var pagemodule = await PageModuleService.GetPageModuleAsync(module.PageModuleId);
            pagemodule.IsDeleted = false;
            await PageModuleService.UpdatePageModuleAsync(pagemodule);
            await logger.LogInformation("Module Restored {Module}", module);
            await Load();
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Restoring Deleted Module {Module} {Error}", module, ex.Message);
            AddModuleMessage("Error Restoring Deleted Module", MessageType.Error);
        }
    }

    private async Task DeleteModule(Module module)
    {
        try
        {
            await PageModuleService.DeletePageModuleAsync(module.PageModuleId);
            // check if there are any remaining module instances in the site
            _modules = await ModuleService.GetModulesAsync(PageState.Site.SiteId);
            
            if (!_modules.Exists(item => item.ModuleId == module.ModuleId))
            {
                await ModuleService.DeleteModuleAsync(module.ModuleId);
            }
            
            await logger.LogInformation("Module Permanently Deleted {Module}", module);
            await Load();
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Permanently Deleting Module {Module} {Error}", module, ex.Message);
            AddModuleMessage("Error Permanently Deleting Module", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageService PageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleService ModuleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageModuleService PageModuleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Oqtane.Modules.Admin.RecycleBin.Index
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
        public static void CreatePager_1<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
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
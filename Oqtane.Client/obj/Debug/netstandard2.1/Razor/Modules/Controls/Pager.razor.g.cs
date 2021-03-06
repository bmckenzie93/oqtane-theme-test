#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d38f7c6789effc0e1beb464443fb709fcc8bd62"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Controls
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
    public partial class Pager<TableItem> : ModuleControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddMarkupContent(1, "\n");
#line 6 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
     if (Format == "Table")
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", 
#line 8 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                       Class

#line default
#line hidden
            );
            __builder.AddMarkupContent(5, "\n            ");
            __builder.OpenElement(6, "thead");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenElement(8, "tr");
            __builder.AddContent(9, 
#line 10 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                     Header

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\n");
#line 13 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                 foreach (var item in ItemList)
                {

#line default
#line hidden
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "tr");
            __builder.AddContent(16, 
#line 15 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                         Row(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#line 16 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                     if (Detail != null)
                    {

#line default
#line hidden
            __builder.AddContent(18, "                        ");
            __builder.OpenElement(19, "tr");
            __builder.AddContent(20, 
#line 18 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                             Detail(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                    }

#line default
#line hidden
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                     
                }

#line default
#line hidden
            __builder.AddContent(22, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#line 23 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
    }

#line default
#line hidden
#line 24 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
     if (Format == "Grid")
    {

#line default
#line hidden
            __builder.AddContent(25, "        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", 
#line 26 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                     Class

#line default
#line hidden
            );
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.AddContent(31, 
#line 27 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                              Header

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#line 28 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
             foreach (var item in ItemList)
            {

#line default
#line hidden
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddContent(36, 
#line 30 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                  Row(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#line 31 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                 if (Detail != null)
                {

#line default
#line hidden
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.AddContent(41, 
#line 33 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                      Detail(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#line 34 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                }

#line default
#line hidden
#line 34 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                 
            }

#line default
#line hidden
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#line 37 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
    }

#line default
#line hidden
            __builder.AddContent(45, "    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "mx-auto text-center");
            __builder.AddMarkupContent(48, "\n");
#line 39 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
         if (_page > _maxPages)
        {

#line default
#line hidden
            __builder.AddContent(49, "            ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-secondary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 41 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                         async () => SetPagerSize("back")

#line default
#line hidden
            ));
            __builder.AddMarkupContent(53, "<span class=\"oi oi-media-skip-backward\" title=\"back\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
#line 42 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
        }

#line default
#line hidden
#line 43 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
         if (_endPage > 1)
        {

#line default
#line hidden
            __builder.AddContent(55, "            ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-secondary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                         async () => NavigateToPage("previous")

#line default
#line hidden
            ));
            __builder.AddMarkupContent(59, "<span class=\"oi oi-chevron-left\" title=\"previous\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
#line 46 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
             for (int i = _startPage; i <= _endPage; i++)
            {
                var pager = i;

#line default
#line hidden
            __builder.AddContent(61, "                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn" + " " + (
#line 49 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                     (pager == _page) ? "btn-primary" : "btn-link"

#line default
#line hidden
            ));
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 49 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                                                                async () => UpdateList(pager)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(65, "\n                    ");
            __builder.AddContent(66, 
#line 50 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                     pager

#line default
#line hidden
            );
            __builder.AddMarkupContent(67, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
#line 52 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
            }

#line default
#line hidden
            __builder.AddContent(69, "            ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-secondary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 53 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                         async () => NavigateToPage("next")

#line default
#line hidden
            ));
            __builder.AddMarkupContent(73, "<span class=\"oi oi-chevron-right\" title=\"next\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n");
#line 54 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
        }

#line default
#line hidden
#line 55 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
         if (_endPage < _pages)
        {

#line default
#line hidden
            __builder.AddContent(75, "            ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "btn btn-secondary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 57 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                         async () => SetPagerSize("forward")

#line default
#line hidden
            ));
            __builder.AddMarkupContent(79, "<span class=\"oi oi-media-skip-forward\" title=\"forward\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n");
#line 58 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
        }

#line default
#line hidden
#line 59 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
         if (_endPage > 1)
        {

#line default
#line hidden
            __builder.AddContent(81, "            ");
            __builder.OpenElement(82, "span");
            __builder.AddAttribute(83, "class", "btn btn-link disabled");
            __builder.AddContent(84, "Page ");
            __builder.AddContent(85, 
#line 61 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                      _page

#line default
#line hidden
            );
            __builder.AddContent(86, " of ");
            __builder.AddContent(87, 
#line 61 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
                                                                _pages

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n");
#line 62 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
        }

#line default
#line hidden
            __builder.AddContent(89, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 66 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Controls/Pager.razor"
       
    private int _pages = 0;
    private int _page = 1;
    private int _maxItems;
    private int _maxPages;
    private int _startPage;
    private int _endPage;

    [Parameter]
    public string Format { get; set; }

    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment<TableItem> Row { get; set; }

    [Parameter]
    public RenderFragment<TableItem> Detail { get; set; }

    [Parameter]
    public IEnumerable<TableItem> Items { get; set; }

    [Parameter]
    public string PageSize { get; set; }

    [Parameter]
    public string DisplayPages { get; set; }

    [Parameter]
    public string Class { get; set; }

    private IEnumerable<TableItem> ItemList { get; set; }

    protected override void OnParametersSet()
    {
        if (string.IsNullOrEmpty(Format))
        {
            Format = "Table";
        }

        if (string.IsNullOrEmpty(Class))
        {
            if (Format == "Table")
            {
                Class = "table table-borderless";
            }
            else
            {
                Class = "container";
            }
        }

        if (string.IsNullOrEmpty(PageSize))
        {
            _maxItems = 10;
        }
        else
        {
            _maxItems = int.Parse(PageSize);
        }

        if (string.IsNullOrEmpty(DisplayPages))
        {
            _maxPages = 5;
        }
        else
        {
            _maxPages = int.Parse(DisplayPages);
        }

        if (Items != null)
        {
            ItemList = Items.Skip((_page - 1) * _maxItems).Take(_maxItems);
            _pages = (int)Math.Ceiling(Items.Count() / (decimal)_maxItems);
        }

        SetPagerSize("forward");
    }

    public void UpdateList(int currentPage)
    {
        ItemList = Items.Skip((currentPage - 1) * _maxItems).Take(_maxItems);
        _page = currentPage;

        StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward")
        {
            if (_endPage + 1 < _pages)
            {
                _startPage = _endPage + 1;
            }
            else
            {
                _startPage = 1;
            }

            if (_endPage + _maxPages < _pages)
            {
                _endPage = _startPage + _maxPages - 1;
            }
            else
            {
                _endPage = _pages;
            }

            StateHasChanged();
        }
        else if (direction == "back")
        {
            _endPage = _startPage - 1;
            _startPage = _startPage - _maxPages;
        }
    }

    public void NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (_page < _pages)
            {
                if (_page == _endPage)
                {
                    SetPagerSize("forward");
                }
                _page += 1;
            }
        }
        else if (direction == "previous")
        {
            if (_page > 1)
            {
                if (_page == _startPage)
                {
                    SetPagerSize("back");
                }
                _page -= 1;
            }
        }

        UpdateList(_page);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

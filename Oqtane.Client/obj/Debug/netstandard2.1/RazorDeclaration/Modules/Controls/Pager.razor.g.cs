#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Pager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d38f7c6789effc0e1beb464443fb709fcc8bd62"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Pager<TableItem> : ModuleControlBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 66 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Controls/Pager.razor"
       
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
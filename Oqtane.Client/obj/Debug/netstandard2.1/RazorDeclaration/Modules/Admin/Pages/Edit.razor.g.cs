#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Pages/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24249b3974d46dc594ebd5b2307757981023799"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Pages
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
    public partial class Edit : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 209 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Pages/Edit.razor"
       
    private List<Theme> _themeList;
    private List<ThemeControl> _themes = new List<ThemeControl>();
    private List<ThemeControl> _layouts = new List<ThemeControl>();
    private List<ThemeControl> _containers = new List<ThemeControl>();
    private List<Page> _pageList;
    private int _pageId;
    private string _name;
    private string _title;
    private string _path;
    private string _currentparentid;
    private string _parentid;
    private string _insert = "=";
    private List<Page> _children;
    private int _childid = -1;
    private string _isnavigation;
    private string _url;
    private string _ispersonalizable;
    private string _themetype = "-";
    private string _layouttype = "-";
    private string _containertype = "-";
    private string _icon;
    private string _permissions = null;
    private string _createdby;
    private DateTime _createdon;
    private string _modifiedby;
    private DateTime _modifiedon;
    private string _deletedby;
    private DateTime? _deletedon;

#pragma warning disable 649
    private PermissionGrid _permissionGrid;
#pragma warning restore 649

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _pageList = PageState.Pages;
            _children = PageState.Pages.Where(item => item.ParentId == null).ToList();

            _themeList = await ThemeService.GetThemesAsync();
            _themes = ThemeService.GetThemeControls(_themeList);

            _pageId = Int32.Parse(PageState.QueryString["id"]);
            var page = PageState.Pages.FirstOrDefault(item => item.PageId == _pageId);
            if (page != null)
            {
                _name = page.Name;
                _title = page.Title;
                _path = page.Path;

                if (_path.Contains("/"))
                {
                    _path = _path.Substring(_path.LastIndexOf("/") + 1);
                }

                if (page.ParentId == null)
                {
                    _parentid = string.Empty;
                }
                else
                {
                    _parentid = page.ParentId.ToString();
                }

                _currentparentid = _parentid;
                _isnavigation = page.IsNavigation.ToString();
                _url = page.Url;
                _ispersonalizable = page.IsPersonalizable.ToString();
                _themetype = page.ThemeType;
                if (_themetype == PageState.Site.DefaultThemeType)
                {
                    _themetype = "-";
                }
                _layouts = ThemeService.GetLayoutControls(_themeList, page.ThemeType);
                _layouttype = page.LayoutType;
                if (_layouttype == PageState.Site.DefaultLayoutType)
                {
                    _layouttype = "-";
                }
                _containers = ThemeService.GetContainerControls(_themeList, page.ThemeType);
                _containertype = page.DefaultContainerType;
                if (string.IsNullOrEmpty(_containertype))
                {
                    _containertype = "-";
                }
                _icon = page.Icon;
                _permissions = page.Permissions;
                _createdby = page.CreatedBy;
                _createdon = page.CreatedOn;
                _modifiedby = page.ModifiedBy;
                _modifiedon = page.ModifiedOn;
                _deletedby = page.DeletedBy;
                _deletedon = page.DeletedOn;
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Page {PageId} {Error}", _pageId, ex.Message);
            AddModuleMessage("Error Loading Page", MessageType.Error);
        }
    }

    private async void ParentChanged(ChangeEventArgs e)
    {
        try
        {
            _parentid = (string)e.Value;
            _children = new List<Page>();
            if (_parentid == "-1")
            {
                foreach (Page p in PageState.Pages.Where(item => item.ParentId == null))
                {
                    if (UserSecurity.IsAuthorized(PageState.User, PermissionNames.View, p.Permissions))
                    {
                        _children.Add(p);
                    }
                }
            }
            else
            {
                foreach (Page p in PageState.Pages.Where(item => item.ParentId == int.Parse(_parentid)))
                {
                    if (UserSecurity.IsAuthorized(PageState.User, PermissionNames.View, p.Permissions))
                    {
                        _children.Add(p);
                    }
                }
            }
            if (_parentid == _currentparentid)
            {
                _insert = "=";
            }
            else
            {
                _insert = ">>";
            }
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Child Pages For Parent {PageId} {Error}", _parentid, ex.Message);
            AddModuleMessage("Error Loading Child Pages For Parent", MessageType.Error);
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

    private async Task SavePage()
    {
        Page page = null;
        try
        {
            if (_name != string.Empty)
            {
                page = PageState.Pages.FirstOrDefault(item => item.PageId == _pageId);
                string currentPath = page.Path;

                page.Name = _name;
                page.Title = _title;
                if (_path == "" && _name.ToLower() != "home")
                    if (_path == string.Empty && _name.ToLower() != "home")
                    {
                        _path = _name;
                    }
                if (_path.Contains("/"))
                {
                    _path = _path.Substring(_path.LastIndexOf("/") + 1);
                }
                if (string.IsNullOrEmpty(_parentid) || _parentid == "-1")
                {
                    page.ParentId = null;
                    page.Path = Utilities.GetFriendlyUrl(_path);
                }
                else
                {
                    page.ParentId = Int32.Parse(_parentid);
                    Page parent = PageState.Pages.FirstOrDefault(item => item.PageId == page.ParentId);
                    if (parent.Path == string.Empty)
                    {
                        page.Path = Utilities.GetFriendlyUrl(parent.Name) + "/" + Utilities.GetFriendlyUrl(_path);
                    }
                    else
                    {
                        page.Path = parent.Path + "/" + Utilities.GetFriendlyUrl(_path);
                    }
                }

                if (!PagePathIsUnique(page.Path, page.SiteId, page.PageId, _pageList))
                {
                    AddModuleMessage($"A page with path {_path} already exists for the selected parent page. The page path needs to be unique for the selected parent.", MessageType.Warning);
                    return;
                }

                if (_insert != "=")
                {
                    Page child;
                    switch (_insert)
                    {
                        case "<<":
                            page.Order = 0;
                            break;
                        case "<":
                            child = PageState.Pages.FirstOrDefault(item => item.PageId == _childid);
                            if (child != null) page.Order = child.Order - 1;
                            break;
                        case ">":
                            child = PageState.Pages.FirstOrDefault(item => item.PageId == _childid);
                            if (child != null) page.Order = child.Order + 1;
                            break;
                        case ">>":
                            page.Order = int.MaxValue;
                            break;
                    }
                }
                page.IsNavigation = (_isnavigation == null || Boolean.Parse(_isnavigation));
                page.Url = _url;
                page.ThemeType = (_themetype != "-") ? _themetype : string.Empty;
                if (!string.IsNullOrEmpty(page.ThemeType) && page.ThemeType == PageState.Site.DefaultThemeType)
                {
                    page.ThemeType = string.Empty;
                }
                page.LayoutType = (_layouttype != "-") ? _layouttype : string.Empty;
                if (!string.IsNullOrEmpty(page.LayoutType) && page.LayoutType == PageState.Site.DefaultLayoutType)
                {
                    page.LayoutType = string.Empty;
                }
                page.DefaultContainerType = (_containertype != "-") ? _containertype : string.Empty;
                if (!string.IsNullOrEmpty(page.DefaultContainerType) && page.DefaultContainerType == PageState.Site.DefaultContainerType)
                {
                    page.DefaultContainerType = string.Empty;
                }
                page.Icon = _icon ?? string.Empty;
                page.Permissions = _permissionGrid.GetPermissions();
                page.IsPersonalizable = (_ispersonalizable != null && Boolean.Parse(_ispersonalizable));
                page.UserId = null;

                page = await PageService.UpdatePageAsync(page);
                await PageService.UpdatePageOrderAsync(page.SiteId, page.PageId, page.ParentId);
                if (_currentparentid == string.Empty)
                {
                    await PageService.UpdatePageOrderAsync(page.SiteId, page.PageId, null);
                }
                else
                {
                    await PageService.UpdatePageOrderAsync(page.SiteId, page.PageId, int.Parse(_currentparentid));
                }

                // update child paths
                if (_parentid != _currentparentid)
                {
                    foreach (Page p in PageState.Pages.Where(item => item.Path.StartsWith(currentPath)))
                    {
                        p.Path = p.Path.Replace(currentPath, page.Path);
                        await PageService.UpdatePageAsync(p);
                    }
                }

                await logger.LogInformation("Page Saved {Page}", page);
                NavigationManager.NavigateTo(NavigateUrl(page.Path));
            }
            else
            {
                AddModuleMessage("You Must Provide Page Name", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Saving Page {Page} {Error}", page, ex.Message);
            AddModuleMessage("Error Saving Page", MessageType.Error);
        }
    }

    private static bool PagePathIsUnique(string pagePath, int siteId, int pageId, List<Page> existingPages)
    {
        return !existingPages.Any(page => page.SiteId == siteId && page.Path == pagePath && page.PageId != pageId);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IThemeService ThemeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPageService PageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

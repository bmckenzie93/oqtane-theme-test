#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sites/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf3aa9c12423039c0e00424ed2fdb76a401cfff"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Sites
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
#line 108 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Sites/Edit.razor"
       
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
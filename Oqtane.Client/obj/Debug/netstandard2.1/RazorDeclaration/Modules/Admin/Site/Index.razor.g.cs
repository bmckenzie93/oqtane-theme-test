#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Site/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db030511a9a35d9c56c3793482fcc7119bfe2b7d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Site
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
    public partial class Index : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 213 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/Site/Index.razor"
       
    private bool _initialized = false;
    private List<Theme> _themeList;
    private List<ThemeControl> _themes = new List<ThemeControl>();
    private List<ThemeControl> _layouts = new List<ThemeControl>();
    private List<ThemeControl> _containers = new List<ThemeControl>();
    private string _name = string.Empty;
    private List<Tenant> _tenantList;
    private string _tenant = string.Empty;
    private List<Alias> _aliasList;
    private string _urls = string.Empty;
    private int _logofileid = -1;
    private FileManager _logofilemanager;
    private int _faviconfileid = -1;
    private FileManager _faviconfilemanager;
    private string _themetype = "-";
    private string _layouttype = "-";
    private string _containertype = "-";
    private string _allowregistration;
    private string _smtphost = string.Empty;
    private string _smtpport = string.Empty;
    private string _smtpssl = string.Empty;
    private string _smtpusername = string.Empty;
    private string _smtppassword = string.Empty;
    private string _pwaisenabled;
    private int _pwaappiconfileid = -1;
    private FileManager _pwaappiconfilemanager;
    private int _pwasplashiconfileid = -1;
    private FileManager _pwasplashiconfilemanager;
    private string _createdby;
    private DateTime _createdon;
    private string _modifiedby;
    private DateTime _modifiedon;
    private string _deletedby;
    private DateTime? _deletedon;
    private string _isdeleted;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _themeList = await ThemeService.GetThemesAsync();
            _aliasList = await AliasService.GetAliasesAsync();
            Site site = await SiteService.GetSiteAsync(PageState.Site.SiteId);
            if (site != null)
            {
                _name = site.Name;
                _tenantList = await TenantService.GetTenantsAsync();
                _tenant = _tenantList.Find(item => item.TenantId == site.TenantId).Name;
                foreach (Alias alias in _aliasList.Where(item => item.SiteId == site.SiteId && item.TenantId == site.TenantId).ToList())
                {
                    _urls += alias.Name + "\n";
                }
                if (site.LogoFileId != null)
                {
                    _logofileid = site.LogoFileId.Value;
                }

                if (site.FaviconFileId != null)
                {
                    _faviconfileid = site.FaviconFileId.Value;
                }

                _themes = ThemeService.GetThemeControls(_themeList);
                _themetype = site.DefaultThemeType;
                _layouts = ThemeService.GetLayoutControls(_themeList, _themetype);
                _layouttype = site.DefaultLayoutType;
                _containers = ThemeService.GetContainerControls(_themeList, _themetype);
                _containertype = site.DefaultContainerType;
                _allowregistration = site.AllowRegistration.ToString();

                var settings = await SettingService.GetSiteSettingsAsync(site.SiteId);
                _smtphost = SettingService.GetSetting(settings, "SMTPHost", string.Empty);
                _smtpport = SettingService.GetSetting(settings, "SMTPPort", string.Empty);
                _smtpssl = SettingService.GetSetting(settings, "SMTPSSL", string.Empty);
                _smtpusername = SettingService.GetSetting(settings, "SMTPUsername", string.Empty);
                _smtppassword = SettingService.GetSetting(settings, "SMTPPassword", string.Empty);

                _pwaisenabled = site.PwaIsEnabled.ToString();

                if (site.PwaAppIconFileId != null)
                {
                    _pwaappiconfileid = site.PwaAppIconFileId.Value;
                }

                if (site.PwaSplashIconFileId != null)
                {
                    _pwasplashiconfileid = site.PwaSplashIconFileId.Value;
                }

                _pwaisenabled = site.PwaIsEnabled.ToString();
                if (site.PwaAppIconFileId != null)
                {
                    _pwaappiconfileid = site.PwaAppIconFileId.Value;
                }
                if (site.PwaSplashIconFileId != null)
                {
                    _pwasplashiconfileid = site.PwaSplashIconFileId.Value;
                }

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
            await logger.LogError(ex, "Error Loading Site {SiteId} {Error}", PageState.Site.SiteId, ex.Message);
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
                    if (_aliasList.Exists(item => item.Name == name && item.SiteId != PageState.Alias.SiteId && item.TenantId != PageState.Alias.TenantId))
                    {
                        unique = false;
                    }
                }

                if (unique)
                {
                    var site = await SiteService.GetSiteAsync(PageState.Site.SiteId);
                    if (site != null)
                    {
                        site.Name = _name;
                        site.LogoFileId = null;
                        var logofileid = _logofilemanager.GetFileId();
                        if (logofileid != -1)
                        {
                            site.LogoFileId = logofileid;
                        }

                        site.DefaultThemeType = _themetype;
                        site.DefaultLayoutType = (_layouttype == "-" ? string.Empty : _layouttype);
                        site.DefaultContainerType = _containertype;
                        site.AllowRegistration = (_allowregistration == null ? true : Boolean.Parse(_allowregistration));
                        site.IsDeleted = (_isdeleted == null ? true : Boolean.Parse(_isdeleted));

                        site.PwaIsEnabled = (_pwaisenabled == null ? true : Boolean.Parse(_pwaisenabled));

                        var pwaappiconfileid = _pwaappiconfilemanager.GetFileId();
                        if (pwaappiconfileid != -1)
                        {
                            site.PwaAppIconFileId = pwaappiconfileid;
                        }

                        var pwasplashiconfileid = _pwasplashiconfilemanager.GetFileId();
                        if (pwasplashiconfileid != -1)
                        {
                            site.PwaSplashIconFileId = pwasplashiconfileid;
                        }

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
                                Alias alias = new Alias();
                                alias.Name = name;
                                alias.TenantId = site.TenantId;
                                alias.SiteId = site.SiteId;
                                await AliasService.AddAliasAsync(alias);
                            }
                        }

                        var settings = await SettingService.GetSiteSettingsAsync(site.SiteId);
                        SettingService.SetSetting(settings, "SMTPHost", _smtphost);
                        SettingService.SetSetting(settings, "SMTPPort", _smtpport);
                        SettingService.SetSetting(settings, "SMTPSSL", _smtpssl);
                        SettingService.SetSetting(settings, "SMTPUsername", _smtpusername);
                        SettingService.SetSetting(settings, "SMTPPassword", _smtppassword);
                        await SettingService.UpdateSiteSettingsAsync(settings, site.SiteId);

                        await logger.LogInformation("Site Saved {Site}", site);

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
            await logger.LogError(ex, "Error Saving Site {SiteId} {Error}", PageState.Site.SiteId, ex.Message);
            AddModuleMessage("Error Saving Site", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISettingService SettingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IThemeService ThemeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAliasService AliasService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISiteService SiteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

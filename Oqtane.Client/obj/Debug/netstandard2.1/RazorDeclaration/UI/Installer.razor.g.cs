#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/Installer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f415f0158f998848e5f23c9536b2a4de8bf89241"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.UI
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
    public partial class Installer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 128 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/UI/Installer.razor"
       
    private string _databaseType = "LocalDB";
    private string _serverName = "(LocalDb)\\MSSQLLocalDB";
    private string _databaseName = "Oqtane-" + DateTime.UtcNow.ToString("yyyyMMddHHmm");
    private string _username = "";
    private string _password = "";
    private string _hostUsername = Constants.HostUser;
    private string _hostPassword = "";
    private string _confirmPassword = "";
    private string _hostEmail = "";
    private string _message = "";
    private string _integratedSecurityDisplay = "display: none;";
    private string _loadingDisplay = "display: none;";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var interop = new Interop(JSRuntime);
            await interop.IncludeLink("app-stylesheet", "stylesheet", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", "text/css", "sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T", "anonymous", "");
        }
    }

    private void SetIntegratedSecurity(ChangeEventArgs e)
    {
        _integratedSecurityDisplay = Convert.ToBoolean((string)e.Value)
            ? "display: none;"
            : string.Empty;
    }

    private async Task Install()
    {
        if (_serverName != "" && _databaseName != "" && _hostUsername != "" && _hostPassword.Length >= 6 && _hostPassword == _confirmPassword && _hostEmail != "")
        {
            _loadingDisplay = "";
            StateHasChanged();

            var connectionstring = "";
            if (_databaseType == "LocalDB")
            {
                connectionstring = "Data Source=" + _serverName + ";AttachDbFilename=|DataDirectory|\\" + _databaseName + ".mdf;Initial Catalog=" + _databaseName + ";Integrated Security=SSPI;";
            }
            else
            {
                connectionstring = "Data Source=" + _serverName + ";Initial Catalog=" + _databaseName + ";";
                if (_integratedSecurityDisplay == "display: none;")
                {
                    connectionstring += "Integrated Security=SSPI;";
                }
                else
                {
                    connectionstring += "User ID=" + _username + ";Password=" + _password;
                }
            }

            Uri uri = new Uri(NavigationManager.Uri);

            var config = new InstallConfig
            {
                ConnectionString = connectionstring,
                Aliases = uri.Authority,
                HostEmail = _hostEmail,
                HostPassword = _hostPassword,
                HostName = Constants.HostUser,
                TenantName = Constants.MasterTenant,
                IsNewTenant = true,
                SiteName = Constants.DefaultSite
            };

            var installation = await InstallationService.Install(config);
            if (installation.Success)
            {
                NavigationManager.NavigateTo(uri.Scheme + "://" + uri.Authority, true);
            }
            else
            {
                _message = "<div class=\"alert alert-danger\" role=\"alert\">" + installation.Message + "</div>";
                _loadingDisplay = "display: none;";
            }
        }
        else
        {
            _message = "<div class=\"alert alert-danger\" role=\"alert\">Please Enter All Fields And Ensure Passwords Match And Are Greater Than 5 Characters In Length</div>";
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISiteService SiteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstallationService InstallationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

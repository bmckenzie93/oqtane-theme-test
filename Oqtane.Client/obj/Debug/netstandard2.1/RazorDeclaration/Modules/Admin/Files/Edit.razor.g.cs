#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a6f96d8ca68b7dfe9dd283fd9cfd3240a41ce2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oqtane.Modules.Admin.Files
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
#line 58 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
       
    private List<Folder> _folders;
    private int _folderId = -1;
    private string _name;
    private int _parentId = -1;
    private bool _isSystem;
    private string _permissions = string.Empty;
    private string _createdBy;
    private DateTime _createdOn;
    private string _modifiedBy;
    private DateTime _modifiedOn;

#pragma warning disable 649
    private PermissionGrid _permissionGrid;
#pragma warning restore 649

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Admin;

    public override string Title => "Folder Management";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _folders = await FolderService.GetFoldersAsync(PageState.Site.SiteId);

            if (PageState.QueryString.ContainsKey("id"))
            {
                _folderId = Int32.Parse(PageState.QueryString["id"]);
                Folder folder = await FolderService.GetFolderAsync(_folderId);
                if (folder != null)
                {
                    _parentId = folder.ParentId ?? -1;
                    _name = folder.Name;
                    _isSystem = folder.IsSystem;
                    _permissions = folder.Permissions;
                    _createdBy = folder.CreatedBy;
                    _createdOn = folder.CreatedOn;
                    _modifiedBy = folder.ModifiedBy;
                    _modifiedOn = folder.ModifiedOn;
                }
            }
            else
            {
                _parentId = _folders[0].FolderId;
                _permissions = string.Empty;
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Folder {FolderId} {Error}", _folderId, ex.Message);
            AddModuleMessage("Error Loading Folder", MessageType.Error);
        }
    }

    private async Task SaveFolder()
    {
        if (_name == string.Empty || _parentId == -1)
        {
            AddModuleMessage("Folders Must Have A Parent And A Name", MessageType.Warning);
            return;
        }

        if (!_name.IsPathOrFileValid())
        {
            AddModuleMessage("Folder Name Not Valid.", MessageType.Warning);
            return;
        }
        
        try
        {
            Folder folder;
            if (_folderId != -1)
            {
                folder = await FolderService.GetFolderAsync(_folderId);
            }
            else
            {
                folder = new Folder();
            }

            folder.SiteId = PageState.Site.SiteId;

            if (_parentId == -1)
            {
                folder.ParentId = null;
            }
            else
            {
                folder.ParentId = _parentId;
            }

            folder.Name = _name;
            folder.IsSystem = _isSystem;
            folder.Permissions = _permissionGrid.GetPermissions();

            if (_folderId != -1)
            {
                folder = await FolderService.UpdateFolderAsync(folder);
            }
            else
            {
                folder = await FolderService.AddFolderAsync(folder);
            }

            if (folder != null)
            {
                await FolderService.UpdateFolderOrderAsync(folder.SiteId, folder.FolderId, folder.ParentId);
                await logger.LogInformation("Folder Saved {Folder}", folder);
                NavigationManager.NavigateTo(NavigateUrl());
            }
            else
            {
                AddModuleMessage("An Error Was Encountered Saving The Folder", MessageType.Error);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Saving Folder {FolderId} {Error}", _folderId, ex.Message);
            AddModuleMessage("Error Saving Module", MessageType.Error);
        }
    }

    private async Task DeleteFolder()
    {
        try
        {
            await FolderService.DeleteFolderAsync(_folderId);
            await logger.LogInformation("Folder Deleted {Folder}", _folderId);
            AddModuleMessage("Folder Deleted", MessageType.Success);
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Deleting Folder {Folder} {Error}", _folderId, ex.Message);
            AddModuleMessage("Error Deleting Folder", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFolderService FolderService { get; set; }
    }
}
#pragma warning restore 1591

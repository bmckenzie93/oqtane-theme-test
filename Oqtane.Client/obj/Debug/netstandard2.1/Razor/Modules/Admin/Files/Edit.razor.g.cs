#pragma checksum "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a6f96d8ca68b7dfe9dd283fd9cfd3240a41ce2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 6 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
 if (_folders != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-borderless");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\n            ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(8);
            __builder.AddAttribute(9, "For", "parent");
            __builder.AddAttribute(10, "HelpText", "Select the parent folder");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Parent: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "id", "parent");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 14 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                 _parentId

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _parentId = __value, _parentId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(22, "\n");
#line 15 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                     if (PageState.QueryString.ContainsKey("id"))
                    {

#line default
#line hidden
            __builder.AddContent(23, "                        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "-1");
            __builder.AddContent(26, "<No Parent>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#line 18 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                    }

#line default
#line hidden
#line 19 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                     foreach (Folder folder in _folders)
                    {

#line default
#line hidden
            __builder.AddContent(28, "                        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#line 21 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                         folder.FolderId

#line default
#line hidden
            );
            __builder.AddContent(31, 
#line 21 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                             new string('-', folder.Level * 2)

#line default
#line hidden
            );
            __builder.AddContent(32, 
#line 21 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                                                 folder.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#line 22 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                    }

#line default
#line hidden
            __builder.AddContent(34, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(42);
            __builder.AddAttribute(43, "for", "name");
            __builder.AddAttribute(44, "HelpText", "Enter the folder name");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Name: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "id", "name");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 31 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                              _name

#line default
#line hidden
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _name = __value, _name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.OpenElement(59, "tr");
            __builder.AddMarkupContent(60, "\n            ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "colspan", "2");
            __builder.AddAttribute(63, "align", "center");
            __builder.AddMarkupContent(64, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(65);
            __builder.AddAttribute(66, "For", "permissions");
            __builder.AddAttribute(67, "HelpText", "Select the permissions you want for the folder");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(69, "Permissions: ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\n                ");
            __builder.OpenComponent<Oqtane.Modules.Controls.PermissionGrid>(71);
            __builder.AddAttribute(72, "EntityName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                             EntityNames.Folder

#line default
#line hidden
            ));
            __builder.AddAttribute(73, "PermissionNames", "Browse,View,Edit");
            __builder.AddAttribute(74, "Permissions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                                                                  _permissions

#line default
#line hidden
            ));
            __builder.AddComponentReferenceCapture(75, (__value) => {
#line 37 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                                                                                      _permissionGrid = (Oqtane.Modules.Controls.PermissionGrid)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n");
#line 41 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
     if (!_isSystem)
    {

#line default
#line hidden
            __builder.AddContent(80, "        ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "class", "btn btn-success");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                SaveFolder

#line default
#line hidden
            ));
            __builder.AddContent(85, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n");
#line 44 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
    }

#line default
#line hidden
            __builder.AddContent(87, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
            __builder.AddAttribute(89, "class", "btn btn-secondary");
            __builder.AddAttribute(90, "href", 
#line 45 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                              NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(92, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\n");
#line 46 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
     if (!_isSystem && PageState.QueryString.ContainsKey("id"))
    {

#line default
#line hidden
            __builder.AddContent(94, "        ");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "type", "button");
            __builder.AddAttribute(97, "class", "btn btn-danger");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                               DeleteFolder

#line default
#line hidden
            ));
            __builder.AddContent(99, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n");
#line 49 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(101, "    <br>\n    <br>\n");
#line 52 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
     if (PageState.QueryString.ContainsKey("id"))
    {

#line default
#line hidden
            __builder.AddContent(102, "        ");
            __builder.OpenComponent<Oqtane.Modules.Controls.AuditInfo>(103);
            __builder.AddAttribute(104, "CreatedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                               _createdBy

#line default
#line hidden
            ));
            __builder.AddAttribute(105, "CreatedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                       _createdOn

#line default
#line hidden
            ));
            __builder.AddAttribute(106, "ModifiedBy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                                _modifiedBy

#line default
#line hidden
            ));
            __builder.AddAttribute(107, "ModifiedOn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 54 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
                                                                                                          _modifiedOn

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\n");
#line 55 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
    }

#line default
#line hidden
#line 55 "/Users/cam/Desktop/oqtane.framework/Oqtane.Client/Modules/Admin/Files/Edit.razor"
     
}

#line default
#line hidden
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
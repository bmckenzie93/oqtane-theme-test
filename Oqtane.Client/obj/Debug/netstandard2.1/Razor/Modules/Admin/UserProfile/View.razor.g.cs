#pragma checksum "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccba57730b6e7699d5227402f74cf1b8cf20cc69"
// <auto-generated/>
#pragma warning disable 1591
namespace Oqtane.Modules.Admin.UserProfile
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
    public partial class View : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 7 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
 if (PageState.User != null)
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
            __builder.OpenElement(8, "label");
            __builder.AddAttribute(9, "class", "control-label");
            __builder.AddContent(10, 
#line 12 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                              title

#line default
#line hidden
            );
            __builder.AddContent(11, ": ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#line 14 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
             if (title == "From")
            {

#line default
#line hidden
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "readonly", true);
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                        username

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#line 19 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
            }

#line default
#line hidden
#line 20 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
             if (title == "To")
            {

#line default
#line hidden
            __builder.AddContent(24, "                ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 23 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                        username

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#line 25 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
            }

#line default
#line hidden
            __builder.AddContent(33, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\n            ");
            __builder.AddMarkupContent(37, "<td>\n                <label class=\"control-label\">Subject: </label>\n            </td>\n");
#line 31 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
             if (title == "From")
            {

#line default
#line hidden
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "td");
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "readonly", true);
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 34 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                        subject

#line default
#line hidden
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => subject = __value, subject));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#line 36 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
            }

#line default
#line hidden
#line 37 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
             if (title == "To")
            {

#line default
#line hidden
            __builder.AddContent(48, "                ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\n                    ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 40 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                        subject

#line default
#line hidden
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => subject = __value, subject));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n");
#line 42 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
            }

#line default
#line hidden
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#line 44 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
         if (title == "From")
        {

#line default
#line hidden
            __builder.AddContent(59, "            ");
            __builder.OpenElement(60, "tr");
            __builder.AddMarkupContent(61, "\n                ");
            __builder.AddMarkupContent(62, "<td>\n                    <label class=\"control-label\">Date: </label>\n                </td>\n                ");
            __builder.OpenElement(63, "td");
            __builder.AddMarkupContent(64, "\n                    ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "readonly", true);
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 51 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                        createdon

#line default
#line hidden
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createdon = __value, createdon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n");
#line 54 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
        }

#line default
#line hidden
#line 55 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
         if (title == "From")
        {

#line default
#line hidden
            __builder.AddContent(73, "            ");
            __builder.OpenElement(74, "tr");
            __builder.AddMarkupContent(75, "\n                ");
            __builder.AddMarkupContent(76, "<td>\n                    <label class=\"control-label\">Message: </label>\n                </td>\n                ");
            __builder.OpenElement(77, "td");
            __builder.AddMarkupContent(78, "\n                    ");
            __builder.OpenElement(79, "textarea");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.AddAttribute(81, "rows", "5");
            __builder.AddAttribute(82, "readonly", true);
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 62 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                           body

#line default
#line hidden
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => body = __value, body));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n");
#line 65 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
        }

#line default
#line hidden
#line 66 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
         if (title == "To")
        {

#line default
#line hidden
            __builder.AddContent(88, "            ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\n                ");
            __builder.AddMarkupContent(91, "<td>\n                    <label class=\"control-label\">Message: </label>\n                </td>\n                ");
            __builder.OpenElement(92, "td");
            __builder.AddMarkupContent(93, "\n                    ");
            __builder.OpenElement(94, "textarea");
            __builder.AddAttribute(95, "class", "form-control");
            __builder.AddAttribute(96, "rows", "5");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 73 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                           body

#line default
#line hidden
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => body = __value, body));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n");
#line 76 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
        }

#line default
#line hidden
            __builder.AddContent(102, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n");
#line 80 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
     if (reply != string.Empty)
    {

#line default
#line hidden
            __builder.AddContent(104, "        ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "type", "button");
            __builder.AddAttribute(107, "class", "btn btn-primary");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 82 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                                Send

#line default
#line hidden
            ));
            __builder.AddContent(109, "Send");
            __builder.CloseElement();
            __builder.AddContent(110, " ");
#line 82 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                                                    }
    else
    {
        if (title == "From")
        {

#line default
#line hidden
            __builder.AddContent(111, "            ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "type", "button");
            __builder.AddAttribute(114, "class", "btn btn-primary");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 87 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                                    Reply

#line default
#line hidden
            ));
            __builder.AddContent(116, "Reply");
            __builder.CloseElement();
#line 87 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                                                         }
    }

#line default
#line hidden
            __builder.AddContent(117, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(118);
            __builder.AddAttribute(119, "class", "btn btn-secondary");
            __builder.AddAttribute(120, "href", 
#line 89 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                              NavigateUrl()

#line default
#line hidden
            );
            __builder.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(122, "Cancel");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\n    <br>\n    <br>\n");
#line 92 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
     if (title == "To")
    {

#line default
#line hidden
            __builder.AddContent(124, "        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "control-group");
            __builder.AddMarkupContent(127, "\n            ");
            __builder.AddMarkupContent(128, "<label class=\"control-label\">Original Message </label>\n            ");
            __builder.OpenElement(129, "textarea");
            __builder.AddAttribute(130, "class", "form-control");
            __builder.AddAttribute(131, "rows", "5");
            __builder.AddAttribute(132, "readonly", true);
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 96 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
                                                   reply

#line default
#line hidden
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reply = __value, reply));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\n");
#line 98 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
        }

#line default
#line hidden
#line 98 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
         
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 101 "/Users/cam/Desktop/oqtane/oqtane-theme-test/Oqtane.Client/Modules/Admin/UserProfile/View.razor"
       
    private int notificationid;
    private string title = string.Empty;
    private string username = "";
    private string subject = string.Empty;
    private string createdon = string.Empty;
    private string body = string.Empty;
    private string reply = string.Empty;

    public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.View;
    public override string Title => "View Notification";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            notificationid = Int32.Parse(PageState.QueryString["id"]);
            Notification notification = await NotificationService.GetNotificationAsync(notificationid);
            if (notification != null)
            {
                int userid = -1;
                if (notification.ToUserId == PageState.User.UserId)
                {
                    title = "From";
                    if (notification.FromUserId != null)
                    {
                        userid = notification.FromUserId.Value;
                    }
                }
                else
                {
                    title = "To";
                    if (notification.ToUserId != null)
                    {
                        userid = notification.ToUserId.Value;
                    }
                }
                if (userid != -1)
                {
                    var user = await UserService.GetUserAsync(userid, PageState.Site.SiteId);
                    if (user != null)
                    {
                        username = user.Username;
                    }
                }
                if (username == "")
                {
                    username = "System";
                }
                subject = notification.Subject;
                createdon = notification.CreatedOn.ToString();
                body = notification.Body;
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Loading Users {Error}", ex.Message);
            AddModuleMessage("Error Loading Users", MessageType.Error);
        }
    }

    private void Reply()
    {
        title = "To";
        if (!subject.Contains("RE:"))
        {
            subject = "RE: " + subject;
        }
        reply = body;
        body = "\n\n____________________________________________\nSent: " + createdon + "\nSubject: " + subject + "\n\n" + body;
        StateHasChanged();
    }

    private async Task Send()
    {
        var notification = new Notification();
        try
        {
            var user = await UserService.GetUserAsync(username, PageState.Site.SiteId);
            if (user != null)
            {
                notification.SiteId = PageState.Site.SiteId;
                notification.FromUserId = PageState.User.UserId;
                notification.FromDisplayName = PageState.User.DisplayName;
                notification.FromEmail = PageState.User.Email;
                notification.ToUserId = user.UserId;
                notification.ToDisplayName = user.DisplayName;
                notification.ToEmail = user.Email;
                notification.Subject = subject;
                notification.Body = body;
                notification.ParentId = notificationid;
                notification.CreatedOn = DateTime.UtcNow;
                notification.IsDelivered = false;
                notification.DeliveredOn = null;
                notification.SendOn = DateTime.UtcNow;
                notification = await NotificationService.AddNotificationAsync(notification);
                await logger.LogInformation("Notification Created {Notification}", notification);
                NavigationManager.NavigateTo(NavigateUrl());
            }
            else
            {
                AddModuleMessage("User Does Not Exist. Please Verify That The Username Provided Is Correct.", MessageType.Warning);
            }
        }
        catch (Exception ex)
        {
            await logger.LogError(ex, "Error Adding Notification {Notification} {Error}", notification, ex.Message);
            AddModuleMessage("Error Adding Notification", MessageType.Error);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

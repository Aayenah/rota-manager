#pragma checksum "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f698423ee370571baa9319299fcb99d286390e89"
// <auto-generated/>
#pragma warning disable 1591
namespace MyRota.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using MyRota;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using MyRota.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Murad\Development\ASP.NET\MyRota\MyRota\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
using MyRota.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    public partial class AssignRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Assign Roles</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-dark");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                       OnOpenDialogButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Show Dialog");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(6);
            __builder.AddAttribute(7, "Width", "300px");
            __builder.AddAttribute(8, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(13);
                __builder2.AddAttribute(14, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenElement(16, "select");
                    __builder3.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                           MyRoles

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MyRoles = __value, MyRoles));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.AddMarkupContent(19, "\r\n");
#nullable restore
#line 18 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                 if (MyRoles != null)
                {
                    foreach (var role in MyRoles)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(20, "                        ");
                    __builder3.OpenElement(21, "option");
                    __builder3.AddAttribute(22, "value", 
#nullable restore
#line 22 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                        role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(23, 
#nullable restore
#line 22 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                               role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n");
#nullable restore
#line 23 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(25, "            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(28);
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(31);
                    __builder3.AddAttribute(32, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                OnDialogButtonClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(33, "Content", "Ok");
                    __builder3.AddAttribute(34, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Admin\AssignRoles.razor"
       
    public bool IsVisible { get; set; } = false;
    public IList<string> MyRoles { get; set; }


    private void OnDialogButtonClick()
    {
        IsVisible = false;
    }

    private void OnOpenDialogButtonClick()
    {
        IsVisible = true;
    }

    private async Task GetRoles(Employee employee)
    {
        var roles = await _userManager.GetRolesAsync(employee);
        MyRoles = roles;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Employee> _userManager { get; set; }
    }
}
#pragma warning restore 1591

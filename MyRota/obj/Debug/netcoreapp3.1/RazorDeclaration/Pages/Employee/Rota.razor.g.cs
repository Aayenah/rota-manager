#pragma checksum "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f712214c8515462c3f82fd727682298a79a4fe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyRota.Pages.Employee
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
#line 3 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using MyRota.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using MyRota.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
           [Authorize(Roles = "Worker")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rota")]
    public partial class Rota : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\Rota.razor"
       
    public Employee Employee { get; set; }
    public List<Shift> ShiftsList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var state = await _authState.GetAuthenticationStateAsync();
        var user = state.User;
        Employee = await _userManager.GetUserAsync(user);
        ShiftsList = Employee.Shifts;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Employee> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Employee> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
    }
}
#pragma warning restore 1591

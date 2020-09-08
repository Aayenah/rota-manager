#pragma checksum "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292a65b406313d77d0058364fb96762a5e80e9d7"
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
#line 3 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using MyRota.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using MyRota.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
using MyRota.SmartEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListEmployees")]
    public partial class ListEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "E:\Murad\Development\ASP.NET\MyRota\MyRota\Pages\Employee\ListEmployees.razor"
       

    private Employee Employee { get; set; }
    public List<Employee> MyList { get; set; }
    public List<IdentityRole> RoleList { get; set; }
    public List<string> EmployeeRoles { get; set; }
    public bool IsVisible { get; set; } = false;
    public string SelectedRole { get; set; }
    public string RolesString { get; set; }

    public DropDownListModel<Gender> GenderModel = new DropDownListModel<Gender>
    {
        Placeholder = "Select Gender",
        DataSource = Enum.GetNames(typeof(Gender)),
    };

    public DropDownListModel<MyRota.SmartEnums.Position> PositionModel = new DropDownListModel<MyRota.SmartEnums.Position>
    {
        Placeholder = "Select Position",
        DataSource = Enum.GetNames(typeof(MyRota.SmartEnums.Position)),
    };

    public DropDownListModel<Branch> BranchModel = new DropDownListModel<Branch>
    {
        Placeholder = "Select Branch",
        DataSource = Enum.GetNames(typeof(Branch)),
    };

    public DatePickerModel DateModel = new DatePickerModel()
    {
        Placeholder = "Select Date",
        Format = "dd/MM/yyyy",
    };

    protected override async Task OnInitializedAsync()
    {
        MyList = await context.Users.ToListAsync<Employee>();
        var roles = await _roleManager.Roles.ToListAsync();
        RoleList = roles;
    }


    private async Task OpenRolesDialog(Employee employee)
    {
        var employeeRoles = await _userManager.GetRolesAsync(employee);
        if (employeeRoles.Count > 0)
        {
            SelectedRole = employeeRoles.ElementAt(0);

            EmployeeRoles = new List<string>(employeeRoles);
        }
        Employee = employee;
        IsVisible = true;
    }

    private async Task OnOkButtonClick()
    {
        IsVisible = false;
        await UpdateEmployee(Employee);
        await UpdateRole(Employee, SelectedRole);
    }

    private void OnCancelButtonClick()
    {
        IsVisible = false;
    }

    private async Task UpdateRole(Employee emp, string role)
    {
        var updateRole = await _userManager.AddToRoleAsync(emp, role);
    }

    private async Task UpdateEmployee(Employee emp)
    {
        var update = await _userManager.UpdateAsync(emp);
        await context.SaveChangesAsync();
    }

    private async Task GetRolesForEmployee(Employee emp)
    {
        var roles = await _userManager.GetRolesAsync(emp);

        string output = "";
        if(roles != null)
        {
            foreach (var role in roles)
            {
                output += role + ", ";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Employee> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
    }
}
#pragma warning restore 1591

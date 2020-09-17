using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRota.Data.Migrations
{
    public partial class AddEmployeePropToShift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shift_AspNetUsers_EmployeeId",
                table: "Shift");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Shift",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_AspNetUsers_EmployeeId",
                table: "Shift",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shift_AspNetUsers_EmployeeId",
                table: "Shift");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Shift",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_AspNetUsers_EmployeeId",
                table: "Shift",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

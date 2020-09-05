using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRota.Data.Migrations
{
    public partial class CreateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e54a077-d70c-42b9-bef7-399384c806cc", "a80c350b-b289-4c95-bca6-31e18ddfcce2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37c678ef-bcda-4453-b86b-a78401cc4f63", "125f305b-827a-45a4-9b30-b2e5d7031b55", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d89e4b92-009c-486e-81fc-0ca68d4d65a4", "702df514-d0fe-4d4d-8d96-4f790caadfc6", "Worker", "WORKER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37c678ef-bcda-4453-b86b-a78401cc4f63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e54a077-d70c-42b9-bef7-399384c806cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d89e4b92-009c-486e-81fc-0ca68d4d65a4");
        }
    }
}

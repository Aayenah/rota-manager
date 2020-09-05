using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRota.Data.Migrations
{
    public partial class CreateUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a3307b99-404e-4d3e-86da-88866d1b0235", "fe7aeeb0-8ec8-4002-99fe-3f752552ae9f", "Admin", "ADMIN" },
                    { "012ebb90-5f2c-41c5-8449-e86e10ff5000", "949f60bd-6e3b-4a4a-8fae-d3da13c6c785", "Manager", "MANAGER" },
                    { "7555f795-bfd9-4428-88cc-2329cecd7295", "6fb49976-9ec8-4cce-ae85-828b4108e235", "Worker", "WORKER" },
                    { "17510007-00fb-4602-8ca1-888a810d3528", "b0890b48-33ba-4cda-8367-26792c38275d", "User", "USER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "012ebb90-5f2c-41c5-8449-e86e10ff5000");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17510007-00fb-4602-8ca1-888a810d3528");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7555f795-bfd9-4428-88cc-2329cecd7295");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3307b99-404e-4d3e-86da-88866d1b0235");

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
    }
}

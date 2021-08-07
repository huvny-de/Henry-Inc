using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Henry_Inc.Data.Migrations
{
    public partial class seed_data_identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "198097c0-6240-4a97-b4c8-7f1f9c3a4422");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39120f6d-d468-45db-8f4c-590f8d16e641", "AQAAAAEAACcQAAAAEFiYSxCX9FPUyHwXkLr3R+JyRkhBEO2QTfdAP1wlBYEUe6xsc4oFKUY6wZ/cHKk1ig==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 7, 9, 28, 19, 712, DateTimeKind.Local).AddTicks(7848));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a7d5b4f8-4772-4d1a-b9da-112398ce4c9c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e80cc56-8080-445e-bc7a-97d2c2efb988", "AQAAAAEAACcQAAAAEBHE4JIX6LaZcgm/Zmmaqjik+PCZzDIxqnmGejpDEvreIksx4wsri07CHA/UT93vtw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 7, 9, 23, 19, 243, DateTimeKind.Local).AddTicks(2627));
        }
    }
}

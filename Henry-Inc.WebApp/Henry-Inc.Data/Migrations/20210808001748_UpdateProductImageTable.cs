using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Henry_Inc.Data.Migrations
{
    public partial class UpdateProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0139c4a0-c4d3-4102-9a84-9cd2b7a5884e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c15728e-1e60-4203-a4bc-04742fb3c97a", "AQAAAAEAACcQAAAAEC/90TCCS+mTrPGuU72v8PZgKvYZoEAh6CJxA3JpW1b/6xf01oZDXjYhyl/QJUpZwA==" });

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
                value: new DateTime(2021, 8, 8, 7, 17, 46, 926, DateTimeKind.Local).AddTicks(9724));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

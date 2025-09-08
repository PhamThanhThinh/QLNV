using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLNV.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 2, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 3, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 4, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 5, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 6, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 7, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 8, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 9, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 10, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 11, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 12, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 13, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 14, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 15, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 16, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 17, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 18, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 19, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 20, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 21, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 22, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 23, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 24, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 25, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 26, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 27, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 28, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 29, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 30, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 31, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 32, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 33, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 34, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 35, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 36, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 37, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 38, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 39, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 40, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 41, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 42, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 43, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 44, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 45, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 46, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 47, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 48, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 49, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" },
                    { 50, 28, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "thịnh", "0123456789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);
        }
    }
}

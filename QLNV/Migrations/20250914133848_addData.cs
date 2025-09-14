using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLNV.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 52, 35, new DateTime(1990, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kỹ Thuật", "Hùng", "0912345678" },
                    { 53, 27, new DateTime(1998, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân Sự", "Mai", "0934567890" },
                    { 54, 33, new DateTime(1992, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "Tuấn", "0976543210" },
                    { 55, 29, new DateTime(1996, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Hạnh", "0901122334" },
                    { 56, 31, new DateTime(1994, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kỹ Thuật", "Sơn", "0988123456" },
                    { 57, 34, new DateTime(1991, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kế Toán", "Vân", "0911765432" },
                    { 58, 32, new DateTime(1993, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân Sự", "Nam", "0923456789" },
                    { 59, 28, new DateTime(1997, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "Ly", "0954321987" },
                    { 60, 26, new DateTime(1999, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Quang", "0965432109" },
                    { 61, 30, new DateTime(1995, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kỹ Thuật", "Nga", "0932112345" },
                    { 62, 36, new DateTime(1989, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kế Toán", "Phong", "0909876543" },
                    { 63, 31, new DateTime(1994, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân Sự", "Thu", "0977334455" },
                    { 64, 33, new DateTime(1992, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "Kiên", "0944556677" },
                    { 65, 29, new DateTime(1996, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Yến", "0911223344" },
                    { 66, 32, new DateTime(1993, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kỹ Thuật", "Đạt", "0988445566" },
                    { 67, 27, new DateTime(1998, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân Sự", "Trang", "0922334455" },
                    { 68, 34, new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kế Toán", "Dũng", "0955667788" },
                    { 69, 35, new DateTime(1990, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Hòa", "0978990011" },
                    { 70, 28, new DateTime(1997, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "Phúc", "0933557799" },
                    { 71, 26, new DateTime(1999, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kỹ Thuật", "Thảo", "0911445566" },
                    { 72, 30, new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kế Toán", "Cường", "0921445566" },
                    { 73, 32, new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân Sự", "Ngọc", "0944667788" },
                    { 74, 33, new DateTime(1992, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Lâm", "0966998877" },
                    { 75, 27, new DateTime(1998, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản Xuất", "Hải", "0907788990" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 75);
        }
    }
}

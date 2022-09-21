using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    public partial class SeedingLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "LeaveTypes");

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "DefaultDays", "Name" },
                values: new object[] { 1, 10, "Vocation" });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "DefaultDays", "Name" },
                values: new object[] { 2, 12, "Sick" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "LeaveTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "LeaveTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hr1.Migrations
{
    public partial class Department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                schema: "humanresources",
                table: "Employees",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                schema: "humanresources",
                table: "Employees",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                schema: "humanresources",
                table: "Employees",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PerformanceScore",
                schema: "humanresources",
                table: "Employees",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                schema: "humanresources",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                schema: "humanresources",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                schema: "humanresources",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PerformanceScore",
                schema: "humanresources",
                table: "Employees");
        }
    }
}

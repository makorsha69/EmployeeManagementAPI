using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Department = table.Column<string>(type: "varchar(15)", nullable: true),
                    DOJ = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowR.Employees.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class MergeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "employees",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "employees",
                table: "employee",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "employees",
                table: "employee",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "employees",
                table: "employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

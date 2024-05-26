using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class taskTable_taskUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskDescription",
                table: "EmployeeTasks");

            migrationBuilder.RenameColumn(
                name: "TaskTitle",
                table: "EmployeeTasks",
                newName: "Task");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Task",
                table: "EmployeeTasks",
                newName: "TaskTitle");

            migrationBuilder.AddColumn<string>(
                name: "TaskDescription",
                table: "EmployeeTasks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

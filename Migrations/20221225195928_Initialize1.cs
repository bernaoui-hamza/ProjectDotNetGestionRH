using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CURDOprationsDimo.Migrations
{
    public partial class Initialize1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUser",
                schema: "HR",
                table: "Employees",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUser",
                schema: "HR",
                table: "Employees",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);
        }
    }
}

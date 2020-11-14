using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganizationX.Migrations
{
    public partial class authmig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Authorization",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Authorization");
        }
    }
}

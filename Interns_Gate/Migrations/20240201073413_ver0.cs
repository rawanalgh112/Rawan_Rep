using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interns_Gate.Migrations
{
    /// <inheritdoc />
    public partial class ver0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tooth_num",
                table: "Clinical_case");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tooth_num",
                table: "Clinical_case",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

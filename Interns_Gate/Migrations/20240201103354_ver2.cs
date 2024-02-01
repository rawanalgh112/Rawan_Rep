using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interns_Gate.Migrations
{
    /// <inheritdoc />
    public partial class ver2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resubmission_reason",
                table: "Clinical_case",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resubmission_reason",
                table: "Clinical_case");
        }
    }
}

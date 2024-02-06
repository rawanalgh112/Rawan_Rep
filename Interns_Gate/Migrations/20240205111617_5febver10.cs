using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interns_Gate.Migrations
{
    /// <inheritdoc />
    public partial class _5febver10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clinical_case");

            migrationBuilder.DropTable(
                name: "clinical_status");

            migrationBuilder.DropTable(
                name: "Intern_cases");

            migrationBuilder.DropTable(
                name: "quality");

            migrationBuilder.DropTable(
                name: "quality_detials");

            migrationBuilder.DropTable(
                name: "quantity");

            migrationBuilder.DropTable(
                name: "Rotation");

            migrationBuilder.DropTable(
                name: "supervisor_intern");

            migrationBuilder.DropTable(
                name: "Teeth");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

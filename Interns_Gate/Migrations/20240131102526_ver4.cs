using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interns_Gate.Migrations
{
    /// <inheritdoc />
    public partial class ver4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sup_fullname",
                table: "supervisor_intern",
                newName: "Sup_fullname");

            migrationBuilder.RenameColumn(
                name: "sup_id",
                table: "supervisor_intern",
                newName: "Sup_id");

            migrationBuilder.RenameColumn(
                name: "rot_name",
                table: "Rotation",
                newName: "Rot_name");

            migrationBuilder.RenameColumn(
                name: "rot_id",
                table: "Rotation",
                newName: "Rot_id");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "quantity",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "quality_detials",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "m_type",
                table: "quality_detials",
                newName: "M_type");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "clinical_status",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "clinical_status",
                newName: "Status_id");

            migrationBuilder.RenameColumn(
                name: "tooth_num",
                table: "Clinical_case",
                newName: "Tooth_num");

            migrationBuilder.RenameColumn(
                name: "sup_id",
                table: "Clinical_case",
                newName: "Sup_Id");

            migrationBuilder.RenameColumn(
                name: "stu_id",
                table: "Clinical_case",
                newName: "Stu_id");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "Clinical_case",
                newName: "Status_id");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Clinical_case",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "rot_id",
                table: "Clinical_case",
                newName: "Rot_id");

            migrationBuilder.RenameColumn(
                name: "patientcode",
                table: "Clinical_case",
                newName: "Patientcode");

            migrationBuilder.RenameColumn(
                name: "measurement_type",
                table: "Clinical_case",
                newName: "Measurement_type");

            migrationBuilder.RenameColumn(
                name: "health_category",
                table: "Clinical_case",
                newName: "Health_category");

            migrationBuilder.RenameColumn(
                name: "evlaution_date",
                table: "Clinical_case",
                newName: "Evlaution_date");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "Clinical_case",
                newName: "End_date");

            migrationBuilder.RenameColumn(
                name: "depratment_id",
                table: "Clinical_case",
                newName: "Depratment_id");

            migrationBuilder.RenameColumn(
                name: "create_date",
                table: "Clinical_case",
                newName: "Create_date");

            migrationBuilder.RenameColumn(
                name: "citizenship",
                table: "Clinical_case",
                newName: "Citizenship");

            migrationBuilder.RenameColumn(
                name: "case_id",
                table: "Clinical_case",
                newName: "Case_id");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Clinical_case",
                newName: "Birth_date");

            migrationBuilder.RenameColumn(
                name: "age_group",
                table: "Clinical_case",
                newName: "Age_group");

            migrationBuilder.RenameColumn(
                name: "accept_date",
                table: "Clinical_case",
                newName: "Accept_date");

            migrationBuilder.RenameColumn(
                name: "stuCase_id",
                table: "Clinical_case",
                newName: "StuCase_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sup_fullname",
                table: "supervisor_intern",
                newName: "sup_fullname");

            migrationBuilder.RenameColumn(
                name: "Sup_id",
                table: "supervisor_intern",
                newName: "sup_id");

            migrationBuilder.RenameColumn(
                name: "Rot_name",
                table: "Rotation",
                newName: "rot_name");

            migrationBuilder.RenameColumn(
                name: "Rot_id",
                table: "Rotation",
                newName: "rot_id");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "quantity",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "quality_detials",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "M_type",
                table: "quality_detials",
                newName: "m_type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clinical_status",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Status_id",
                table: "clinical_status",
                newName: "status_id");

            migrationBuilder.RenameColumn(
                name: "Tooth_num",
                table: "Clinical_case",
                newName: "tooth_num");

            migrationBuilder.RenameColumn(
                name: "Sup_Id",
                table: "Clinical_case",
                newName: "sup_id");

            migrationBuilder.RenameColumn(
                name: "Stu_id",
                table: "Clinical_case",
                newName: "stu_id");

            migrationBuilder.RenameColumn(
                name: "Status_id",
                table: "Clinical_case",
                newName: "status_id");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Clinical_case",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "Rot_id",
                table: "Clinical_case",
                newName: "rot_id");

            migrationBuilder.RenameColumn(
                name: "Patientcode",
                table: "Clinical_case",
                newName: "patientcode");

            migrationBuilder.RenameColumn(
                name: "Measurement_type",
                table: "Clinical_case",
                newName: "measurement_type");

            migrationBuilder.RenameColumn(
                name: "Health_category",
                table: "Clinical_case",
                newName: "health_category");

            migrationBuilder.RenameColumn(
                name: "Evlaution_date",
                table: "Clinical_case",
                newName: "evlaution_date");

            migrationBuilder.RenameColumn(
                name: "End_date",
                table: "Clinical_case",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "Depratment_id",
                table: "Clinical_case",
                newName: "depratment_id");

            migrationBuilder.RenameColumn(
                name: "Create_date",
                table: "Clinical_case",
                newName: "create_date");

            migrationBuilder.RenameColumn(
                name: "Citizenship",
                table: "Clinical_case",
                newName: "citizenship");

            migrationBuilder.RenameColumn(
                name: "Case_id",
                table: "Clinical_case",
                newName: "case_id");

            migrationBuilder.RenameColumn(
                name: "Birth_date",
                table: "Clinical_case",
                newName: "birth_date");

            migrationBuilder.RenameColumn(
                name: "Age_group",
                table: "Clinical_case",
                newName: "age_group");

            migrationBuilder.RenameColumn(
                name: "Accept_date",
                table: "Clinical_case",
                newName: "accept_date");

            migrationBuilder.RenameColumn(
                name: "StuCase_id",
                table: "Clinical_case",
                newName: "stuCase_id");
        }
    }
}

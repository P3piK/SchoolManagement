using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Persistance.Migrations
{
    public partial class AddStudentIdTutorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserFK",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserFK",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CodeGenerationDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserFK",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginDate",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntryCode",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EntryCodeDate",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutorFK",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TutorFK",
                table: "Courses",
                column: "TutorFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_TutorFK",
                table: "Courses",
                column: "TutorFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_TutorFK",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TutorFK",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BeginDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EntryCode",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EntryCodeDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TutorFK",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeGenerationDate",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserFK",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserFK",
                table: "Courses",
                column: "UserFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserFK",
                table: "Courses",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

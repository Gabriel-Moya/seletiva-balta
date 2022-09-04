using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessoSeletivo.Data.Migrations
{
    public partial class FixMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseId1",
                table: "Modules",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModuleId1",
                table: "Lessons",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId1",
                table: "Modules",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ModuleId1",
                table: "Lessons",
                column: "ModuleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Modules_ModuleId1",
                table: "Lessons",
                column: "ModuleId1",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Courses_CourseId1",
                table: "Modules",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Modules_ModuleId1",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Courses_CourseId1",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_CourseId1",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_ModuleId1",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ModuleId1",
                table: "Lessons");
        }
    }
}

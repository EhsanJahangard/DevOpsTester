using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class createRelationShipPerson_Skill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "PersonSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SkillId",
                table: "PersonSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkills_PersonId",
                table: "PersonSkills",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkills_SkillId",
                table: "PersonSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonSkills_People_PersonId",
                table: "PersonSkills",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonSkills_Skills_SkillId",
                table: "PersonSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonSkills_People_PersonId",
                table: "PersonSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonSkills_Skills_SkillId",
                table: "PersonSkills");

            migrationBuilder.DropIndex(
                name: "IX_PersonSkills_PersonId",
                table: "PersonSkills");

            migrationBuilder.DropIndex(
                name: "IX_PersonSkills_SkillId",
                table: "PersonSkills");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PersonSkills");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "PersonSkills");
        }
    }
}

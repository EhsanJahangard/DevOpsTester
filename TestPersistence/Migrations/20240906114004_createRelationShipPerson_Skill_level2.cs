using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class createRelationShipPerson_Skill_level2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LevelId",
                table: "PersonSkills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonSkills_LevelId",
                table: "PersonSkills",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonSkills_Levels_LevelId",
                table: "PersonSkills",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonSkills_Levels_LevelId",
                table: "PersonSkills");

            migrationBuilder.DropIndex(
                name: "IX_PersonSkills_LevelId",
                table: "PersonSkills");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "PersonSkills");
        }
    }
}

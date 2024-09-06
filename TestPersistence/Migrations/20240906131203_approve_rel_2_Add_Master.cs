using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_rel_2_Add_Master : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LengthTest",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "People",
                newName: "DateBirth");

            migrationBuilder.AddColumn<byte>(
                name: "LengthMinuteTest",
                table: "Tests",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MasterId",
                table: "Tests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExam",
                table: "TestResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestResults",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "TestResults",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "TestResults",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TestId",
                table: "TestResults",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CodeMeli",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Master",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleBio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Years_Experience = table.Column<byte>(type: "tinyint", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_MasterId",
                table: "Tests",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_PersonId",
                table: "TestResults",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_People_PersonId",
                table: "TestResults",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_Tests_TestId",
                table: "TestResults",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Master_MasterId",
                table: "Tests",
                column: "MasterId",
                principalTable: "Master",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_People_PersonId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_Tests_TestId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Master_MasterId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "Master");

            migrationBuilder.DropIndex(
                name: "IX_Tests_MasterId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_PersonId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "LengthMinuteTest",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "MasterId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "DateExam",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "CodeMeli",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "DateBirth",
                table: "People",
                newName: "Age");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "LengthTest",
                table: "Tests",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}

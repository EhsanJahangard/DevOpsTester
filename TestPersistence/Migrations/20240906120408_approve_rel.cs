using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_rel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTest",
                table: "Tests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirtionTest",
                table: "Tests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "LengthTest",
                table: "Tests",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeTest",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "LevelId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionTypeId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId",
                table: "QuestionPhotos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "QuestionPhotos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId",
                table: "QuestionOptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "TitleQuestionOption",
                table: "QuestionOptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "QuestionQuestionPhoto",
                columns: table => new
                {
                    QuestionPhotosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionQuestionPhoto", x => new { x.QuestionPhotosId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_QuestionQuestionPhoto_QuestionPhotos_QuestionPhotosId",
                        column: x => x.QuestionPhotosId,
                        principalTable: "QuestionPhotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionQuestionPhoto_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestQuestions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_LevelId",
                table: "Questions",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionQuestionPhoto_QuestionsId",
                table: "QuestionQuestionPhoto",
                column: "QuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestions_QuestionId",
                table: "TestQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestions_TestId",
                table: "TestQuestions",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Levels_LevelId",
                table: "Questions",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Levels_LevelId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionQuestionPhoto");

            migrationBuilder.DropTable(
                name: "TestQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_LevelId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropColumn(
                name: "DateTest",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ExpirtionTest",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "LengthTest",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TypeTest",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "QuestionPhotos");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "QuestionPhotos");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropColumn(
                name: "TitleQuestionOption",
                table: "QuestionOptions");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Photos");
        }
    }
}

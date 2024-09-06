using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_name_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Master_MasterId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Master",
                table: "Master");

            migrationBuilder.RenameTable(
                name: "Master",
                newName: "Masters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Masters",
                table: "Masters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Masters_MasterId",
                table: "Tests",
                column: "MasterId",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Masters_MasterId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Masters",
                table: "Masters");

            migrationBuilder.RenameTable(
                name: "Masters",
                newName: "Master");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Master",
                table: "Master",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Master_MasterId",
                table: "Tests",
                column: "MasterId",
                principalTable: "Master",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

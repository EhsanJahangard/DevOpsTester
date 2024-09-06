using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_Seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DeleteData(
                table: "Masters",
                keyColumn: "Id",
                keyValue: new Guid("72a755c3-38d6-4e93-8202-6f4350beb48c"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("4a73d374-4c72-452e-aa85-4b02f28f0032"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("a8580d00-caec-4883-b9de-8fd58dbbc0c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("86dc11a5-631f-4250-af8e-d17054521eb4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fd8f1a6c-d3c3-4f80-9b0e-4fa53d19ef06"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("092bda49-5756-4eac-bd91-58245e75d221"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("108fce8a-866c-4e1d-b8f1-13fb3b0cd34b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("12809efc-7cd3-4e2f-9973-d2c8776a2060"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1ff24aac-f94f-453c-9d58-dcc8ca74f16e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("307793f0-3d0d-4abd-ab5a-d6685f606fae"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3abd8797-9227-40b7-b09a-cf7aea5acd6a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3b9c246e-bc6e-49c9-8852-d824a1288ff0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("544d45f1-6f3c-4409-9e48-c79f98b4738a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("612ee372-4366-4397-bc36-f3b10a9c4154"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("62df7083-ad8e-4f2c-8b4c-2065e8c54221"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6b762ba1-ab17-4858-b29c-e59cedf49961"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6bdff42b-bbba-4f95-b1f4-530eed817de5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("766542fd-f263-4a31-9c69-9eaee6ca0f6d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("86c78807-5994-43a5-b008-f1d160b33675"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("99700a6b-63d6-4f3b-916b-5792f71685af"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9ba525d9-ce81-4425-88b5-9dc096488284"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a023a41c-58e0-43f9-b033-b4e9f2ef0c20"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a4b5fa85-0f1a-4be9-b442-62031816d82d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a88c3bc4-3ee9-432f-a02a-802558e39d4d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bc0778cc-1a0b-4dce-a70d-c7ba72b7f6d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cb59fe2d-db1b-420e-8bf3-589533d99a47"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d2165045-ff55-49ff-ad70-84fbeae5d2b8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("de2e18a7-486b-4c9d-b845-392485a9f84a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eccfa4e4-8369-4ab1-91ec-05db66adb046"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ed8e9dea-3418-45cb-842d-f00468f7ab8a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f2cb381c-8b8b-4485-8fc7-1526a1341b39"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fa261a19-e2da-4e2e-bd90-8b1a3a743abc"));

            migrationBuilder.CreateTable(
                name: "QuestionQuestionOption",
                columns: table => new
                {
                    QuestionOptionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionQuestionOption", x => new { x.QuestionOptionsId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_QuestionQuestionOption_QuestionOptions_QuestionOptionsId",
                        column: x => x.QuestionOptionsId,
                        principalTable: "QuestionOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionQuestionOption_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Masters",
                columns: new[] { "Id", "Bio", "DateBirth", "DateCreate", "DateUpdate", "Degree", "Family", "Mobile", "Name", "Photo", "TitleBio", "UserCreate", "UserUpdate", "Website", "Years_Experience" },
                values: new object[] { new Guid("e2beac5e-3b84-4921-a7a4-bded9a2d4e5a"), "Master", new DateTime(2024, 9, 6, 19, 47, 13, 308, DateTimeKind.Local).AddTicks(8676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"),
                column: "DateBirth",
                value: new DateTime(1989, 9, 6, 19, 47, 13, 308, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"),
                column: "DateBirth",
                value: new DateTime(1979, 9, 6, 19, 47, 13, 308, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.InsertData(
                table: "PersonSkills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "LevelId", "PersonId", "SkillId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("3edd9ad8-9465-48fc-b7af-3bf4de2464f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), "", "" },
                    { new Guid("e3def328-bf3a-4327-85d8-60d0dce4657f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "DateCreate", "DateUpdate", "Letter", "LevelId", "QuestionTypeId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("051f3286-6406-4d8c-82ef-16caa80140b2"), "Container Framework", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker چیست؟", new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" },
                    { new Guid("5303886f-df49-4ee9-bf0d-27c9f11c39b6"), "Container Orchestration Open-Source", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes چیست؟", new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("062fabb3-6729-478c-8b7c-43933cebf36d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("0a1c37e4-a38d-4642-aa8e-2999bb2aa062"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "C#", "", "" },
                    { new Guid("103ed4c5-4160-4527-9499-a97fe9dab8b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Go Lang", "", "" },
                    { new Guid("10896395-beb0-49cd-97a4-8089380a7edb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("12677513-3295-4afb-8bc0-9fd4dfc36a18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Redis", "", "" },
                    { new Guid("12cf1ab0-b4c9-47f8-876c-616accdd9004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "DNS", "", "" },
                    { new Guid("1b2cc567-8c5c-4e39-9918-48dd40899c0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Sql Server", "", "" },
                    { new Guid("2ea3c756-24b1-4350-8916-081eef7329a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" },
                    { new Guid("3c00cc44-fb39-4512-b79a-820bf28b388e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ArgoCD", "", "" },
                    { new Guid("3cfa8590-3964-4d39-a25b-0dff8fd42a45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZeroMQ", "", "" },
                    { new Guid("3f543b68-af95-4bfb-a420-100a6b990808"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ceph Storage", "", "" },
                    { new Guid("4be54c77-5e24-49c8-a3d6-cac5b9dde00b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("5240333c-8dd3-49b3-ba1c-59bb97c611a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("5af213ec-e8a8-41ab-a567-ec97dbc1e803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ocelot", "", "" },
                    { new Guid("620504a4-1649-4c64-87f0-86d3e3fea414"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("6b9add0d-9f3b-44b5-8bbe-fdea8ff2ee7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("7f62bb44-726f-41c0-9209-be35ea972ce2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("89222059-1c5b-44fe-b809-0cd788ff3f68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "PostgreSql", "", "" },
                    { new Guid("9da20d00-d0fb-4d31-9e2b-165a2785d421"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Asp.Net", "", "" },
                    { new Guid("b16bbed2-6945-482f-8d9e-b420795c83ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "RabbitMQ", "", "" },
                    { new Guid("be193c54-9448-41d5-8e82-b439a2ce6c85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("bf58a0f5-d926-45c0-8ed8-a7e7ab94b3b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("d333e218-22ae-4077-9111-14b7ab0db287"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kong", "", "" },
                    { new Guid("d85aedd4-594a-41b2-a849-2901a74050d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ActiveMQ", "", "" },
                    { new Guid("f12e9e2a-75b5-4273-8f2e-23ca06211bb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CleanCode", "", "" },
                    { new Guid("f607bbca-fba9-4199-b7cb-c48c3fec6c48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("fb053d4d-0f95-444a-bf98-09062320a941"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionQuestionOption_QuestionsId",
                table: "QuestionQuestionOption",
                column: "QuestionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionQuestionOption");

            migrationBuilder.DeleteData(
                table: "Masters",
                keyColumn: "Id",
                keyValue: new Guid("e2beac5e-3b84-4921-a7a4-bded9a2d4e5a"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("3edd9ad8-9465-48fc-b7af-3bf4de2464f8"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("e3def328-bf3a-4327-85d8-60d0dce4657f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("051f3286-6406-4d8c-82ef-16caa80140b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5303886f-df49-4ee9-bf0d-27c9f11c39b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("062fabb3-6729-478c-8b7c-43933cebf36d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0a1c37e4-a38d-4642-aa8e-2999bb2aa062"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("103ed4c5-4160-4527-9499-a97fe9dab8b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("10896395-beb0-49cd-97a4-8089380a7edb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("12677513-3295-4afb-8bc0-9fd4dfc36a18"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("12cf1ab0-b4c9-47f8-876c-616accdd9004"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1b2cc567-8c5c-4e39-9918-48dd40899c0b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2ea3c756-24b1-4350-8916-081eef7329a2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3c00cc44-fb39-4512-b79a-820bf28b388e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3cfa8590-3964-4d39-a25b-0dff8fd42a45"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3f543b68-af95-4bfb-a420-100a6b990808"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4be54c77-5e24-49c8-a3d6-cac5b9dde00b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5240333c-8dd3-49b3-ba1c-59bb97c611a3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5af213ec-e8a8-41ab-a567-ec97dbc1e803"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("620504a4-1649-4c64-87f0-86d3e3fea414"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6b9add0d-9f3b-44b5-8bbe-fdea8ff2ee7b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7f62bb44-726f-41c0-9209-be35ea972ce2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("89222059-1c5b-44fe-b809-0cd788ff3f68"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9da20d00-d0fb-4d31-9e2b-165a2785d421"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b16bbed2-6945-482f-8d9e-b420795c83ff"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("be193c54-9448-41d5-8e82-b439a2ce6c85"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bf58a0f5-d926-45c0-8ed8-a7e7ab94b3b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d333e218-22ae-4077-9111-14b7ab0db287"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d85aedd4-594a-41b2-a849-2901a74050d7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f12e9e2a-75b5-4273-8f2e-23ca06211bb2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f607bbca-fba9-4199-b7cb-c48c3fec6c48"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fb053d4d-0f95-444a-bf98-09062320a941"));

            migrationBuilder.InsertData(
                table: "Masters",
                columns: new[] { "Id", "Bio", "DateBirth", "DateCreate", "DateUpdate", "Degree", "Family", "Mobile", "Name", "Photo", "TitleBio", "UserCreate", "UserUpdate", "Website", "Years_Experience" },
                values: new object[] { new Guid("72a755c3-38d6-4e93-8202-6f4350beb48c"), "Master", new DateTime(2024, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1545), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"),
                column: "DateBirth",
                value: new DateTime(1989, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"),
                column: "DateBirth",
                value: new DateTime(1979, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.InsertData(
                table: "PersonSkills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "LevelId", "PersonId", "SkillId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("4a73d374-4c72-452e-aa85-4b02f28f0032"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), "", "" },
                    { new Guid("a8580d00-caec-4883-b9de-8fd58dbbc0c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "DateCreate", "DateUpdate", "Letter", "LevelId", "QuestionTypeId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("86dc11a5-631f-4250-af8e-d17054521eb4"), "Container Orchestration Open-Source", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes چیست؟", new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" },
                    { new Guid("fd8f1a6c-d3c3-4f80-9b0e-4fa53d19ef06"), "Container Framework", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker چیست؟", new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("092bda49-5756-4eac-bd91-58245e75d221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" },
                    { new Guid("108fce8a-866c-4e1d-b8f1-13fb3b0cd34b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("12809efc-7cd3-4e2f-9973-d2c8776a2060"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("1ff24aac-f94f-453c-9d58-dcc8ca74f16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("307793f0-3d0d-4abd-ab5a-d6685f606fae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("3abd8797-9227-40b7-b09a-cf7aea5acd6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("3b9c246e-bc6e-49c9-8852-d824a1288ff0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("544d45f1-6f3c-4409-9e48-c79f98b4738a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("612ee372-4366-4397-bc36-f3b10a9c4154"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("62df7083-ad8e-4f2c-8b4c-2065e8c54221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" },
                    { new Guid("6b762ba1-ab17-4858-b29c-e59cedf49961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("6bdff42b-bbba-4f95-b1f4-530eed817de5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("766542fd-f263-4a31-9c69-9eaee6ca0f6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Go Lang", "", "" },
                    { new Guid("86c78807-5994-43a5-b008-f1d160b33675"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Asp.Net", "", "" },
                    { new Guid("99700a6b-63d6-4f3b-916b-5792f71685af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "PostgreSql", "", "" },
                    { new Guid("9ba525d9-ce81-4425-88b5-9dc096488284"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ocelot", "", "" },
                    { new Guid("a023a41c-58e0-43f9-b033-b4e9f2ef0c20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Redis", "", "" },
                    { new Guid("a4b5fa85-0f1a-4be9-b442-62031816d82d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZeroMQ", "", "" },
                    { new Guid("a88c3bc4-3ee9-432f-a02a-802558e39d4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "C#", "", "" },
                    { new Guid("bc0778cc-1a0b-4dce-a70d-c7ba72b7f6d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ActiveMQ", "", "" },
                    { new Guid("cb59fe2d-db1b-420e-8bf3-589533d99a47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CleanCode", "", "" },
                    { new Guid("d2165045-ff55-49ff-ad70-84fbeae5d2b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ArgoCD", "", "" },
                    { new Guid("de2e18a7-486b-4c9d-b845-392485a9f84a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "DNS", "", "" },
                    { new Guid("eccfa4e4-8369-4ab1-91ec-05db66adb046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "RabbitMQ", "", "" },
                    { new Guid("ed8e9dea-3418-45cb-842d-f00468f7ab8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ceph Storage", "", "" },
                    { new Guid("f2cb381c-8b8b-4485-8fc7-1526a1341b39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Sql Server", "", "" },
                    { new Guid("fa261a19-e2da-4e2e-bd90-8b1a3a743abc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kong", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

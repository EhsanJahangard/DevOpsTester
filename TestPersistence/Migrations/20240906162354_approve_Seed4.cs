using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_Seed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionQuestionOption");

            migrationBuilder.DropTable(
                name: "QuestionQuestionPhoto");

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
                values: new object[] { new Guid("8fb1408c-1f28-422b-b0ce-69e8aef9611b"), "Master", new DateTime(2024, 9, 6, 19, 53, 53, 905, DateTimeKind.Local).AddTicks(9931), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"),
                column: "DateBirth",
                value: new DateTime(1989, 9, 6, 19, 53, 53, 906, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"),
                column: "DateBirth",
                value: new DateTime(1979, 9, 6, 19, 53, 53, 906, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.InsertData(
                table: "PersonSkills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "LevelId", "PersonId", "SkillId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("1b14911a-73d9-4b42-a5e0-c307e360efd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), "", "" },
                    { new Guid("5cbe6523-1540-4bc4-98a9-f11cdcd7260b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "DateCreate", "DateUpdate", "Letter", "LevelId", "QuestionTypeId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("119c886a-bc09-4f01-b476-bf2363eabdde"), "Container Orchestration Open-Source", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes چیست؟", new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" },
                    { new Guid("62879c4e-b8d8-4652-9ddf-5162a6d2bd16"), "Container Framework", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker چیست؟", new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("04f77879-9966-492c-914b-f2b6ecfa8a09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kong", "", "" },
                    { new Guid("190a8cbe-e135-4ead-834a-a533bab0fa51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "PostgreSql", "", "" },
                    { new Guid("1d32f4c4-695d-42b0-a886-c1e3f88854a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("2635e7f8-d75b-485a-a70f-1fc6858b03bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZeroMQ", "", "" },
                    { new Guid("2db71269-0235-4a62-8dbf-ceda8608f06e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CleanCode", "", "" },
                    { new Guid("2e201b93-6f43-401f-a7ad-99f76a00593d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("2fd785e3-a912-4943-848a-8373c462e271"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("308bb5d5-f717-457f-beed-fe926a58e18a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "DNS", "", "" },
                    { new Guid("313f7248-eafa-4a26-999a-edf6749cbb2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("3b7ce7ab-babf-41ad-acd5-3f0f776bf62a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("3f55bd78-45d8-44d6-b055-972c686fc9ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" },
                    { new Guid("3f87c5a0-7127-4e04-bf76-fbf447365fe6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "RabbitMQ", "", "" },
                    { new Guid("4be71da9-f932-498c-9b44-b8d3e046b333"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Redis", "", "" },
                    { new Guid("591a491a-235b-4851-8ad3-8b5a5095e7b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ceph Storage", "", "" },
                    { new Guid("6003b635-8f45-436c-93fa-6012d83963f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("69cc9264-41de-4911-9105-ce4c366ff5cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ocelot", "", "" },
                    { new Guid("6ba3e676-0d82-43a3-8a20-c092cf567d85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Sql Server", "", "" },
                    { new Guid("7c7eff4d-209e-40d2-887e-5abe2816dd6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ArgoCD", "", "" },
                    { new Guid("829859b4-f195-4266-a6a7-eb0017165c1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Asp.Net", "", "" },
                    { new Guid("839e9078-fcea-4256-a259-e8e27273a979"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("8ed9f8bd-d991-4dac-bfb7-5b1fc5a4938a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Go Lang", "", "" },
                    { new Guid("918baa7e-9be9-4271-82b8-86c6403ce29e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("9cdd13dd-d2b2-4deb-84e5-985e2ce76e0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("9dcc2ad8-cad2-4224-9e04-88dba5bfe3b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ActiveMQ", "", "" },
                    { new Guid("aeadba77-7429-493d-8d2b-a020e94de356"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "C#", "", "" },
                    { new Guid("c0dd0e75-ccc1-4915-87da-2f91137f5b65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("f7e00ee8-3f33-483d-bca5-18a679f146ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionPhotos_QuestionId",
                table: "QuestionPhotos",
                column: "QuestionId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionPhotos_Questions_QuestionId",
                table: "QuestionPhotos",
                column: "QuestionId",
                principalTable: "Questions",
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
                name: "FK_QuestionPhotos_Questions_QuestionId",
                table: "QuestionPhotos");

            migrationBuilder.DropIndex(
                name: "IX_QuestionPhotos_QuestionId",
                table: "QuestionPhotos");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DeleteData(
                table: "Masters",
                keyColumn: "Id",
                keyValue: new Guid("8fb1408c-1f28-422b-b0ce-69e8aef9611b"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("1b14911a-73d9-4b42-a5e0-c307e360efd6"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("5cbe6523-1540-4bc4-98a9-f11cdcd7260b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("119c886a-bc09-4f01-b476-bf2363eabdde"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("62879c4e-b8d8-4652-9ddf-5162a6d2bd16"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("04f77879-9966-492c-914b-f2b6ecfa8a09"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("190a8cbe-e135-4ead-834a-a533bab0fa51"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1d32f4c4-695d-42b0-a886-c1e3f88854a5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2635e7f8-d75b-485a-a70f-1fc6858b03bf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2db71269-0235-4a62-8dbf-ceda8608f06e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2e201b93-6f43-401f-a7ad-99f76a00593d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2fd785e3-a912-4943-848a-8373c462e271"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("308bb5d5-f717-457f-beed-fe926a58e18a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("313f7248-eafa-4a26-999a-edf6749cbb2e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3b7ce7ab-babf-41ad-acd5-3f0f776bf62a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3f55bd78-45d8-44d6-b055-972c686fc9ba"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3f87c5a0-7127-4e04-bf76-fbf447365fe6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4be71da9-f932-498c-9b44-b8d3e046b333"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("591a491a-235b-4851-8ad3-8b5a5095e7b0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6003b635-8f45-436c-93fa-6012d83963f1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("69cc9264-41de-4911-9105-ce4c366ff5cc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6ba3e676-0d82-43a3-8a20-c092cf567d85"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7c7eff4d-209e-40d2-887e-5abe2816dd6c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("829859b4-f195-4266-a6a7-eb0017165c1a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("839e9078-fcea-4256-a259-e8e27273a979"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8ed9f8bd-d991-4dac-bfb7-5b1fc5a4938a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("918baa7e-9be9-4271-82b8-86c6403ce29e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9cdd13dd-d2b2-4deb-84e5-985e2ce76e0f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9dcc2ad8-cad2-4224-9e04-88dba5bfe3b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("aeadba77-7429-493d-8d2b-a020e94de356"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c0dd0e75-ccc1-4915-87da-2f91137f5b65"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f7e00ee8-3f33-483d-bca5-18a679f146ec"));

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

            migrationBuilder.CreateIndex(
                name: "IX_QuestionQuestionPhoto_QuestionsId",
                table: "QuestionQuestionPhoto",
                column: "QuestionsId");
        }
    }
}

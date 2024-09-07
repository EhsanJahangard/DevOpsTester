using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_rel_Question_Photo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "PhotoId",
                table: "QuestionPhotos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Masters",
                columns: new[] { "Id", "Bio", "DateBirth", "DateCreate", "DateUpdate", "Degree", "Family", "Mobile", "Name", "Photo", "TitleBio", "UserCreate", "UserUpdate", "Website", "Years_Experience" },
                values: new object[] { new Guid("6c109b77-a9e3-4aec-88a6-49926687a2e1"), "Master", new DateTime(2024, 9, 7, 16, 32, 36, 614, DateTimeKind.Local).AddTicks(9329), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"),
                column: "DateBirth",
                value: new DateTime(1989, 9, 7, 16, 32, 36, 614, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"),
                column: "DateBirth",
                value: new DateTime(1979, 9, 7, 16, 32, 36, 614, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.InsertData(
                table: "PersonSkills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "LevelId", "PersonId", "SkillId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("b835ef9a-2e84-4d49-8fc4-fa18f7fc6f22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), "", "" },
                    { new Guid("d31b55ae-7f91-4d95-bd1a-93d4e96959e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "DateCreate", "DateUpdate", "Letter", "LevelId", "QuestionTypeId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("5a214d40-9b96-40f7-8de4-68db6cfbbd35"), "Container Orchestration Open-Source", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes چیست؟", new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" },
                    { new Guid("6807937f-3853-4a48-ab59-83ee0cb8bc62"), "Container Framework", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker چیست؟", new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("0ea68f86-62a5-4789-82d1-dbe6b29bfc28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Go Lang", "", "" },
                    { new Guid("154ff84f-ef0c-49e1-ad26-3d0ec5716856"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ceph Storage", "", "" },
                    { new Guid("18d1a7f5-4b79-4e5f-a9ac-2b1c7b86fab7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" },
                    { new Guid("29fd505c-fae4-4924-acdd-74c371026924"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("2a1686f1-3165-4750-9a1f-8495efc5b25e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ArgoCD", "", "" },
                    { new Guid("2c532717-d81e-4e06-a52f-8d9cc3ca8abd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("344d3188-3727-4b89-b48a-b902efab6605"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("350d4bd0-61d9-49be-a876-e28407723981"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Sql Server", "", "" },
                    { new Guid("3a63fe47-3f28-405b-ba1d-a2bb5d7b2ae4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" },
                    { new Guid("405de160-8ffb-4e2e-be48-a6f65b90a6a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CleanCode", "", "" },
                    { new Guid("4b69dcbb-043a-47cb-887b-774cb8668269"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("4e7f3e87-275b-4e38-baea-86cb147c6539"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("58ec420e-5c47-427e-b5b2-8dfa7a403c02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("5d35b719-9923-475d-bb9c-81c1aa18bac4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("6690ad41-fd3e-4145-871d-a656172102ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Asp.Net", "", "" },
                    { new Guid("679e6e61-b07f-40b9-9cf4-3650b28c7d75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kong", "", "" },
                    { new Guid("7aead200-c36f-457b-a208-bd14e18e8d25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZeroMQ", "", "" },
                    { new Guid("85d89b8e-1664-43f6-97ff-6e119fbeb31c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("8dec163b-9d65-4007-9e98-27e60efd1a92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("94c1705f-d0de-42fc-9179-8ce40e4140c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "C#", "", "" },
                    { new Guid("a37d8c2c-c1c5-4a4b-84da-0f24c235d20d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "PostgreSql", "", "" },
                    { new Guid("a409b1f6-bc89-4fd3-8d34-8bc616aff9d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ocelot", "", "" },
                    { new Guid("b65903a3-7a5f-4e5f-90d6-4064787921de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("b729985d-3cd9-45e0-924d-1484442136aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "DNS", "", "" },
                    { new Guid("b82d0a45-b019-4a09-820f-d832d88d8a87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Redis", "", "" },
                    { new Guid("d25519f5-df5e-457a-bf46-b05b71c7649a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "RabbitMQ", "", "" },
                    { new Guid("e9f915da-7a3c-4168-9b54-9d3173f37a4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ActiveMQ", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionPhotos_PhotoId",
                table: "QuestionPhotos",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionPhotos_Photos_PhotoId",
                table: "QuestionPhotos",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionPhotos_Photos_PhotoId",
                table: "QuestionPhotos");

            migrationBuilder.DropIndex(
                name: "IX_QuestionPhotos_PhotoId",
                table: "QuestionPhotos");

            migrationBuilder.DeleteData(
                table: "Masters",
                keyColumn: "Id",
                keyValue: new Guid("6c109b77-a9e3-4aec-88a6-49926687a2e1"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("b835ef9a-2e84-4d49-8fc4-fa18f7fc6f22"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("d31b55ae-7f91-4d95-bd1a-93d4e96959e9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5a214d40-9b96-40f7-8de4-68db6cfbbd35"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6807937f-3853-4a48-ab59-83ee0cb8bc62"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0ea68f86-62a5-4789-82d1-dbe6b29bfc28"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("154ff84f-ef0c-49e1-ad26-3d0ec5716856"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("18d1a7f5-4b79-4e5f-a9ac-2b1c7b86fab7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("29fd505c-fae4-4924-acdd-74c371026924"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2a1686f1-3165-4750-9a1f-8495efc5b25e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2c532717-d81e-4e06-a52f-8d9cc3ca8abd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("344d3188-3727-4b89-b48a-b902efab6605"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("350d4bd0-61d9-49be-a876-e28407723981"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3a63fe47-3f28-405b-ba1d-a2bb5d7b2ae4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("405de160-8ffb-4e2e-be48-a6f65b90a6a8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4b69dcbb-043a-47cb-887b-774cb8668269"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4e7f3e87-275b-4e38-baea-86cb147c6539"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("58ec420e-5c47-427e-b5b2-8dfa7a403c02"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5d35b719-9923-475d-bb9c-81c1aa18bac4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6690ad41-fd3e-4145-871d-a656172102ea"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("679e6e61-b07f-40b9-9cf4-3650b28c7d75"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7aead200-c36f-457b-a208-bd14e18e8d25"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("85d89b8e-1664-43f6-97ff-6e119fbeb31c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8dec163b-9d65-4007-9e98-27e60efd1a92"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("94c1705f-d0de-42fc-9179-8ce40e4140c7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a37d8c2c-c1c5-4a4b-84da-0f24c235d20d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a409b1f6-bc89-4fd3-8d34-8bc616aff9d2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b65903a3-7a5f-4e5f-90d6-4064787921de"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b729985d-3cd9-45e0-924d-1484442136aa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b82d0a45-b019-4a09-820f-d832d88d8a87"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d25519f5-df5e-457a-bf46-b05b71c7649a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e9f915da-7a3c-4168-9b54-9d3173f37a4a"));

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "QuestionPhotos");

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
        }
    }
}

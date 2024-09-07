using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_rel_Question_Photo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Masters",
                columns: new[] { "Id", "Bio", "DateBirth", "DateCreate", "DateUpdate", "Degree", "Family", "Mobile", "Name", "Photo", "TitleBio", "UserCreate", "UserUpdate", "Website", "Years_Experience" },
                values: new object[] { new Guid("79a3fba0-98e6-4fd9-8e8d-70e8c401c801"), "Master", new DateTime(2024, 9, 7, 16, 43, 16, 466, DateTimeKind.Local).AddTicks(1542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"),
                column: "DateBirth",
                value: new DateTime(1989, 9, 7, 16, 43, 16, 466, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"),
                column: "DateBirth",
                value: new DateTime(1979, 9, 7, 16, 43, 16, 466, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.InsertData(
                table: "PersonSkills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "LevelId", "PersonId", "SkillId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("4cd0c4ff-5266-4d3b-b729-00172bc56899"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), "", "" },
                    { new Guid("c3536b3c-e541-464f-b847-d454888f1fa1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "DateCreate", "DateUpdate", "Letter", "LevelId", "QuestionTypeId", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("535e27f3-0c48-4e0f-9bff-bce4baa57d0f"), "Container Framework", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Docker چیست؟", new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" },
                    { new Guid("e9fbdfb2-3997-422a-ae48-3b9fd120c9d9"), "Container Orchestration Open-Source", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubernetes چیست؟", new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("06216d41-2073-4d20-a085-ffc5b705a54c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("070b6d9b-aa52-4715-a1ab-1b4f8d1790e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZeroMQ", "", "" },
                    { new Guid("113dab3c-312e-4e9b-a01b-f9edbeb94962"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ocelot", "", "" },
                    { new Guid("1b5acb4f-026e-4bbc-bce1-6b72bdd2d10e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "RabbitMQ", "", "" },
                    { new Guid("29e83f97-d80e-4315-b799-918d384877bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Redis", "", "" },
                    { new Guid("40acffdd-175e-4a5a-a6f3-f9127e32ec54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("436d2dde-7c31-45bf-bdcb-495861d32f81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kong", "", "" },
                    { new Guid("45615062-1809-4139-b44f-68941dd60b6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("486584be-2d40-443a-9eb7-9f302a24be6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Go Lang", "", "" },
                    { new Guid("50d7c92c-d87d-4e84-b116-f4416519373e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("5faa0da6-bfba-47a3-ac68-4452e03ff53b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("6551739e-4d5a-45ff-8f64-6341ca541373"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("6e7e5e95-eeea-4329-a1d5-7dccfe1efe8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("70435c6c-8fa5-4dd9-9354-d4cdc4840376"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("70e6af84-4504-48c1-91fa-e5d831e929f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "PostgreSql", "", "" },
                    { new Guid("782fa74c-7a70-4750-914a-164ef3074820"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("82f558df-2dfa-4ca5-bcf6-64df6705029f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CleanCode", "", "" },
                    { new Guid("8da41d43-4e15-4427-855e-cc2979180b98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "C#", "", "" },
                    { new Guid("8fc331c9-b09e-4ceb-821a-c8636eaa3a2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("a00ca400-df5e-4a17-a9d4-6a312b6333d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "DNS", "", "" },
                    { new Guid("a3520b8c-33f9-4442-afaf-35b9a694e43a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Sql Server", "", "" },
                    { new Guid("a811545f-8517-41fb-85b3-205dab3d2b4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ActiveMQ", "", "" },
                    { new Guid("ace112e4-50a6-4e84-b23a-c2b6d1924935"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ArgoCD", "", "" },
                    { new Guid("b0228a28-4c9a-49b4-86bb-28ca0fc42ffe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ceph Storage", "", "" },
                    { new Guid("c4139545-1579-461f-a59a-3411d9bb9062"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" },
                    { new Guid("e8360423-a2f7-4acb-92c6-9f41c87a421b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" },
                    { new Guid("f56889d9-00b0-47ce-af1d-6ff94c515c19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Asp.Net", "", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Masters",
                keyColumn: "Id",
                keyValue: new Guid("79a3fba0-98e6-4fd9-8e8d-70e8c401c801"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("4cd0c4ff-5266-4d3b-b729-00172bc56899"));

            migrationBuilder.DeleteData(
                table: "PersonSkills",
                keyColumn: "Id",
                keyValue: new Guid("c3536b3c-e541-464f-b847-d454888f1fa1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("535e27f3-0c48-4e0f-9bff-bce4baa57d0f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e9fbdfb2-3997-422a-ae48-3b9fd120c9d9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("06216d41-2073-4d20-a085-ffc5b705a54c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("070b6d9b-aa52-4715-a1ab-1b4f8d1790e5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("113dab3c-312e-4e9b-a01b-f9edbeb94962"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1b5acb4f-026e-4bbc-bce1-6b72bdd2d10e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("29e83f97-d80e-4315-b799-918d384877bf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("40acffdd-175e-4a5a-a6f3-f9127e32ec54"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("436d2dde-7c31-45bf-bdcb-495861d32f81"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("45615062-1809-4139-b44f-68941dd60b6e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("486584be-2d40-443a-9eb7-9f302a24be6f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("50d7c92c-d87d-4e84-b116-f4416519373e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5faa0da6-bfba-47a3-ac68-4452e03ff53b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6551739e-4d5a-45ff-8f64-6341ca541373"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6e7e5e95-eeea-4329-a1d5-7dccfe1efe8c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("70435c6c-8fa5-4dd9-9354-d4cdc4840376"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("70e6af84-4504-48c1-91fa-e5d831e929f5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("782fa74c-7a70-4750-914a-164ef3074820"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("82f558df-2dfa-4ca5-bcf6-64df6705029f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8da41d43-4e15-4427-855e-cc2979180b98"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8fc331c9-b09e-4ceb-821a-c8636eaa3a2f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a00ca400-df5e-4a17-a9d4-6a312b6333d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a3520b8c-33f9-4442-afaf-35b9a694e43a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a811545f-8517-41fb-85b3-205dab3d2b4a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ace112e4-50a6-4e84-b23a-c2b6d1924935"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b0228a28-4c9a-49b4-86bb-28ca0fc42ffe"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c4139545-1579-461f-a59a-3411d9bb9062"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e8360423-a2f7-4acb-92c6-9f41c87a421b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f56889d9-00b0-47ce-af1d-6ff94c515c19"));

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
        }
    }
}

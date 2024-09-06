using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestPersistence.Migrations
{
    /// <inheritdoc />
    public partial class approve_Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleQuestionOption",
                table: "QuestionOptions");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionPhotos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionOptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PersonSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Masters",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Masters",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "Masters",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Masters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beginner", "", "" },
                    { new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intermediate", "", "" },
                    { new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advance", "", "" },
                    { new Guid("e8dcd2a6-2969-4247-bfc6-bf0661bf9ac5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expert", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Masters",
                columns: new[] { "Id", "Bio", "DateBirth", "DateCreate", "DateUpdate", "Degree", "Family", "Mobile", "Name", "Photo", "TitleBio", "UserCreate", "UserUpdate", "Website", "Years_Experience" },
                values: new object[] { new Guid("72a755c3-38d6-4e93-8202-6f4350beb48c"), "Master", new DateTime(2024, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1545), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bechlor", "Default", "09356735245", "Default", "", "Master", "", "", "-", (byte)99 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CodeMeli", "DateBirth", "DateCreate", "DateUpdate", "Family", "Mobile", "Name", "Photo", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"), null, new DateTime(1989, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "جهانگرد", "09356735245", "احسان", null, "", "" },
                    { new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"), null, new DateTime(1979, 9, 6, 19, 41, 36, 84, DateTimeKind.Local).AddTicks(1760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "جهانگرد", "09356735246", "علی", null, "", "" }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("15755f41-745a-300b-baa4-11d7faf80c99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "چهار گزینه ای", "", "" },
                    { new Guid("25755f41-746a-410b-aab4-21d7faf80c88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صحیح و غلط", "", "" },
                    { new Guid("35755f41-747a-422b-bca4-31d7faf80c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تشریحی", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreate", "DateUpdate", "SkillType", "Title", "UserCreate", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("092bda49-5756-4eac-bd91-58245e75d221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "ZooKeepr", "", "" },
                    { new Guid("108fce8a-866c-4e1d-b8f1-13fb3b0cd34b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Appache", "", "" },
                    { new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Docker", "", "" },
                    { new Guid("12809efc-7cd3-4e2f-9973-d2c8776a2060"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Firewall", "", "" },
                    { new Guid("1ff24aac-f94f-453c-9d58-dcc8ca74f16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Kafka", "", "" },
                    { new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Ansible", "", "" },
                    { new Guid("307793f0-3d0d-4abd-ab5a-d6685f606fae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "CI/CD", "", "" },
                    { new Guid("31243b41-744a-400b-bdb4-21d7faf80c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Git", "", "" },
                    { new Guid("3abd8797-9227-40b7-b09a-cf7aea5acd6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Oracle", "", "" },
                    { new Guid("3b9c246e-bc6e-49c9-8852-d824a1288ff0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Nginx", "", "" },
                    { new Guid("544d45f1-6f3c-4409-9e48-c79f98b4738a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Jenkins", "", "" },
                    { new Guid("612ee372-4366-4397-bc36-f3b10a9c4154"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "IIS", "", "" },
                    { new Guid("62df7083-ad8e-4f2c-8b4c-2065e8c54221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Python", "", "" },
                    { new Guid("6b762ba1-ab17-4858-b29c-e59cedf49961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "Azure", "", "" },
                    { new Guid("6bdff42b-bbba-4f95-b1f4-530eed817de5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "MongoDB", "", "" },
                    { new Guid("71244a41-744a-400b-bdb4-21d7faf80c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", "GitLab", "", "" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("35755f41-747a-422b-bca4-31d7faf80c66"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("e8dcd2a6-2969-4247-bfc6-bf0661bf9ac5"));

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
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: new Guid("15755f41-745a-300b-baa4-11d7faf80c99"));

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: new Guid("25755f41-746a-410b-aab4-21d7faf80c88"));

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
                keyValue: new Guid("31243b41-744a-400b-bdb4-21d7faf80c38"));

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
                keyValue: new Guid("71244a41-744a-400b-bdb4-21d7faf80c38"));

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

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("15755f41-745a-300b-baa4-11d7faf80c99"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("25755f41-746a-410b-aab4-21d7faf80c88"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("44755a41-744a-400b-bdb4-21d7faf80c38"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55755a41-744a-400b-bdb4-21d7faf80c22"));

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: new Guid("35755f41-747a-422b-bca4-31d7faf80c66"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("11244a41-744a-400b-bdb4-21d7faf80c38"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("21244a41-744a-400b-bdb4-21d7faf80c38"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionPhotos",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "QuestionOptions",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "TitleQuestionOption",
                table: "QuestionOptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PersonSkills",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Masters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Masters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "Masters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Masters",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");
        }
    }
}

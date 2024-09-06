﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestPersistence.Contexts;

#nullable disable

namespace TestPersistence.Migrations
{
    [DbContext(typeof(DevOpsTesterContext))]
    [Migration("20240906114004_createRelationShipPerson_Skill_level2")]
    partial class createRelationShipPerson_Skill_level2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestDomain.Models.Level", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("TestDomain.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TestDomain.Models.PersonSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("PersonId");

                    b.HasIndex("SkillId");

                    b.ToTable("PersonSkills");
                });

            modelBuilder.Entity("TestDomain.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("TestDomain.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Letter")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TestDomain.Models.QuestionOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("TestDomain.Models.QuestionPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionPhotos");
                });

            modelBuilder.Entity("TestDomain.Models.QuestionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("TestDomain.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("TestDomain.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("TestDomain.Models.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("TestDomain.Models.PersonSkill", b =>
                {
                    b.HasOne("TestDomain.Models.Level", "Levels")
                        .WithMany("PersonSkills")
                        .HasForeignKey("LevelId");

                    b.HasOne("TestDomain.Models.Person", "People")
                        .WithMany("PersonSkills")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDomain.Models.Skill", "Skills")
                        .WithMany("PersonSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Levels");

                    b.Navigation("People");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("TestDomain.Models.Level", b =>
                {
                    b.Navigation("PersonSkills");
                });

            modelBuilder.Entity("TestDomain.Models.Person", b =>
                {
                    b.Navigation("PersonSkills");
                });

            modelBuilder.Entity("TestDomain.Models.Skill", b =>
                {
                    b.Navigation("PersonSkills");
                });
#pragma warning restore 612, 618
        }
    }
}

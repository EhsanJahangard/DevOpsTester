using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDomain.Models;

namespace TestPersistence.Seed;


public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region Master
        modelBuilder.Entity<Master>().HasData(
            new Master("Default", "Default", "09356735245", "-", DateTime.Now, "Bechlor", "Master", "Master", "", 99)
        );
        #endregion
        #region Level
        modelBuilder.Entity<Level>().HasData(
            new Level( title: "Beginner",id: "15755f41-745a-300b-baa4-11d7faf80c99"),
            new Level(title: "Intermediate", id: "25755f41-746a-410b-aab4-21d7faf80c88"),
            new Level(title: "Advance", id: "35755f41-747a-422b-bca4-31d7faf80c66"),
            new Level(title: "Expert", id: "e8dcd2a6-2969-4247-bfc6-bf0661bf9ac5")
        );
        #endregion
        #region Person
        modelBuilder.Entity<Person>().HasData(
            new Person("44755a41-744a-400b-bdb4-21d7faf80c38", "احسان", "جهانگرد", DateTime.Now.AddYears(-35), "09356735245"),
            new Person("55755a41-744a-400b-bdb4-21d7faf80c22","علی", "جهانگرد", DateTime.Now.AddYears(-45), "09356735246")
        );
        #endregion
        #region PersonSkill
        modelBuilder.Entity<PersonSkill>().HasData(
            new PersonSkill("44755a41-744a-400b-bdb4-21d7faf80c38", "11244A41-744A-400B-BDB4-21D7FAF80C38", "15755f41-745a-300b-baa4-11d7faf80c99"),
            new PersonSkill("55755a41-744a-400b-bdb4-21d7faf80c22", "21244A41-744A-400B-BDB4-21D7FAF80C38", "15755f41-745a-300b-baa4-11d7faf80c99")
            
        );
        #endregion
        #region Skill
        modelBuilder.Entity<Skill>().HasData(
            new Skill("11244A41-744A-400B-BDB4-21D7FAF80C38","Docker", "Hard"),
            new Skill("21244A41-744A-400B-BDB4-21D7FAF80C38","Ansible", "Hard"),
            new Skill("71244A41-744A-400B-BDB4-21D7FAF80C38","GitLab", "Hard"),
            new Skill("31243B41-744A-400B-BDB4-21D7FAF80C38","Git", "Hard"),
            new Skill("CI/CD", "Hard"),
            new Skill("ArgoCD", "Hard"),
            new Skill("Azure", "Hard"),
            new Skill("Jenkins", "Hard"),
            new Skill("Firewall", "Hard"),
            new Skill("DNS", "Hard"),
            new Skill("Ceph Storage", "Hard"),
            new Skill("Nginx", "Hard"),
            new Skill("Appache", "Hard"),
            new Skill("Python", "Hard"),
            new Skill("Go Lang", "Hard"),
            new Skill("Asp.Net", "Hard"),
            new Skill("C#", "Hard"),
            new Skill("Sql Server", "Hard"),
            new Skill("PostgreSql", "Hard"),
            new Skill("MongoDB", "Hard"),
            new Skill("Redis", "Hard"),
            new Skill("Oracle", "Hard"),
            new Skill("RabbitMQ", "Hard"),
            new Skill("Kafka", "Hard"),
            new Skill("ActiveMQ", "Hard"),
            new Skill("ZeroMQ", "Hard"),
            new Skill("ZooKeepr", "Hard"),
            new Skill("Ocelot", "Hard"),
            new Skill("Kong", "Hard"),
            new Skill("IIS", "Hard"),
            new Skill("CleanCode", "Hard")
        );
        #endregion
        #region QuestionType
        modelBuilder.Entity<QuestionType>().HasData(
            new QuestionType("15755f41-745a-300b-baa4-11d7faf80c99", "چهار گزینه ای"),
            new QuestionType("25755f41-746a-410b-aab4-21d7faf80c88", "صحیح و غلط"),
            new QuestionType("35755f41-747a-422b-bca4-31d7faf80c66", "تشریحی")
        );
        #endregion

        #region Question
        modelBuilder.Entity<Question>().HasData(
            new Question("Docker چیست؟", "Container Framework", Guid.Parse("15755f41-745a-300b-baa4-11d7faf80c99"), Guid.Parse("35755f41-747a-422b-bca4-31d7faf80c66")),
            new Question("Kubernetes چیست؟", "Container Orchestration Open-Source", Guid.Parse("25755f41-746a-410b-aab4-21d7faf80c88"), Guid.Parse("35755f41-747a-422b-bca4-31d7faf80c66"))

        );
        #endregion

    }
}

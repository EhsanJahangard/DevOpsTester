using IdentityDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityPersistence.Seed;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region Role
        modelBuilder.Entity<Role>().HasData(
            new Role("admin2", "admin2", "2")

        );
        #endregion
        #region User
        modelBuilder.Entity<User>().HasData(
            new User("ehsan2", "jahangard2", "ehsanjahangard2020@gmail.com", "ehsanjahangardadmin", "09220127867", "2"),
            new User("ehsan3", "jahangard3", "ehsanjahangard2014@gmail.com", "admin2", "09169976779", "2")
        );
        #endregion
        //#region User_Role
        //modelBuilder.Entity<>().HasData(
        //    new User("ehsan", "jahangard", "ehsanjahangard2020@gmail.com", "ehsanjahangardadmin", "09220127867", "TestService"),
        //    new User("ehsan", "jahangard", "ehsanjahangard2014@gmail.com", "admin", "09220127867", "TestService")
        //);
        //#endregion

    }
}
using IdentityDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityPersistence.Seed;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region Role
        modelBuilder.Entity<Role>().HasData(
            new Role("admin", "admin", "TestService")

        );
        #endregion
        #region User
        modelBuilder.Entity<User>().HasData(
            new User("ehsan", "jahangard", "ehsanjahangard2020@gmail.com", "ehsanjahangardadmin", "09220127867", "TestService"),
            new User("ehsan", "jahangard", "ehsanjahangard2014@gmail.com", "admin", "09220127867", "TestService")
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
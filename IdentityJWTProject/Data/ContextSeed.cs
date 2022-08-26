

using IdentityJWTProject.Models;
using Microsoft.AspNetCore.Identity;
using IdentityJWTProject.Data;


namespace IdentityJWTProject.Data
{
    public class ContextSeed
    {

        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
            await roleManager.CreateAsync(new IdentityRole("User"));
        }

        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            var firstDefaultUser = new AppUser
            {
                UserName = "Vira111@gmail.com",
                Email = "Vira111@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(user => user.Id != firstDefaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(firstDefaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(firstDefaultUser, "Pa$$w0rd");
                    await userManager.AddToRoleAsync(firstDefaultUser, "Admin");
                    await userManager.AddToRoleAsync(firstDefaultUser, "User");
                }
            }

            var secondDefaultUser = new AppUser
            {
                UserName = "ehsan_jahangard_2022@yahoo.com",
                Email = "ehsan_jahangard_2022@yahoo.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(user => user.Id != secondDefaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(secondDefaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(secondDefaultUser, "Pa$$w0rd");
                    await userManager.AddToRoleAsync(secondDefaultUser, "User");
                }
            }
        }


    }
}


using LMS.Core.Entities;
using Microsoft.AspNetCore.Identity;


namespace LMS.Web.Data
{
    public class RoleInit
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string SEmail = "student1@gmail.com";
            string password = "_Ss123456";

            if (await roleManager.FindByNameAsync("student") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("student"));
            }
            if (await roleManager.FindByNameAsync("empl") == null)
            {
               await roleManager.CreateAsync(new IdentityRole("empl"));
            }
            if (await userManager.FindByNameAsync(SEmail) == null)
            {
                User student = new User 
                { 
                    Email = SEmail, 
                    UserName = SEmail, 
                    FirstName="Lara", 
                    LastName= "Domnina"
                };
                IdentityResult result = await userManager.CreateAsync(student, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(student, "student");
                }
                else
                {
                    Console.WriteLine("test");
                }
            }
        }
    }
}

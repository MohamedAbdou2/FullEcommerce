using FullEcommerce.Core.Identity;
using Microsoft.AspNetCore.Identity;

namespace FullEcommerce.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mohamed",
                    Email = "Mohamed@gmail.com",
                    UserName = "Mohamed@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Mohamed",
                        LastName = "Abdou",
                        Street = "leqa",
                        City = "kafrEldawar",
                        State = "EG",
                        ZipCode = "22611"

                    }


                };
                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}

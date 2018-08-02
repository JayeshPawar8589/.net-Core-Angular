using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TestUserCRUD.Model
{
    public class Users
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestUserContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestUserContext>>()))
            {
                // Look for any movies.
                if (context.TestUsers.Any())
                {
                    return;   // DB has been seeded
                }

                context.TestUsers.AddRange(
                    new TestUser
                    {
                        Name = "Jayesh Pawar",
                        Address = "Kurla",
                        EmailId = "jayesh.pawar@lntinfotech.com",
                        MobileNo = 734854223
                    },
                    new TestUser
                    {
                        Name = "Nitesh Chainani",
                        Address = "Ulhas Nagar",
                        EmailId = "Nitesh.Chainani@lntinfotech.com",
                        MobileNo = 734899223
                    },
                    new TestUser
                    {
                        Name = "Pramod Shandilya",
                        Address = "Banglore",
                        EmailId = "Pramod.Shandilya@lntinfotech.com",
                        MobileNo = 734854763
                    },
                    new TestUser
                    {
                        Name = "Shantanu Kadam",
                        Address = "Borivali",
                        EmailId = "Shantanu.Kadam@lntinfotech.com",
                        MobileNo = 755854223
                    },
                    new TestUser
                    {
                        Name = "Heena Dulani",
                        Address = "Powai",
                        EmailId = "Heena.Dulani@lntinfotech.com",
                        MobileNo = 895245125
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

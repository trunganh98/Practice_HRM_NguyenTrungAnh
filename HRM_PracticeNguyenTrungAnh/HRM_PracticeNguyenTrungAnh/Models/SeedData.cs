using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HRM_PracticeNguyenTrungAnh.Models;

namespace HRM_PracticeNguyenTrungAnh.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HRMDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<HRMDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                   new Employee
                   {
                       Name = "Nguyen Van A",
                       Gender = "Nam",
                       Birthday = "01/01/1994",
                       Address = "Ha Noi",
                       PhoneNumber = "0311111111"
                   },
                   new Employee
                   {
                       Name = "Nguyen Thi B",
                       Gender = "Nu",
                       Birthday = "02/02/1995",
                       Address = "Thai Binh",
                       PhoneNumber = "0322222222"
                   },
                    new Employee
                    {
                        Name = "Nguyen Van c",
                        Gender = "Nam",
                        Birthday = "03/03/1996",
                        Address = "Cao Bang",
                        PhoneNumber = "0333333333"
                    },
                     new Employee
                     {
                         Name = "Nguyen Thi D",
                         Gender = "NU",
                         Birthday = "04/04/1994",
                         Address = "Thai Nguyen",
                         PhoneNumber = "0344444444"
                     },
                      new Employee
                      {
                          Name = "Nguyen Van E",
                          Gender = "Nam",
                          Birthday = "05/05/1995",
                          Address = "Nam Dinh",
                          PhoneNumber = "0355555555"
                      }
                   );

                context.SaveChanges();
            }
        }
    }
}

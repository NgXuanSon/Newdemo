using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Netmo.Data;
using Netmo.Models;
using System;
using System.Linq;

namespace Netmo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDBContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        StudentId = "CTM01",
                        StudentName = "Nguyễn Văn A",
                        address = "Hà Nội",

                    },

                    new Student
                    {
                        StudentId = "CTM03",
                        StudentName = "Nguyễn Văn B",
                        address = "Cà Mau",

                    },

                    new Student
                    {
                        StudentId = "CTM05",
                        StudentName = "Nguyễn C",
                        address = "Nam Định",

                    },

                    new Student
                    {
                        StudentId = "CTM06",
                        StudentName = "Nguyễn G",
                        address = "Hà Tây",

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
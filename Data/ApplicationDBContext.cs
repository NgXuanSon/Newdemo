using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Netmo.Models;
namespace Netmo.Data
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Netmo.Models.Movie> Movie { get; set; }

        public DbSet<Netmo.Models.Person> Person { get; set; }

        public DbSet<Netmo.Models.Student> Student { get; set; }

        public DbSet<Netmo.Models.Employee> Employee { get; set; }

        public DbSet<Netmo.Models.Product> Product { get; set; }

        public DbSet<Peson> Peson { get; set; }
        public DbSet<Studen> Studen { get; set; }
        public DbSet<Netdemo> Netdemo { get; set; }
    }
}

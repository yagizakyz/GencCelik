using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class Context : DbContext
    {
        public IConfiguration Configuration { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=GencelikDB; integrated security=true;");

        }

        public DbSet<JobClass> JobTable { get; set; }
        public DbSet<PersonClass> PersonTable { get; set; }
        public DbSet<VehicleClass> VehicleTable { get; set; }
        public DbSet<ShippingClass> ShippingTable { get; set; }
        public DbSet<DieselClass> DieselTable { get; set; }
        public DbSet<IndustryClass> IndustryTable { get; set; }
    }
}

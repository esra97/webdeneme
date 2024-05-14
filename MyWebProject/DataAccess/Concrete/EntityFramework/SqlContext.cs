using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class SqlContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hastane;Trusted_Connection= true");
        }
        public DbSet<Hasta> Hastalar{ get; set; }
        public DbSet<Rapor> Raporlar { get; set; }
        public DbSet<Laborant> Laborantlar { get; set; }

    }
}

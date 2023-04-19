using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class EgitimContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=EgitimDB.db");
        }

        public DbSet<Egitmen> egitmenler { get; set; }
        public DbSet<Kurs> kurslar { get; set;}
        public DbSet<Ogrenci> ogrenciler { get; set; }
        public DbSet<Personel> personeller { get; set; }
        public DbSet<Sinif> siniflar { get; set; }
    }
}

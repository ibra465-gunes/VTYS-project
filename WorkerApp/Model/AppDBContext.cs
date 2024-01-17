using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base(CreateOptions())
        {
        }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<ProjeCalisan> ProjeCalisanlar { get; set; }
        private static DbContextOptions CreateOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IA05O5S\\SQLEXPRESS;Initial Catalog=WorkerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            return optionsBuilder.Options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProjeCalisan sınıfının bileşik anahtarını tanımla
            modelBuilder.Entity<ProjeCalisan>()
                .HasKey(pc => new { pc.ProjeNo, pc.CalisanNo });

            // ProjeCalisan sınıfının Proje sınıfıyla ilişkisini belirt
            modelBuilder.Entity<ProjeCalisan>()
                .HasOne(pc => pc.Proje)
                .WithMany(p => p.ProjeCalisanlar)
                .HasForeignKey(pc => pc.ProjeNo);

            // ProjeCalisan sınıfının Calisan sınıfıyla ilişkisini belirt
            modelBuilder.Entity<ProjeCalisan>()
                .HasOne(pc => pc.Calisan)
                .WithMany(c => c.ProjeCalisanlar)
                .HasForeignKey(pc => pc.CalisanNo);
        }

    }

}

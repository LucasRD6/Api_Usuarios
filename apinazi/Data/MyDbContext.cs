using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using apinazi.Models;



namespace apinazi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }

        public DbSet<Cuenta> Cuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>(e =>
            {
                e.Property(o => o.musico).HasColumnType("bit");
                e.Property(o => o.activo).HasColumnType("bit");
                e.Property(o => o.privado).HasColumnType("bit");
            });
            modelBuilder.Entity<Cuenta>().ToTable("Cuenta");
        }

    }
}

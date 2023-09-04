

using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InFrastructure
{
   public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.id).HasDefaultValueSql ("NEWID()");
            modelBuilder.Entity<PortFolioItem>().Property(x => x.id).HasDefaultValueSql("NEWID()");
        }
        public DbSet<Owner> owners { get; set; }
        public DbSet<PortFolioItem> portFolioItems { get; set; }

    }
}

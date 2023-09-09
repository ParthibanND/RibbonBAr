using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataBase.Model.Models
{
    public partial class Excel_AddinsContext : DbContext
    {
        public Excel_AddinsContext()
        {
        }

        public Excel_AddinsContext(DbContextOptions<Excel_AddinsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Details> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=PARTHIBANND\\SQLEXPRESS;Initial Catalog=Excel_Addins; Trusted_Connection=True; Trustservercertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

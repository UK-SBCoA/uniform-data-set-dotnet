using System;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Entities;

namespace UDS.Net.API.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Participation> Participations { get; set; }
        public DbSet<M1> M1s { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public DbSet<A1> A1s { get; set; }
        public DbSet<A2> A2s { get; set; }
        public DbSet<A3> A3s { get; set; }
        public DbSet<A4G> A4Gs { get; set; }
        public DbSet<A4D> A4Ds { get; set; }
        public DbSet<A5> A5s { get; set; }
        public DbSet<B1> B1s { get; set; }
        public DbSet<B4> B4s { get; set; }
        public DbSet<B5> B5s { get; set; }
        public DbSet<B6> B6s { get; set; }
        public DbSet<B7> B7s { get; set; }
        public DbSet<B8> B8s { get; set; }
        public DbSet<B9> B9s { get; set; }
        public DbSet<C1> C1s { get; set; }
        public DbSet<C2> C2s { get; set; }
        public DbSet<D1> D1s { get; set; }
        public DbSet<D2> D2s { get; set; }
        public DbSet<T1> T1s { get; set; }

        /* SQL Views */
        public DbSet<FormStatus> FormStatuses { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* SQL Tables */

            modelBuilder.Entity<A1>(entity =>
            {
                entity.Property(a => a.IsIncluded).IsRequired(true).HasDefaultValue(true);
                entity.Property(a => a.ReasonCode).HasDefaultValue(null);
            });


            /* SQL Views */

            modelBuilder.Entity<FormStatus>().ToView("vw_FormStatuses")
                .HasKey(f => new { f.VisitId, f.Kind });


        }
    }
}


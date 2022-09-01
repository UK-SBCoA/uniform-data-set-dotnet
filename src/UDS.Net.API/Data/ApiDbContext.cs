using System;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Entities;

namespace UDS.Net.API.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}


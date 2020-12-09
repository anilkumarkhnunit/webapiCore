
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ScoreService.Service.Models;

namespace ScoreService.Repository.sql
{
    public class AppDbContext : DbContext , IBuildingScoreContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<BuildingScore> BuildingScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildingScore>()
                .HasKey(b => b.FacilityId)
                .HasName("PrimaryKey_FacilityId");
        }
    }
}

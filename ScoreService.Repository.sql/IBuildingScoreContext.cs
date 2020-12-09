using Microsoft.EntityFrameworkCore;
using ScoreService.Service.Models;

namespace ScoreService.Repository.sql
{
    internal interface IBuildingScoreContext
    {
        public DbSet<BuildingScore> BuildingScores { get; set; }

        int SaveChanges();
    }
}
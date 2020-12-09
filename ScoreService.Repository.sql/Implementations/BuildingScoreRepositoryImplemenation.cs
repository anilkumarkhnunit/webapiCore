using Microsoft.EntityFrameworkCore;
using ScoreService.Service.DependentInterfaces;
using ScoreService.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScoreService.Repository.sql.Implementations
{
    public class BuildingScoreRepositoryImplemenation : IBuildingScoreRepository
    {
        private readonly AppDbContext _appDbContext;
        //private readonly IDbContextFactory<AppDbContext> _dbContextFactory;


        //public BuildingScoreRepositoryImplemenation(IDbContextFactory<AppDbContext> dbContextFactory)
       public BuildingScoreRepositoryImplemenation(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
           // _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<BuildingScore>> GetBuildingScores()
        {
            //return _appDbContext.BuildingScores;

            return await _appDbContext.BuildingScores.ToArrayAsync<BuildingScore>();
        }

        BuildingScore IBuildingScoreRepository.Add(BuildingScore buildingScore)
        {
            this._appDbContext.BuildingScores.Add(buildingScore);
            _appDbContext.SaveChanges();
            return buildingScore;
        }

        BuildingScore IBuildingScoreRepository.Delete(Guid facilityId)
        {
            BuildingScore buildingScore = _appDbContext.BuildingScores.Find(facilityId);
            if(buildingScore !=null)
            {
                _appDbContext.BuildingScores.Remove(buildingScore);
                _appDbContext.SaveChanges();
            }
            return buildingScore;
        }

        BuildingScore IBuildingScoreRepository.GetBuildingScore(Guid guid)
        {
            return _appDbContext.BuildingScores.Find(guid);
        }

        BuildingScore IBuildingScoreRepository.Update(BuildingScore buildingScore)
        {
            var buildingscorechanges = _appDbContext.BuildingScores.Attach(buildingScore);
            buildingscorechanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
            return buildingScore;
        }
    }
}

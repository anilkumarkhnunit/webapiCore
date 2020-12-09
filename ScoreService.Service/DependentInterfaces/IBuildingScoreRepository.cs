using ScoreService.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScoreService.Service.DependentInterfaces
{
   public interface IBuildingScoreRepository
    {
        Task<IEnumerable<BuildingScore>> GetBuildingScores();
        BuildingScore GetBuildingScore(Guid guid);
        BuildingScore Add(BuildingScore buildingScore);
        BuildingScore Update(BuildingScore buildingScore);
        BuildingScore Delete(Guid id);
    }
}

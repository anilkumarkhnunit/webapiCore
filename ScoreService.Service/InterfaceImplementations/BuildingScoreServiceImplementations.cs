using ScoreService.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ScoreService.Service.Models;
using ScoreService.Service.DependentInterfaces;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScoreService.Service.InterfaceImplementations
{
    public class BuildingScoreServiceImplementations : IBuildingScoreService
    {
        private readonly IBuildingScoreRepository _BuildingScoreRepository;
        public BuildingScoreServiceImplementations(IBuildingScoreRepository buildingScoreRepository)
        {
            _BuildingScoreRepository = buildingScoreRepository;
        }
        public async Task<IEnumerable<BuildingScore>> GetBuildingScores()
        {
            return await _BuildingScoreRepository.GetBuildingScores();
        }

        BuildingScore IBuildingScoreService.Add(BuildingScore buildingScore)
        {
           return _BuildingScoreRepository.Add(buildingScore);
        }

        BuildingScore IBuildingScoreService.Delete(Guid id)
        {
            return _BuildingScoreRepository.Delete(id);
        }

        BuildingScore IBuildingScoreService.GetBuildingScore(Guid guid)
        {
            return _BuildingScoreRepository.GetBuildingScore(guid);
        }

        BuildingScore IBuildingScoreService.Update(BuildingScore buildingScore)
        {
            return _BuildingScoreRepository.Update(buildingScore);
        }
    }
}

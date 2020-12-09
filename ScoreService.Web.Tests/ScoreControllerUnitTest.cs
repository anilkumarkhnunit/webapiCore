using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using ScoreService.Web;
using ScoreService.Web.Controllers;
using System.Threading.Tasks;
using FakeItEasy;
using ScoreService.Service.Interfaces;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ScoreService.Service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ScoreService.Web.Tests
{
   public class ScoreControllerUnitTest
    {

        private readonly ScoreController _scoresController;

        public ScoreControllerUnitTest()
        {

        }

        [Fact]
        public void GetTaskAsync()
        {

            IList<BuildingScore> buildingScores = new List<BuildingScore>()
            {
                new BuildingScore
                {
                    FacilityId =new Guid(),
                    SiteId = new Guid(),
                    MyPrSiteNameoperty = "name",
                    ZoneId = new Guid()
                },
                new BuildingScore
                {
                    FacilityId =new Guid(),
                    SiteId = new Guid(),
                    MyPrSiteNameoperty = "name1",
                    ZoneId = new Guid()
                },
                new BuildingScore
                {
                     FacilityId =new Guid(),
                    SiteId = new Guid(),
                    MyPrSiteNameoperty = "name2",
                    ZoneId = new Guid()
                },
                new BuildingScore
                {
                     FacilityId =new Guid(),
                    SiteId = new Guid(),
                    MyPrSiteNameoperty = "name3",
                    ZoneId = new Guid()
                }
            };
            var fakeBuildingScoreService = A.Fake<IBuildingScoreService>();

            // set up a call to return a value
            A.CallTo(() => fakeBuildingScoreService.GetBuildingScores()).Returns(buildingScores);

            var scoreController = new ScoreController(fakeBuildingScoreService);

            //var result = scoreController.Get();

            //Assert.Equal(buildingScores, scoreController.Get(), new BuildingScoreComparer());



        }

        public class BuildingScoreComparer : IEqualityComparer<BuildingScore>
        {
            public bool Equals(BuildingScore x, BuildingScore y)
            {
                return x.FacilityId.Equals(y.FacilityId);
            }

            public int GetHashCode([DisallowNull] BuildingScore obj)
            {
                return obj.GetHashCode();
            }
        }


    }
}

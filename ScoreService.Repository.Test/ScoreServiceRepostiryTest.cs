using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using ScoreService.Repository.sql;
using ScoreService.Repository.sql.Implementations;
using ScoreService.Service.DependentInterfaces;
using ScoreService.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using Xunit;

namespace ScoreService.Repository.Test
{
    public class ScoreServiceRepostiryTest
    {
       // private readonly BuildingScoreRepositoryImplemenation _buildingScoreRepositoryImplemenation;

        public ScoreServiceRepostiryTest()
        {

        }

        //[Fact]
        //public void GetBuildingScores()
        //{

        //    int count = 0;
        //    // Create test data
        //    var testData = new List<BuildingScore>
        //    {
        //                new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //                  new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //                    new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //                      new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },

        //    };


        //    // Arrange
        //    var set = A.Fake<DbSet<BuildingScore>>(o => o.Implements(typeof(IQueryable<BuildingScore>))
        //                 .Implements(typeof(IDbAsyncEnumerable<BuildingScore>)));




        //    var context = A.Fake<AppDbContext>();
        //    A.CallTo(() => context.BuildingScores).Returns(set);

        //    var buildingScoreRepositoryImplemenation = new BuildingScoreRepositoryImplemenation(context);

        //    // Act
        //    var buildingScores = buildingScoreRepositoryImplemenation.GetBuildingScores().ToList();

        //    // Assert
        //    Assert.Equal(4, buildingScores.Count());



        //}


        [Fact]
        public void GetBuildingScoreTest()
        {
            int count = 0;
            var fakeContext = A.Fake<AppDbContext>();
           // var FakeDbContextOptions = A.Fake<DbContextOptions<fakeContext>>();

            var fakeDbSet = A.Fake<DbSet<BuildingScore>>();
            A.CallTo(() => fakeContext.BuildingScores).Returns(fakeDbSet);

            IQueryable<BuildingScore> data = null;
            data = new List<BuildingScore>
            {
                new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
                  new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
                    new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
                      new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },

            }.AsQueryable();


            fakeContext.MockData(data.ToList(), () => fakeContext.BuildingScores);

            //var fakeIBuildingScoreRepository = A.Fake<IBuildingScoreRepository>();

            //IDbContextFactory<AppDbContext> dbContextFactory = A.Fake<IDbContextFactory<AppDbContext>>();
            //A.CallTo(() => dbContextFactory.CreateDbContext()).Returns(fakeContext);


        }
    }
}

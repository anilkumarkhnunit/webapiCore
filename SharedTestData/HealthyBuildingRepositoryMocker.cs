using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTestData
{
    using System.Linq;
    using FakeItEasy;    
    //using Honeywell.HCEHB.DatabaseModels.Common;
    //using Honeywell.HCEHB.DatabaseModels.DBContexts;
    //using Honeywell.HCEHB.DatabaseModels.Entities;
    //using Honeywell.HCEHB.DatabaseModels.Factories;
    //using HCEHB.ScoreService.Repository.Sql;
    using ScoreService.Service.DependentInterfaces;
    using Microsoft.EntityFrameworkCore;
    using ScoreService.Repository.sql;
    using ScoreService.Service.Models;
    using ScoreService.Repository.sql.Implementations;

    public class HealthyBuildingRepositoryMocker
    {
        private static string _dummyFacilityId;
        //public static IBuildingScoreRepository CreateHealthyBuildingRepositoryWithMockedHealthyBuildingScore(
        //    string dummyFacilityId)
        //{
        //    int count = 0;
        //    _dummyFacilityId = dummyFacilityId;
        //    IDbContextFactory<AppDbContext> dbContextFactory = A.Fake<IDbContextFactory<AppDbContext>>();
        //    AppDbContext dbContext = FakeDbContext.Fake<AppDbContext>();
        //    A.CallTo(() => dbContextFactory.Create(null)).Returns(dbContext);

        //    IQueryable<BuildingScore> data = null;
        //    data = new List<BuildingScore>
        //    {
        //        new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //          new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //            new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },
        //              new BuildingScore {FacilityId = new Guid(), SiteId = new Guid(), ZoneId = new Guid(),MyPrSiteNameoperty = "SITENAME_"+count++ },

        //    }.AsQueryable();

        //    dbContext.MockData(data.ToList(), () => dbContext.BuildingScores);

        //    return new BuildingScoreRepositoryImplemenation(dbContextFactory);
        //}

      
    }
}

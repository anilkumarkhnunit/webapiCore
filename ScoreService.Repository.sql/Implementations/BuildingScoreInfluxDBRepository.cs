using ScoreService.Service.DependentInterfaces;
using ScoreService.Service.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InfluxData.Net.Common.Enums;
using InfluxData.Net.InfluxDb;
using System.Linq;

namespace ScoreService.Repository.sql.Implementations
{
    public class BuildingScoreInfluxDBRepository : IBuildingScoreRepository
    {

        // Declare Influx DbClient
        private InfluxDbClient clientDb;
        public BuildingScoreInfluxDBRepository()
        {
            // API Address, Account, Password for Connecting Influx Db
            var infuxUrl = "http://localhost:8086/";
            var infuxUser = "scoreuser";
            var infuxPwd = "scoresuser123";

            // Create an instance of Influx DbClient
            clientDb = new InfluxDbClient(infuxUrl, infuxUser, infuxPwd, InfluxDbVersion.Latest);
        }

      

        public BuildingScore Add(BuildingScore buildingScore)
        {
            throw new NotImplementedException();
        }

        public BuildingScore Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public BuildingScore GetBuildingScore(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BuildingScore>> GetBuildingScores()
        {
            // Input query commands, support multiple
            var queries = new[]
            {
                " SELECT * FROM BuildingScores WHERE time> now() - 24h "
            };
            var dbName = "db_score";

            // Query data from a specified library
            var response = await clientDb.Client.QueryAsync(queries, dbName);
            //Get the Serie collection object(returning the results of executing multiple queries)
            var series = response.ToList();
            // The query result of the first command is a collection.
            var list = series[0].Values;

            List<BuildingScore> listScore = new List<BuildingScore>();
            BuildingScore objScore = null;
            // Extract the first data from the collection
            foreach(var obj in list)
            {
                
                objScore = new BuildingScore();

                string updatedobj2 = obj[2].ToString().Replace("\"", "");
                objScore.FacilityId = new Guid(updatedobj2);

                string updatedobj4 = obj[4].ToString().Replace("\"", "");
                objScore.SiteId = new Guid(updatedobj4);

                string updatedobj5 = obj[5].ToString().Replace("\"", "");
                objScore.ZoneId = new Guid(updatedobj5);
                objScore.MyPrSiteNameoperty = obj[3].ToString().Replace("\"", "");
                listScore.Add(objScore);
            }

            return listScore;
        }

        public BuildingScore Update(BuildingScore buildingScore)
        {
            throw new NotImplementedException();
        }
    }
}

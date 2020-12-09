using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScoreService.Service.Interfaces;
using ScoreService.Service.Models;

namespace ScoreService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IBuildingScoreService _buildingScoreService;
        public ScoreController(IBuildingScoreService buildingScoreService)
        {
            _buildingScoreService = buildingScoreService;
        }

        [HttpGet]
        // GET: api/scores
        public async Task<IActionResult> GetAllScores()
        {
           
            try
            {
                IEnumerable<BuildingScore> scores = await _buildingScoreService.GetBuildingScores();             

                return Ok(scores);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, new { Status = "Error", Message = "Failed in fetching  building score details" });
            }
        }

        // GET api/Score/ebf44569-357a-498c-a67a-2a01c27a388d
        [HttpGet("{facilityId}")]
        public ActionResult<BuildingScore> Get(Guid facilityId)
        {
            return _buildingScoreService.GetBuildingScore(facilityId);
        }


        // POST api/score
        [HttpPost]
        public void Post([FromBody] BuildingScore buildingScore)
        {
             _buildingScoreService.Add(buildingScore);
           
        }

        // PUT api/score
        [HttpPut]
        public void Put([FromBody] BuildingScore buildingScore)
        {
            _buildingScoreService.Update(buildingScore);
        }


        // DELETE api/score/5
        [HttpDelete("{facilityId}")]
        public void Delete(Guid facilityId)
        {
            _buildingScoreService.Delete(facilityId);
        }

    }
}

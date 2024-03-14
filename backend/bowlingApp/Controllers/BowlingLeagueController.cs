using bowlingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bowlingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingLeagueController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {

            var joinedData = from bowler in _bowlerRepository.Bowlers
                             join team in _bowlerRepository.Teams
                             on bowler.TeamId equals team.TeamId
                             select new Bowler
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamName = team.TeamName
                             };
      

            return joinedData.ToList();
            //var teamAndBowlers = _bowlerRepository.Teams
            //    //.Include(t => t.Bowlers) // Include Bowlers related to the Team
            //    .SelectMany(team => team.Bowlers) // Flatten the query to get Bowlers directly
            //    .ToList(); // Execute the query and get the list of Bowlers associated with each Team

            //return teamAndBowlers;
        }

        

        //public IEnumerable<Team> Get()
        //{
        //    var TeamData = _bowlerRepository.Teams.ToArray();
        //    return (TeamData);

           //  var BowlingData = _bowlerRepository.Bowlers.ToArray();
           // return (BowlingData);
        //}

    }
}

using Microsoft.EntityFrameworkCore;

namespace bowlingApp.Models
{
    public class EFBowlerRepository: IBowlerRepository
    {
        private BowlingLeagueContext _Context;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _Context = temp;
        }

        //public IEnumerable<Bowler>Bowlers => _Context.Bowlers.Include("Team");

        //filter table to only marlins and sharks and pull in teams table
        public IEnumerable<Bowler>Bowlers => _Context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
            .ToList();

        //get the teams
        public IEnumerable<Team> Teams => _Context.Teams;
    }
}

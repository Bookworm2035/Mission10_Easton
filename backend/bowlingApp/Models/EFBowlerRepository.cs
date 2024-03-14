namespace bowlingApp.Models
{
    public class EFBowlerRepository: IBowlerRepository
    {
        private BowlingLeagueContext _Context;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _Context = temp;
        }

        public IEnumerable<Bowler>Bowlers => _Context.Bowlers;

        public IEnumerable<Team> Teams => _Context.Teams;
    }
}

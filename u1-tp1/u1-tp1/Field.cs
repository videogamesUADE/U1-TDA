namespace CoreApp
{
    class Field
    {
        private string name;
        private Team teamA;
        private Team teamB;
        private Ball currentBall;

        public Field(string vName, string nameTeamA, string nameTeamB, Ball vBall)
        {
            name = vName;

            teamA = new Team(nameTeamA);
            MakeTeam(teamA);
            teamB = new Team(nameTeamB);
            MakeTeam(teamB);

            currentBall = vBall;
        }

        public Team TeamA
        {
            get
            {
                return teamA;
            }

            set
            {
                teamA = value;
            }
        }

        public Team TeamB
        {
            get
            {
                return teamB;
            }

            set
            {
                teamB = value;
            }
        }

        public Ball CurrentBall
        {
            get
            {
                return currentBall;
            }

            set
            {
                currentBall = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private void MakeTeam( Team t)
        {
            Player p1;

            for ( int x=1; x<6; x++ )
            { 
                p1 = new Player("player "+x);
                t.AddPlayer(p1);
            }
        }
    }
}

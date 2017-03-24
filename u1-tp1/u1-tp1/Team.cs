using System.Collections.Generic;

namespace CoreApp
{
    class Team
    {
        private string name;
        private List<Player> teamList;

        public Team(string vName)
        {
            name = vName;
            teamList = new List<Player>();
        }

        public void AddPlayer(Player p)
        {
            if ( p != null)
            { 
                teamList.Add(p);
            }
        }

        public void RemovePlayer(Player p)
        {
            if (p != null)
            {
                teamList.Remove(p);
            }
        }

        public Player SeekPlayerByName(string name)
        {
            Player pResul = null;

            foreach (Player p in teamList)
            {
                if (p.Name.Equals(name))
                {
                    pResul = p;
                    break;
                }
            }

            return pResul;
        }

        public List<Player> TeamList
        {
            get
            {
                return teamList;
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
    }
}


namespace CoreApp
{
    class Player
    {
        private string name;

        public Player(string vName)
        {
            Name = vName;
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

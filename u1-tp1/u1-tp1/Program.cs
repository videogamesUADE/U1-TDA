using System;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball currentBall;
            Field currentField;
            string nameField;
            string nameTeamA;
            string nameTeamB;
            float ballRatio;

            Console.WriteLine("Name field: ");
            nameField = Console.ReadLine();

            Console.WriteLine("Name Team A :");
            nameTeamA = Console.ReadLine();
            Console.WriteLine("Name Team B :");
            nameTeamB = Console.ReadLine();

            Console.WriteLine("Ball ratio: ");
            ballRatio = Convert.ToSingle(Console.ReadLine());
            currentBall = new Ball(ballRatio);

            currentField = new Field(nameField, nameTeamA, nameTeamB, currentBall);

            Console.WriteLine("----------------------");
            Console.WriteLine("Name Field: " + currentField.Name);
            Console.WriteLine("Ball Ratio: " + currentField.CurrentBall.Ratio);

            Console.WriteLine("Name TeamA: " + currentField.TeamA.Name);
            Console.WriteLine("Players TeamA");
            foreach (Player p in currentField.TeamA.TeamList)
            {
                Console.WriteLine("Player Name: " + p.Name);
            }
            Console.WriteLine("Name TeamB: " + currentField.TeamB.Name);

            Console.WriteLine("Players TeamB");
            foreach (Player p in currentField.TeamB.TeamList)
            {
                Console.WriteLine("Player Name: " + p.Name);
            }

            Console.WriteLine("----------------------");

            Console.Read();
        }
    }
}

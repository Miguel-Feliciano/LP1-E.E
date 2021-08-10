using System;

namespace _18Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {

            Board b = new Board();

            Console.WriteLine("Welcome to 18 Ghosts!");
            Console.WriteLine("These are the rules:");
            Console.WriteLine("2 players have to guide their ghosts to the" +
            "portals to exit, each player has 3 ghosts of each color to " +
            "control. You can move in any direction except diagonally 1 square" +
            "per round. You can defeat the enemy ghosts and send them to the" +
            "dungeon. Red defeats blue, blue defeats yellow and yellow defeats" +
             "red. When you defeat a ghost the portal with the same color as " +
             "the defeated ghost turns 90º clockwise. There are 4 mirror slots" +
             "that when entered, the player can go to one of them." +
             "The first player to get one ghost out wins!");
            Console.WriteLine("Have Fun!");

            b.DrawBoard();
            b.PlaceGhost();
            b.Execute();
        }
    }
}

using System;
using System.Collections;

namespace _18Ghosts
{
    public class Board
    {
        Tiles[,] board = new Tiles[5, 5];

        Tiles[] dungeon = new Tiles[5];
        Random randomGhost = new Random();

        Player[] players = new Player[2];

        public Board()
        {
            players[0] = new Player(GhostShape.Smile);
            players[1] = new Player(GhostShape.Scarry);
        }


        public void DrawBoard()
        {
            //int t = 0;
            //int m = 0;
            //int d = 0;


            //Line 1
            Console.Write("|");
            board[0, 0] = new Tiles(Colors.Blue, Types.Normal, "A1", "\u250C");
            board[0, 0].WriteTile();
            Console.Write("|");
            board[0, 1] = new Tiles(Colors.Red, Types.Normal, "B1", "\u252C");
            board[0, 1].WriteTile();
            Console.Write("|");
            board[0, 2] = new Tiles(Colors.Red, Types.Portal, "C1", "\u25B2");
            board[0, 2].WriteTile();//tem de ser portal
            Console.Write("|");

            board[0, 3] = new Tiles(Colors.Blue, Types.Normal, "D1", "\u252C");
            board[0, 3].WriteTile();

            Console.Write("|");

            board[0, 4] = new Tiles(Colors.Red, Types.Normal, "E1", "\u2510");
            board[0, 4].WriteTile();

            Console.Write("|");
            dungeon[0] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
            dungeon[0].WriteTile();
            Console.WriteLine("|");


            //Line 2
            Console.Write("|");
            board[1, 0] = new Tiles(Colors.Yellow, Types.Normal, "A2", "\u251C");
            board[1, 0].WriteTile();
            Console.Write("|");
            board[1, 1] = new Tiles(Colors.White, Types.Mirror, "B2", "\u2229");
            board[1, 1].WriteTile();
            Console.Write("|");
            board[1, 2] = new Tiles(Colors.Yellow, Types.Normal, "C2", "\u253C");
            board[1, 2].WriteTile();
            Console.Write("|");
            board[1, 3] = new Tiles(Colors.White, Types.Mirror, "D2", "\u2229");
            board[1, 3].WriteTile();
            Console.Write("|");
            board[1, 4] = new Tiles(Colors.Yellow, Types.Normal, "E2", "\u2524");
            board[1, 4].WriteTile();
            Console.Write("|");
            dungeon[1] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
            dungeon[1].WriteTile();
            Console.WriteLine("|");

            //Line 3
            Console.Write("|");
            board[2, 0] = new Tiles(Colors.Red, Types.Normal, "A3", "\u251C");
            board[2, 0].WriteTile();
            Console.Write("|");
            board[2, 1] = new Tiles(Colors.Blue, Types.Normal, "B3", "\u253C");
            board[2, 1].WriteTile();
            Console.Write("|");
            board[2, 2] = new Tiles(Colors.Red, Types.Normal, "C3", "\u253C");
            board[2, 2].WriteTile();
            Console.Write("|");
            board[2, 3] = new Tiles(Colors.Blue, Types.Normal, "D3", "\u253C");
            board[2, 3].WriteTile();
            Console.Write("|");
            board[2, 4] = new Tiles(Colors.Yellow, Types.Portal, "E3", "\u25BA");
            board[2, 4].WriteTile();//tem de ser portal
            Console.Write("|");
            dungeon[2] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
            dungeon[2].WriteTile();
            Console.WriteLine("|");

            //Line 4
            Console.Write("|");
            board[3, 0] = new Tiles(Colors.Blue, Types.Normal, "A4", "\u251C");
            board[3, 0].WriteTile();
            Console.Write("|");
            board[3, 1] = new Tiles(Colors.White, Types.Mirror, "B4", "\u2229");
            board[3, 1].WriteTile();
            Console.Write("|");
            board[3, 2] = new Tiles(Colors.Yellow, Types.Normal, "C4", "\u253C");
            board[3, 2].WriteTile();
            Console.Write("|");
            board[3, 3] = new Tiles(Colors.White, Types.Mirror, "D4", "\u2229");
            board[3, 3].WriteTile();
            Console.Write("|");
            board[3, 4] = new Tiles(Colors.Red, Types.Normal, "E4", "\u2524");
            board[3, 4].WriteTile();

            Console.Write("|");
            dungeon[3] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
            dungeon[3].WriteTile();
            Console.WriteLine("|");

            //Line 5
            Console.Write("|");

            board[4, 0] = new Tiles(Colors.Yellow, Types.Normal, "A5", "\u2514");
            board[4, 0].WriteTile();
            Console.Write("|");
            board[4, 1] = new Tiles(Colors.Red, Types.Normal, "B5", "\u2534");
            board[4, 1].WriteTile();
            Console.Write("|");
            board[4, 2] = new Tiles(Colors.Blue, Types.Portal, "C5", "\u25BC");
            board[4, 2].WriteTile();// tem de ser portal
            Console.Write("|");
            board[4, 3] = new Tiles(Colors.Blue, Types.Normal, "D5", "\u2534");
            board[4, 3].WriteTile();
            Console.Write("|");
            board[4, 4] = new Tiles(Colors.Yellow, Types.Normal, "E5", "\u2518");
            board[4, 4].WriteTile();
            Console.Write("|");
            dungeon[4] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
            dungeon[4].WriteTile();
            Console.WriteLine("|");
        }
        public void Execute()
        {
            Console.Write("|");
            board[0, 0].WriteTile();
            Console.Write("|");
            board[0, 1].WriteTile();
            Console.Write("|");
            board[0, 2].WriteTile();//tem de ser portal
            Console.Write("|");
            board[0, 3].WriteTile();
            Console.Write("|");
            board[0, 4].WriteTile();
            Console.Write("|");
            dungeon[0].WriteTile();
            Console.WriteLine("|");


            //Line 2
            Console.Write("|");
            board[1, 0].WriteTile();
            Console.Write("|");
            board[1, 1].WriteTile();
            Console.Write("|");
            board[1, 2].WriteTile();
            Console.Write("|");
            board[1, 3].WriteTile();
            Console.Write("|");
            board[1, 4].WriteTile();
            Console.Write("|");
            dungeon[1].WriteTile();
            Console.WriteLine("|");

            //Line 3
            Console.Write("|");
            board[2, 0].WriteTile();
            Console.Write("|");
            board[2, 1].WriteTile();
            Console.Write("|");
            board[2, 2].WriteTile();
            Console.Write("|");
            board[2, 3].WriteTile();
            Console.Write("|");
            board[2, 4].WriteTile();//tem de ser portal
            Console.Write("|");
            dungeon[2].WriteTile();
            Console.WriteLine("|");

            //Line 4
            Console.Write("|");
            board[3, 0].WriteTile();
            Console.Write("|");
            board[3, 1].WriteTile();
            Console.Write("|");
            board[3, 2].WriteTile();
            Console.Write("|");
            board[3, 3].WriteTile();
            Console.Write("|");
            board[3, 4].WriteTile();
            Console.Write("|");
            dungeon[3].WriteTile();
            Console.WriteLine("|");

            //Line 5
            Console.Write("|");
            board[4, 0].WriteTile();
            Console.Write("|");
            board[4, 1].WriteTile();
            Console.Write("|");
            board[4, 2].WriteTile();// tem de ser portal
            Console.Write("|");
            board[4, 3].WriteTile();
            Console.Write("|");
            board[4, 4].WriteTile();
            Console.Write("|");
            dungeon[4].WriteTile();
            Console.WriteLine("|");
        }
        public void PlaceGhost()
        {
            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    randomGhost = new Random();
                    int p = randomGhost.Next(0, 1); // 0 = Player A, 1 = Player B

                    int piece = players[p].CheckFree(board[l, c].Color);

                    if (piece == -1)
                    {
                        p = (p == 0) ? 1 : 0;
                        piece = players[p].CheckFree(board[l, c].Color);
                    }
                    board[l,c].Bkgd = 
                    players[p].GetGhost(board[l,c].Color, piece);
                }
            }
        }

    }
}
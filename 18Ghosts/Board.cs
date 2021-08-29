using System;


namespace _18Ghosts
{
    public class Board
    {
        /// <summary>
        /// Creates arrays for the board, dungeon and players
        /// </summary>
        Tiles[,] board = new Tiles[5, 5];

        Tiles[] dungeon = new Tiles[5];
        Random randomGhost = new Random();

        Player[] players = new Player[2];

        Portal[] portals = new Portal[3];

        Tiles[] mirrors = new Tiles[4];

        bool victory = false;

        /// <summary>
        /// Sets the type of ghost to each player
        /// </summary>
        public Board()
        {
            players[0] = new Player(GhostShape.Smile, 1);
            players[1] = new Player(GhostShape.Scarry, 2);

            board[0, 0] = new Tiles(Colors.Blue, Types.Normal, "11", "\u250C");
            board[0, 1] = new Tiles(Colors.Red, Types.Normal, "21", "\u252C");
            board[0, 2] = new Tiles(Colors.Red, Types.Portal, "31", "\u25B2");
            portals[0] = new Portal("\u25B2", Colors.Red, 1);
            board[0, 3] = new Tiles(Colors.Blue, Types.Normal, "41", "\u252C");
            board[0, 4] = new Tiles(Colors.Red, Types.Normal, "51", "\u2510");
            dungeon[0] = new Tiles(Colors.White, Types.Dungeon, "\u2591");

            board[1, 0] = new Tiles(Colors.Yellow, Types.Normal, "12", "\u251C");
            board[1, 1] = new Tiles(Colors.White, Types.Mirror, "22", "\u2229");
            board[1, 2] = new Tiles(Colors.Yellow, Types.Normal, "32", "\u253C");
            board[1, 3] = new Tiles(Colors.White, Types.Mirror, "42", "\u2229");
            board[1, 4] = new Tiles(Colors.Yellow, Types.Normal, "52", "\u2524");
            dungeon[1] = new Tiles(Colors.White, Types.Dungeon, "\u2591");

            board[2, 0] = new Tiles(Colors.Red, Types.Normal, "13", "\u251C");
            board[2, 1] = new Tiles(Colors.Blue, Types.Normal, "23", "\u253C");
            board[2, 2] = new Tiles(Colors.Red, Types.Normal, "33", "\u253C");
            board[2, 3] = new Tiles(Colors.Blue, Types.Normal, "43", "\u253C");
            board[2, 4] = new Tiles(Colors.Yellow, Types.Portal, "53", "\u25BA");
            portals[1] = new Portal("\u25BA", Colors.Yellow, 2);
            dungeon[2] = new Tiles(Colors.White, Types.Dungeon, "\u2591");

            board[3, 0] = new Tiles(Colors.Blue, Types.Normal, "14", "\u251C");
            board[3, 1] = new Tiles(Colors.White, Types.Mirror, "24", "\u2229");
            board[3, 2] = new Tiles(Colors.Yellow, Types.Normal, "34", "\u253C");
            board[3, 3] = new Tiles(Colors.White, Types.Mirror, "44", "\u2229");
            board[3, 4] = new Tiles(Colors.Red, Types.Normal, "54", "\u2524");
            dungeon[3] = new Tiles(Colors.White, Types.Dungeon, "\u2591");

            board[4, 0] = new Tiles(Colors.Yellow, Types.Normal, "15", "\u2514");
            board[4, 1] = new Tiles(Colors.Red, Types.Normal, "25", "\u2534");
            board[4, 2] = new Tiles(Colors.Blue, Types.Portal, "35", "\u25BC");
            portals[2] = new Portal("\u25BC", Colors.Blue, 3);
            board[4, 3] = new Tiles(Colors.Blue, Types.Normal, "45", "\u2534");
            board[4, 4] = new Tiles(Colors.Yellow, Types.Normal, "55", "\u2518");
            dungeon[4] = new Tiles(Colors.White, Types.Dungeon, "\u2591");
        }

        /// <summary>
        /// Draws board with ascii characters and color
        /// </summary>
        public void DrawBoard()
        {
            Console.Write("|");
            Console.Write(" ");
            Console.Write("|");
            Console.Write("1");
            Console.Write("|");
            Console.Write("2");
            Console.Write("|");
            Console.Write("3");
            Console.Write("|");
            Console.Write("4");
            Console.Write("|");
            Console.Write("5");
            Console.WriteLine("|");
            //Line 1 
            Console.Write("|");
            Console.Write("1"); ;
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
            Console.Write("2"); ;
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
            Console.Write("3"); ;
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
            Console.Write("4"); ;
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
            Console.Write("5"); ;
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
        /// <summary>
        /// Executes the board 
        /// </summary>

        public void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("| |1|2|3|4|5|");
            for (int l = 0; l < 5; l++) //each line, from 0 till 5
            {
                Console.Write("|{0}", l + 1);
                for (int c = 0; c < 5; c++) //each column, from 0 till 5
                {
                    Console.Write("|");
                    board[l, c].WriteTile();
                }
                Console.Write("|");
                dungeon[l].WriteTile(); // and, finally, the dungeon
                Console.WriteLine("|");
            }

        }

        /// <summary>
        /// PLaces the Ghosts on the board randomly
        /// </summary>
        public void PlaceGhost()
        {
            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (board[l, c].Type == Types.Normal)
                    {
                        randomGhost = new Random();
                        int p = randomGhost.Next(0, 2); //0 = Player 1, 1 = Player 2                    

                        int piece = players[p].CheckFree(board[l, c].Color);

                        while (piece == -1)
                        {
                            p = (p == 0) ? 1 : 0;
                            piece = players[p].CheckFree(board[l, c].Color);
                        }
                        string gh = players[p]
                        .GetGhost(board[l, c].Color, piece);
                        board[l, c].Bkgd = gh;
                        board[l, c].Owner = p + 1;
                    }
                }
            }
        }
        /// <summary>
        /// Rotates between players is the play is successfull
        /// </summary>
        public void Play()
        {
            int cp = 0; //current player
            bool played;

            do
            {
                played = false;
                //check if there are an ghosts on dungeon
                Execute();
                if (HasGhostInDungeon(cp))
                {
                    Console.WriteLine("Player " + players[cp].PlayerNum + " you have ghosts" +
                        " in the dungeon, want to remove? Y/N ");

                    char option = Convert.ToChar(Console.ReadLine());

                    if (option == 'y')
                    {
                        int gh = GetGhostFromDungeon(cp);
                        if (gh > 0)
                        {
                            Tiles tmp = CheckFreeTile(dungeon[gh].Color);
                            if (tmp != null)
                            {
                                tmp.Bkgd = dungeon[gh].Bkgd;

                                dungeon[gh].Bkgd = "\u2591";
                                dungeon[gh].Owner = -1;
                                dungeon[gh].Color = Colors.White;

                                played = true;
                            }
                            else
                            {
                                Console.WriteLine("There is no space no the board");
                                played = false;
                            }

                        }
                    }
                }
                getInput(players[cp].PlayerNum);
                if (!played)
                {
                    getInput(players[cp].PlayerNum);
                }
                cp = (cp == 0) ? 1 : 0;
            } while (!victory);
        }
        /// <summary>
        /// Recieves input from the player in how to play the next turn
        /// </summary>
        /// <param name="cp">It is the current player turn</param>
        public void getInput(int cp)
        {
            Console.WriteLine("Current player = " + cp);
            int n1 = -1, n2 = -1, n3 = -1, n4 = -1;

            do
            {
                Console.WriteLine("What piece do you want to move?");
                do
                {
                    Console.WriteLine("Select Line Number");
                    n1 = Convert.ToInt32(Console.ReadLine()) - 1;
                } while (n1 < 0 || n1 > 4);
                do
                {
                    Console.WriteLine("Select Colum Number");
                    n2 = Convert.ToInt32(Console.ReadLine()) - 1;
                } while (n2 < 0 || n2 > 4);

                if (board[n1, n2].Owner == cp)
                {
                    Console.WriteLine("Where do you want to move?");
                    do
                    {
                        Console.WriteLine("Select Line Number");
                        n3 = Convert.ToInt32(Console.ReadLine()) - 1;
                    } while (n3 < 0 || n3 > 4);
                    do
                    {
                        Console.WriteLine("Select Colum Number");
                        n4 = Convert.ToInt32(Console.ReadLine()) - 1;
                    } while (n4 < 0 || n4 > 4);
                }
                else
                {
                    Console.WriteLine("This piece is not yours " +
                    board[n1, n2].Owner + " / " + cp);
                }
            } while (!validInput(n1, n2, n3, n4));



            //the move is valid, let's check target            
            //check if target is mirror
            if (board[n3, n4].Type == Types.Mirror)
            {
                this.GoMirror(n1, n2, n3, n4);
                return;
            }
            else
            //check if target is portal
            if (board[n3, n4].Type == Types.Portal)
            {
                Console.WriteLine("Player {0} arrived near a portal ", cp);
                this.GoPortal(cp, n1, n2, n3, n4);
                return;
            }

            if (board[n3, n4].Owner == -1)
            {
                board[n3, n4].Bkgd = board[n1, n2].Bkgd;
                board[n3, n4].Color = board[n1, n2].Color;
                board[n3, n4].Owner = board[n1, n2].Owner;
                board[n1, n2].Bkgd = board[n1, n2].DefaultBkgd;
                board[n1, n2].Color = board[n1, n2].DefaultColor;


                return;
            }

            // that's ok, one can move it
            else
            {
                this.Move(n1, n2, n3, n4);

            }

        }
        public bool HasGhostInDungeon(int cp)
        {
            bool hasIt = false;
            for (int i = 0; i < dungeon.Length; i++)
            {
                if (dungeon[i].Owner == players[cp].PlayerNum)
                {
                    hasIt = true;
                    break;
                }
            }
            return hasIt;
        }

        public int GetGhostFromDungeon(int cp)
        {
            for (int i = 0; i < dungeon.Length; i++)
            {
                if (dungeon[i].Owner == players[cp].PlayerNum)
                {
                    Console.Write("\t{0} ", i + 1);
                    dungeon[i].WriteTile();

                }
            }
            Console.WriteLine(" | Type number to choose, or 0 to return");
            return Convert.ToInt32(Console.ReadLine()) - 1;


        }

        public Tiles CheckFreeTile(Colors c)
        {
            for (int line = 0; line < 5; line++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (board[line, col].Owner == -1)
                    {
                        if (board[line, col].Color == c)
                        {
                            if (board[line, col].Type == Types.Normal)
                            {
                                return board[line, col];
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Controls all actions when the player enters a mirror tile
        /// </summary>
        /// <param name="n1">entry line number</param>
        /// <param name="n2">entry colum number</param>
        /// <param name="n3">next line number</param>
        /// <param name="n4">next colum number</param>
        public void GoMirror(int n1, int n2, int n3, int n4)
        {

            Console.WriteLine("You are about to enter a mirror, to which one" +
            "do you want to move to?");

            bool ok = true;
            do
            {
                Console.WriteLine("Select Line Number");
                n3 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Select Colum Number");
                n4 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("tipo = {0}", board[n3, n4].Type);
                if (board[n3, n4].Type != Types.Mirror)
                {
                    Console.WriteLine("That is not a Mirror, try again");
                    ok = false;
                }
                else if (board[n3, n4].Type == Types.Mirror)
                {


                    Console.WriteLine("You entered a mirror, " +
                    " to which mirror do you want to go next?");

                    int mirrorNum = GetMirror(n3, n4);
                    if (mirrorNum >= 0)
                    {
                        board[n3, n4].Bkgd = board[n1, n2].Bkgd;
                        board[n3, n4].Color = board[n1, n2].Color;
                        board[n3, n4].Owner = board[n1, n2].Owner;
                        board[n1, n2].Bkgd = board[n1, n2].DefaultBkgd;
                        board[n1, n2].Owner = -1;
                    }


                }
                Console.WriteLine(" o dono = " + board[n3, n4].Owner);
            } while (!ok);
        }

        /// <summary>
        /// Controls the ghosts when it enters a portal
        /// </summary>
        /// <param name="curPl">current player</param>
        /// <param name="n1">entry line</param>
        /// <param name="n2">entry colum</param>
        /// <param name="n3">next line</param>
        /// <param name="n4">next colum</param>
        public void GoPortal(int curPl, int n1, int n2, int n3, int n4)
        {

            if (board[n1, n2].Color == board[n3, n4].Color)
            {
                int pNum = Portal.GetPortal(n3, n4);
                if (pNum >= 0) // portal number is valid
                {
                    if (portals[pNum].CheckEntrance(pNum, n1, n2) == true)
                    {
                        Console.WriteLine("A Ghost from player {0} " +
                        "went through a portal!", curPl);

                        players[curPl - 1].GhostsOut += 1;
                        if (players[curPl - 1].GhostsOut >= 3)
                        {
                            victory = true;     // call Vitory!                            
                        }
                    }
                }
            }
            board[n1, n2].Owner = -1;
            board[n1, n2].Bkgd = board[n1, n2].DefaultBkgd;
        }


        /// <summary>
        /// Controls the ghosts when they are sent to the dungeon
        /// </summary>
        /// <param name="n1">line position</param>
        /// <param name="n2">colum position</param>
        public void GoDungeon(int n1, int n2)
        {
            int index = -1;
            int length = dungeon.Length;

            for (int i = 0; i < length; i++)
            {
                if (dungeon[i].Owner == -1)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                index = length + 1;
                Array.Resize(ref dungeon, length + 5);
                dungeon[length] = board[n1, n2];
            }

            dungeon[index].Bkgd = board[n1, n2].Bkgd;
            dungeon[index].Owner = board[n1, n2].Owner;
            dungeon[index].Type = board[n1, n2].Type;
            dungeon[index].Color = board[n1, n2].Color;
        }


        public void Move(int n1, int n2, int n3, int n4)
        {
            bool win = false, loose = false;


            //check winner in a fight
            if (board[n1, n2].Color == Colors.Red)
            {
                if (board[n3, n4].Color == Colors.Yellow)
                {
                    loose = true;
                }
                else
                {
                    win = true;
                }
            }

            if (board[n1, n2].Color == Colors.Blue)
            {
                if (board[n3, n4].Color == Colors.Red)
                {
                    loose = true;
                }
                else
                {
                    win = true;
                }
            }

            if (board[n1, n2].Color == Colors.Yellow)
            {
                if (board[n3, n4].Color == Colors.Blue)
                {
                    loose = true;
                }
                else
                {
                    win = true;
                }
            }


            if (loose)
            {
                RotatePortal(n1, n2);
                GoDungeon(n1, n2);
            }
            if (win)
            {
                RotatePortal(n3, n4);
                GoDungeon(n3, n4);
                board[n3, n4].Bkgd = board[n1, n2].Bkgd;
                board[n3, n4].Color = board[n1, n2].Color;
                board[n3, n4].Type = board[n1, n2].Type;
                board[n3, n4].Owner = board[n1, n2].Owner;
            }
            board[n1, n2].Owner = -1;
            board[n1, n2].Bkgd = board[n1, n2].DefaultBkgd;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        /// <param name="n4"></param>
        /// <returns></returns>
        public bool validInput(int n1, int n2, int n3, int n4)
        {
            bool ok = false;

            if (n3 < 0 || n4 < 0)
            {
                return false;
            }
            if (board[n3, n4].Owner == -1)
            {
                return true;
            }

            if (board[n1, n2].Color == board[n3, n4].Color)
            {
                Console.WriteLine("The ghosts have the same color, try again");
                return ok;
            }


            if ((Math.Abs(n1 - n3) == 0) || (Math.Abs(n1 - n3) == 1))
            {
                ok = true;
            }
            else
            {
                Console.WriteLine("You cannot move {0} lines",
                Math.Abs(n1 - n3));
                return false;
            }

            if ((Math.Abs(n2 - n4) == 0) || (Math.Abs(n2 - n4) == 1))
            {
                ok = true;
            }
            else
            {
                Console.WriteLine("You cannot move {0} columns",
                Math.Abs(n2 - n4));

                return false;
            }

            return ok;
        }
        void RotatePortal(int n1, int n2)
        {
            switch (board[n1, n2].Color)
            {
                case Colors.Red:
                    portals[0].Rotate();
                    board[0, 2].Bkgd = portals[0].PBkgd;
                    break;
                case Colors.Yellow:
                    portals[1].Rotate();
                    board[2, 4].Bkgd = portals[1].PBkgd;
                    break;
                case Colors.Blue:
                    portals[2].Rotate();
                    board[4, 2].Bkgd = portals[2].PBkgd;
                    break;
            }
        }
        public int GetMirror(int line, int col)
        {
            if ((line == 1) && (col == 1))
                return 0;
            if ((line == 1) && (col == 3))
                return 1;
            if ((line == 3) && (col == 1))
                return 2;
            if ((line == 3) && (col == 3))
                return 3;
            return -1;
        }
    }
}
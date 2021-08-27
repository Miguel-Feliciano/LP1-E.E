using System;

namespace _18Ghosts
{
    public class Player
    {
        int playerNum;

        /// <summary>
        /// Creates 3 arrays, one for each color to give 3 ghosts of each color
        /// to the players
        /// </summary>
        public Ghost[] Blues = new Ghost[3];
        public Ghost[] Reds = new Ghost[3];
        public Ghost[] Yellows = new Ghost[3];

        public int PlayerNum
        {
            get;

            set;
        }

        public int GhostsOut 
        { 
            get;  
            
            set; 
        }

        /// <summary>
        /// Sets the variable of ghosts that exited to 0
        /// </summary>
        public Player()
        {
            GhostsOut = 0;
        }
        /// <summary>
        /// Creates ghosts for each color as long as their number is lower
        /// than 3
        /// </summary>
        /// <param name="g">Creates the ghosts</param>
        public Player(GhostShape g, int pn)
        {
            GhostsOut = 0;
            for (int i = 0; i < 3; i++)
            {
                Blues[i] = new Ghost(g);
                Reds[i] = new Ghost(g);
                Yellows[i] = new Ghost(g);
            }

            PlayerNum = pn;
        }

        /// <summary>
        /// Sets shapes according to color
        /// </summary>
        /// <param name="c">Gives the color</param>
        /// <param name="p">Gets shape</param>
        /// <returns>The number of ghosts per color and shape</returns>
        public string GetGhost(Colors c, int p)
        {
            Console.WriteLine("Vazio________" + p);
            switch (c)
            {
                case Colors.Blue:
                    Blues[p].InOut = 1;
                    return Blues[p].Shape;
                case Colors.Red:
                    Reds[p].InOut = 1;
                    return Reds[p].Shape;
                case Colors.Yellow:
                    Yellows[p].InOut = 1;
                    return Yellows[p].Shape;
            }
            
            return "";
        }

        /// <summary>
        /// Checks if there is a free space to place a ghost according to the 
        /// color
        /// </summary>
        /// <param name="c">Gets the color of the tile</param>
        /// <returns>If the tile in question is free</returns>
        public int CheckFree(Colors c)
        {
            switch (c)
            {
                case Colors.Blue:
                    for (int i = 0; i < 3; i++)
                    {
                        if (Blues[i].InOut == 0)
                        {
                            return i;
                        }
                    }
                    break;
                case Colors.Red:
                    for (int i = 0; i < 3; i++)
                    {
                        if (Reds[i].InOut == 0)
                        {
                            return i;
                        }
                    }
                    break;
                case Colors.Yellow:
                    for (int i = 0; i < 3; i++)
                    {
                        if (Yellows[i].InOut == 0)
                        {
                            return i;
                        }
                    }
                    break;
            }
            return -1;
        }
        
    }
}
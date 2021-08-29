using System;
using System.Collections;

namespace _18Ghosts
{
    public class Tiles
    {
        Colors color;   // utiliza a enumeração adequada

        Colors dfaultColor;
        Types type;     // utiliza a enumeração adequada
        string addr;

        string bkgd;

        string defaultBkgd;

        int owner; // player number in use

        public Colors Color   // altera a propriedade de acordo com a declaração
        {
            get;

            set;
        }
        public Colors DfaultColor
        {
            get;

            set;
        }
        public Types Type    // altera a propriedade de acordo com a declaração
        {
            get;

            set;
        }

        public string Addr
        {
            get;

            set;
        }
        public string Bkgd
        {
            get;

            set;
        }
        public int Owner
        {
            get;

            set;
        }
        public string DefaultBkgd
        {
            get;

            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public Tiles(Types t)
        {
            Type = t;
            Owner = -1;
        }
        public Tiles(Colors c, Types t, string b)
        {
            Color = c;
            DfaultColor = c;
            Type = t;
            Bkgd = b;
            DefaultBkgd = b;
            Owner = -1;
        }
         public Tiles(Colors c, Types t, string a, string b)
        {
            Color = c;
            DfaultColor = c;
            Type = t;
            Addr = a;
            Bkgd = b;
            DefaultBkgd = b;
            Owner = -1;
        }
    
            char topLeft = (char) 0x250C;
            char topRight = (char) 0x2510;
            char botLeft = (char) 0x2514;
            char botRight = (char) 0x2518;
            char mirror = (char) 0x2229;
            char cross = (char) 0x253C;
            char left = (char) 0x2524;
            char right = (char) 0x251C;
            char up = (char) 0x2534;
            char down = (char) 0x252C;
            char dungeon = (char) 0x2591;

            /// <summary>
            /// Changes the color of the tiles on the board
            /// </summary>
            public void WriteTile()
            {
                if (Color == Colors.Blue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (Color == Colors.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (Color == Colors.Yellow)
                {
                   Console.ForegroundColor = ConsoleColor.Yellow; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; 
                }
                Console.Write(Bkgd);
                Console.ResetColor();
            }
            /// <summary>
            /// Prints the dungeon on the board
            /// </summary>
            public void DungeonChar()
            {
                Console.Write(dungeon);
            }
            
            public char Dungeon
            {
                get
                {
                    return this.dungeon;
                }
                set
                {
                    this.dungeon = value;
                }
            }
    }
}
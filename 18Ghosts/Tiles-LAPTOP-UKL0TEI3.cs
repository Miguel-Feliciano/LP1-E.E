using System;
using System.Collections;

namespace _18Ghosts
{
    public class Tiles
    {
        Colors color;   // utiliza a enumeração adequada
        Types type;     // utiliza a enumeração adequada
        string addr;

        string bkgd;

        public Colors Color     // altera a propriedade de acordo com a declaração
        {
            get;

            set;
        }
        public Types Type      // altera a propriedade de acordo com a declaração
        {
            get;

            set;
        }

        public string Addr
        {
            get;

            set;
        }

        public Tiles(Types t)
        {
            type = t;
        }

        public Tiles(Colors c, Types t, string b)
        {
            color = c;
            type = t;
            bkgd = b;

        }
         public Tiles(Colors c, Types t, string a, string b)
        {
            color = c;
            type = t;
            addr = a;
            bkgd = b;

        }
        public Tiles()
        {
            
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
            char portalUp = (char) 0x25B2;
            char portalDown = (char) 0x25BC;
            char portalLeft = (char) 0x25C4;
            char portalRight = (char) 0x25BA;

            public void WriteTile()
            {
                if (color == Colors.Blue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color == Colors.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color == Colors.Yellow)
                {
                   Console.ForegroundColor = ConsoleColor.Yellow; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; 
                }
                Console.Write(bkgd);
                Console.ResetColor();
            }
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
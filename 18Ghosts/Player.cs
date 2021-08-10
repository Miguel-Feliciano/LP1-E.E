namespace _18Ghosts
{
    public class Player
    {
        string letter;

        public Ghost[] Blues = new Ghost[3];
        public Ghost[] Reds = new Ghost[3];
        public Ghost[] Yellows = new Ghost[3];

        public Player(GhostShape g)
        {
            for (int i = 0; i < 2; i++)
            {
                Blues[i] = new Ghost(g);
                Reds[i] = new Ghost(g);
                Yellows[i] = new Ghost(g);
            }
        }

        public string GetGhost(Colors c, int p)
        {
           switch (c)
           {
               case Colors.Blue:
               return Blues[p].Shape;
               case Colors.Red:
               return Reds[p].Shape;
               case Colors.Yellow:
               return Yellows[p].Shape;
           } 
            return "";
        }
        

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
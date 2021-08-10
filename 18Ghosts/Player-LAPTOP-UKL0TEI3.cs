namespace _18Ghosts
{
    public class Player
    {
        string letter;

        int pA = 1;
        int pB = 2;

        Ghost[] Blues = new Ghost[3];
        Ghost[] Reds = new Ghost[3];
        Ghost[] Yellows = new Ghost[3];

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
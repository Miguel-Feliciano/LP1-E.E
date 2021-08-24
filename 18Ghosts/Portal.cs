using System;

namespace _18Ghosts
{
    public class Portal
    {
            char portalUp = (char) 0x25B2;
            char portalDown = (char) 0x25BC;
            char portalLeft = (char) 0x25C4;
            char portalRight = (char) 0x25BA;

            string pBkgd;

            Colors pColor;

            int pDirection = 0; // 1 = up, 2 = right, 3 = down, 4 = left

            public string PBkgd
            {
                get;

                set;
            }

            public int PDirection
            {
                get;

                set;
            }
            public Portal(string pb, Colors pc, int pd)
            {
                PBkgd = pb;
                pColor = pc;
                PDirection = pd;

            }
    }
}
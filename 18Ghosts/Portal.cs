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

            /// <summary>
            /// Gives portals its background, color and direction
            /// </summary>
            /// <param name="pb">The background of the portal</param>
            /// <param name="pc">The color of the portal</param>
            /// <param name="pd">The direction the portal is facing</param>
            public Portal(string pb, Colors pc, int pd)
            {
                PBkgd = pb;
                pColor = pc;
                PDirection = pd;

            }

            /// <summary>
            /// Rotates portals if a ghost is defeated
            /// </summary>
            public void Rotate()
            {
                if (PDirection == 4)
                {
                    PDirection = 1;
                }
                else
                {
                    PDirection++;
                }

                switch (PDirection)
                {
                    case 1:
                    PBkgd = "\u25B2";
                    break;
                    case 2:
                    PBkgd = "\u25BA";
                    break;
                    case 3:
                    PBkgd = "\u25BC";
                    break;
                    case 4:
                    PBkgd = "\u25C4";
                    break;
                }
            }

        /// <summary>
        /// Checks if the ghost can enter the portal according to the its rotation
        /// </summary>
        /// <param name="portal">The portal that the player is trying to enter</param>
        /// <param name="line">The line where the ghost is</param>
        /// <param name="col">The colum where the ghost is</param>
        /// <returns>Is the ghost can enter the portal</returns>
        public bool CheckEntrance(int portal, int line, int col)
        {
            bool onEntrance = false;

            switch (portal)
            {
                case 0: // portal top
                    {
                        if ((PDirection == 4) && (line == 0) && (col == 1))   //  left
                        {
                            onEntrance = true;
                        }
                        if ((PDirection == 3) && (line == 1) && (col == 2))   // down
                        {
                            onEntrance = true;
                        }
                        if ((PDirection == 2) && (line == 0) && (col == 3))   //  right
                        {
                            onEntrance = true;
                        }
                    }

                    break;
                case 1:  // portal right
                    {
                        if ((PDirection == 1) && (line == 1) && (col == 4))   // up
                        {
                            onEntrance = true;
                        }
                        if ((PDirection == 3) && (line == 3) && (col == 4))   // down
                        {
                            onEntrance = true;
                        }
                        if ((PDirection == 4) && (line == 2) && (col == 3))   // left
                        {
                            onEntrance = true;
                        }
                    }

                    break;
                case 2: // portal down
                    {
                        if ((PDirection == 1) && (line == 3) && (col == 2))   // up
                        {
                            onEntrance = true;
                        }

                        if ((PDirection == 2) && (line == 4) && (col == 1))   //  right
                        {
                            onEntrance = true;
                        }
                        if ((PDirection == 4) && (line == 4) && (col == 3))   // left
                        {
                            onEntrance = true;
                        }
                    }
                    break;          
            }

            return onEntrance;
        }
        /// <summary>
        /// Return the portal number accordingly to the coordenates
        /// </summary>
        /// <param name="line">The line of the portal</param>
        /// <param name="col">The colum of the portal</param>
        /// <returns>The number of the portal according to the coordinates</returns>
        internal static int GetPortal(int line, int col)
        {
            if ((line == 0) && (col == 2))
                return 0;
            if ((line == 2) && (col == 4))
                return 1;
            if ((line == 4) && (col == 2))
                return 2;
            return -1;
        }
    }
}
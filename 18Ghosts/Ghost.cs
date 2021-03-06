using System;

namespace _18Ghosts
{
    public class Ghost
    {
        string color;
        string shape;
        int inOut = 0; //0 = out, 1 = in

        string smile = "\u263A";
        string scarry = "\u263B";
        
        /// <summary>
        /// Sets the corret shape of the ghost to the variable
        /// </summary>
        /// <param name="s">Recives the corretc shape </param>
        public Ghost(GhostShape s)
        {
            if (s == GhostShape.Smile)
            {
                Shape = smile;
            }
            else
            {
                Shape = scarry;
            }
        }
    
        public string Color
        {
            get;

            set;
        }
        public string Shape
        {
            get;

            set;
        }
        public int InOut
        {
            get;

            set;
        }

    }
}
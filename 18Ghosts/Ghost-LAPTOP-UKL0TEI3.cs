using System;

namespace _18Ghosts
{
    public class Ghost
    {
        string color;
        string shape;
        int inOut = 0; //0 = out, 1 = in
        char smile = (char)0x263A;
        char scarry = (char)0x263B;
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
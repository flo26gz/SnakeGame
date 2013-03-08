using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    /*This class represents the model of a snake part */
    class SnakePart
    {
        private int x;
        private int y;
        private int sizeX;
        private int sizeY;
        private viewSnakePart view;
    

        public SnakePart(int x, int y, int sizeX, int sizeY)
        {
           
            this.x = x;
            this.y = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            
            
        }

        /* Getters and setters */
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public int SizeX
        {
            get { return sizeX; }
            set { sizeX = value; }
        }

        public int SizeY
        {
            get { return sizeY; }
            set { sizeY = value; }
        }

        internal viewSnakePart View
        {
            get { return view; }
            set { view = value; }
        }

    }
}

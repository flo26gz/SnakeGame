using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class SnakePart
    {
        private int x;
        private int y;
        private int sizeX;
        private int sizeY;
        private int dir;

        public SnakePart(int x, int y, int sizeX, int sizeY, int dir)
        {
            dir = 0;
            this.x = x;
            this.y = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.dir = dir;
        }

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

        public int Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        

    }
}

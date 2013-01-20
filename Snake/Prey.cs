using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{


    class Prey
    {
        private int x;
        private int y;
        private Boolean state;
        Random random = new Random();

        public Prey()
        {
            x  = random.Next(0, 300);
            y = random.Next(0,300);
            state = false;
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

        public Boolean State
        {
            get { return state; }
            set { state = value; }
        }
     
    }
}

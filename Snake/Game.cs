using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Game
    {

        private List<SnakePart> snake = new List<SnakePart>();


        private const int GRID_X = 16;
        private const int GRID_Y = 14;
        private const int DIR_DOWN = 0;
        private const int DIR_UP = 1;
        private const int DIR_LEFT = 2;
        private const int DIR_RIGHT = 3;

        public Game()
        {
            SnakePart head = new SnakePart(10,10,GRID_X,GRID_Y,DIR_DOWN);
            snake.Add(head);

        }

        internal List<SnakePart> Snake
        {
            get { return snake; }
            set { snake = value; }
        }

        public int GRID_X1
        {
            get { return GRID_X; }
        }

        public int GRID_Y1
        {
            get { return GRID_Y; }
        }

        public int DIR_DOWN1
        {
            get { return DIR_DOWN; }
        }

        public int DIR_UP1
        {
            get { return DIR_UP; }
        }

        public int DIR_LEFT1
        {
            get { return DIR_LEFT; }
        }

        public int DIR_RIGHT1
        {
            get { return DIR_RIGHT; }
        } 
    }
}

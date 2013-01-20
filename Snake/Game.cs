using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Game
    {

        private List<SnakePart> snake = new List<SnakePart>();
        private Prey prey = new Prey();
        private int SIZE_GAME_X;
        private int SIZE_GAME_Y;
        int direction = 0;
        private const int GRID_X = 16;
        private const int GRID_Y = 14;
        private const int DIR_DOWN = 0;
        private const int DIR_UP = 1;
        private const int DIR_LEFT = 2;
        private const int DIR_RIGHT = 3;
        private int score;

        public Game(int sizex, int sizey)
        {
            this.SIZE_GAME_X1 = sizex;
            this.SIZE_GAME_Y1 = sizey;
            score = 0;
            snake.Clear();
            SnakePart head = new SnakePart(10,10,GRID_X,GRID_Y);
            snake.Add(head);
            createPrey();

        }

        public void createPrey()
        {
            int max_x = SIZE_GAME_X1 / GRID_X1;
            int max_y = SIZE_GAME_Y1 / GRID_Y1;
            Random random = new Random();
            prey = new Prey();
            prey.X = random.Next(0, max_x);
            prey.Y = random.Next(0, max_y);
            prey.State = false;
        }

        public void check()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {



                        if (direction ==DIR_DOWN1) Snake[i].Y++;
                        if (direction == DIR_UP1) Snake[i].Y--;
                        if (direction == DIR_LEFT1) Snake[i].X--;
                        if (direction == DIR_RIGHT1) Snake[i].X++;
                    
                    if (snake[i].X == prey.X && snake[i].Y == prey.Y)
                    {
                        SnakePart part = new SnakePart(snake[snake.Count - 1].X, snake[snake.Count - 1].Y, GRID_X, GRID_Y);
                        snake.Add(part);
                        createPrey();
                        score++;

                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;

                }
            }
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

        public int SIZE_GAME_X1
        {
            get { return SIZE_GAME_X; }
            set { SIZE_GAME_X = value; }
        }

        public int SIZE_GAME_Y1
        {
            get { return SIZE_GAME_Y; }
            set { SIZE_GAME_Y = value; }
        }

        internal Prey Prey
        {
            get { return prey; }
            set { prey = value; }
        }


        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        } 
    }
}

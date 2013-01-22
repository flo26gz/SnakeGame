﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Game
    {

        //caca prout

        private List<SnakePart> snake = new List<SnakePart>();
        private Prey prey = new Prey();
        private int SIZE_GAME_X;
        private int SIZE_GAME_Y;
        //horizontal size of a grid
        private const int GRID_X = 16;
        //vertical size of a grid
        private const int GRID_Y = 14;
        //number max of grid
        private int max_x;
        private int max_y;
        Random random;
        //direction
        int direction = 0;
        //Constants for the direction
        private const int DIR_DOWN = 0;
        private const int DIR_UP = 1;
        private const int DIR_LEFT = 2;
        private const int DIR_RIGHT = 3;
        //score
        private int score;
        //Game over
        private Boolean end;

       

        public Game(int sizex, int sizey)
        {
           random = new Random();
            //width of the game 
            this.SIZE_GAME_X1 = sizex;
            //height of the game
            this.SIZE_GAME_Y1 = sizey;
            
            max_x = SIZE_GAME_X1 / GRID_X;
            max_y = SIZE_GAME_Y1 / GRID_Y;
            end = false;
            score = 0;

            snake.Clear();

            //Head of the snake
            SnakePart head = new SnakePart(random.Next(0, max_x), random.Next(0, max_y), GRID_X, GRID_Y);
            //add the head to the List
            snake.Add(head);
            //create a prey
            createPrey();

        }

        public void createPrey()
        {
            /* Create a random prey*/
            prey = new Prey();
            prey.X = random.Next(0, max_x);
            prey.Y = random.Next(0, max_y);
        
        }

        public void check()
        {
            //start by the last part of the snake because the last link will have the location of the link in front of him
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //if it is the head
                if (i == 0)
                {

                        if (direction ==DIR_DOWN1) Snake[i].Y++;
                        if (direction == DIR_UP1) Snake[i].Y--;
                        if (direction == DIR_LEFT1) Snake[i].X--;
                        if (direction == DIR_RIGHT1) Snake[i].X++;

                        if (snake[i].X < 0 || snake[i].X >= max_x || snake[i].Y < 0 || snake[i].Y >= max_y)    end = true;
                        // we go through all the snake to check if the location head is equal to the location of another link of the snake
                        for (int j = 1; j < snake.Count; j++) if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)   end = true;

                    //If the snake has eaten a prey
                    if (snake[i].X == prey.X && snake[i].Y == prey.Y)
                    {
                        //We create a new part whose the location is the last link of the snake
                        SnakePart part = new SnakePart(snake[snake.Count - 1].X, snake[snake.Count - 1].Y, GRID_X, GRID_Y);
                        snake.Add(part);
                        //create a new prey
                        createPrey();
                        //increase the score
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

        /*Getters and Setters*/
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

        public Boolean End
        {
            get { return end; }
            set { end = value; }
        }
    }
}

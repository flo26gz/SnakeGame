using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    /*This class represents a game  */
    class Game
    {

        /*variables */
        private List<SnakePart> snake;
        private Apple apple;
        private Panel snakePanel;
        private viewSnake viewSnake;
        private viewApple viewApple;

        private int SIZE_GAME_X;
        private int SIZE_GAME_Y;

        //horizontal size of a grid
        private const int GRID_X = 16;
        //vertical size of a grid
        private const int GRID_Y = 14;

        //number max of horizontal grid
        private int max_x;
        //number max of vertical grid
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
       
    
        /*Constructor */
        public Game(int sizex, int sizey, Panel panel)
        {
            /*Instantiations */
            snake = new List<SnakePart>();
            apple = new Apple();
            this.snakePanel = panel;
            viewSnake = new viewSnake(snake,snakePanel);
           

           random = new Random();

            //width of snakePanel 
            this.SIZE_GAME_X = sizex;
            //height of the snakePanel
            this.SIZE_GAME_Y = sizey;
            
            max_x = SIZE_GAME_X / GRID_X;
            max_y = SIZE_GAME_Y / GRID_Y;
           
            end = false;
            score = 0;
           
            //clear the list if we do another game
            snake.Clear();

            //We start the game by creating the head of the snake
            SnakePart head = new SnakePart(random.Next(0, max_x), random.Next(0, max_y), GRID_X, GRID_Y);
            //add the head to the List
            snake.Add(head);
            //create the view of the head
            viewSnake.createViewPart(head);
            //create food
            viewApple = new viewApple(apple,snakePanel);
            createApple();
            
            
        }

        /*function to create an apple */
        public void createApple()
        {
            /* Create a random apple*/
            apple.X = random.Next(0, max_x);
            apple.Y = random.Next(0, max_y);
            apple.SizeX = GRID_X;
            apple.SizeY = GRID_Y;
         
            //change the coordinate of the pictureBox that represents an apple
            viewApple.updateViewApple();
        
        }

        /*function to test if an something happened or just move the snake */
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

                        //update snake view 
                        viewSnake.updateViewSnake();
                        if (snake[i].X < 0 || snake[i].X >= max_x || snake[i].Y < 0 || snake[i].Y >= max_y)    end = true;
                        // we go through all the snake to check if the location head is equal to the location of another link of the snake
                        for (int j = 1; j < snake.Count; j++) if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)   end = true;

                        //If the snake has eaten a prey
                        if (snake[i].X == apple.X && snake[i].Y == apple.Y)
                        {
                            //We create a new part whose the location is the last link of the snake
                            SnakePart part = new SnakePart(snake[snake.Count - 1].X, snake[snake.Count - 1].Y, GRID_X, GRID_Y);
                            snake.Add(part);
                            viewSnake.createViewPart(part);
                            //create a new prey
                            createApple();
                            //increase the score
                            score++;

                        }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                    //update snake view
                    viewSnake.updateViewSnake();

                }
            }
        }

        /*function to clear the snake */
        public void clearSnake()
        {
            viewSnake.clearViewSnake();
        }

        /*function to clear an apple */
        public void clearApple()
        {
            viewApple.clearViewApple();
        }

        /*Getters and Setters*/
        internal List<SnakePart> Snake
        {
            get { return snake; }
            set { snake = value; }
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

        internal Apple Apple
        {
            get { return apple; }
            set { apple = value; }
        }

    }
}

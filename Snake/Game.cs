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
        private List<Apple> badApple;
        private Apple apple;
        private Apple goldApple;
        private Panel snakePanel;
        private viewSnake viewSnake;
        private viewApple viewApple;
        private viewApple viewGoldApple;

        private int SIZE_GAME_X;
        private int SIZE_GAME_Y;

        //horizontal size of a grid
        private const int GRID_X = 20;
        //vertical size of a grid
        private const int GRID_Y = 18;

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

        //Apple Type
        private const int RED_APPLE = 1;
        private const int GOLD_APPLE = 2;
        private const int PURPLE_APPLE = 3;
        //score
        private int score;
        //Game over
        private Boolean end;
        //count
        private int nb_red_apple;

        private int nb_gold_apple;
        private int nb_purple_apple;
    
        /*Constructor */
        public Game(int sizex, int sizey, Panel panel)
        {
            /*Instantiations */
            snake = new List<SnakePart>();
            badApple = new List<Apple>();
            apple = new Apple();
            goldApple = new Apple();

            this.snakePanel = panel;
            viewSnake = new viewSnake(snake,snakePanel);

            nb_gold_apple = 0;
            nb_purple_apple = 0;
            nb_red_apple = 0;

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
            viewGoldApple = new viewApple(goldApple, snakePanel);
            createApple();
            
            
        }

        /*function to create an apple */
        public void createApple()
        {
            
            /* Create a random apple*/
            apple.Type = RED_APPLE;
            isValidLocation(apple);
            apple.SizeX = GRID_X;
            apple.SizeY = GRID_Y;
            //change the coordinate of the pictureBox that represents an apple
            viewApple.updateViewApple();
        
        }

        /*function to create purple apple */
        public void createPurpleApple()
        {
            Apple purpleApple = new Apple();
            /* Create a random apple*/
            purpleApple.Type = PURPLE_APPLE;
            isValidLocation(purpleApple);
            purpleApple.SizeX = GRID_X;
            purpleApple.SizeY = GRID_Y;
           

            viewApple vApple = new viewApple(purpleApple, snakePanel);
            badApple.Add(purpleApple);
            nb_purple_apple++;
            //change the coordinate of the pictureBox that represents an apple
            vApple.updateViewApple();

        }

        /*function to create purple apple */
        public void createGoldApple()
        {
          
            
            /* Create a random apple*/
            goldApple.Type = GOLD_APPLE;
            isValidLocation(goldApple);
            goldApple.SizeX = GRID_X;
            goldApple.SizeY = GRID_Y;
           

            
            //change the coordinate of the pictureBox that represents an apple
           viewGoldApple.updateViewApple();
           displayGoldApple();

        }

        public void hideGoldApple()
        {
            goldApple.X = -5;
            goldApple.Y = -5;
            viewGoldApple.hideApple();
        }

        public void displayGoldApple()
        {
            viewGoldApple.displayApple();
        }

        public void isValidLocation(Apple app)
        {
            app.X = random.Next(0, max_x);
            app.Y = random.Next(0, max_y);

            for (int i = 0; i < snake.Count; i++)
            {
                if (snake[i].X == app.X && snake[i].Y == app.Y)
                {
                    app.X = random.Next(0, max_x);
                    app.Y = random.Next(0, max_y);
                    i = 0;
                }

                if (app.Type == 2) 
                {
                    if (app.X == apple.X && app.Y == apple.Y) {
                        app.X = random.Next(0, max_x);
                        app.Y = random.Next(0, max_y);
                        i = 0;
                    }
                    
                    for (int j = 0; j < badApple.Count; j++)
                    {
                        if (app.X == badApple[j].Y && app.Y == badApple[j].Y)
                        {
                            app.X = random.Next(0, max_x);
                            app.Y = random.Next(0, max_y);
                            i = 0;
                            j = 0;
                        }
                    }
                }

                else if (app.Type == 3)
                {
                    if (app.X == apple.X && app.Y == apple.Y)
                    {
                        app.X = random.Next(0, max_x);
                        app.Y = random.Next(0, max_y);
                        i = 0;
                    }

                    if (app.X == goldApple.X && app.Y == goldApple.Y)
                    {
                        app.X = random.Next(0, max_x);
                        app.Y = random.Next(0, max_y);
                        i = 0;
                    }
                }

                else
                {
                    if (app.X == goldApple.X && app.Y == goldApple.Y)
                    {
                        app.X = random.Next(0, max_x);
                        app.Y = random.Next(0, max_y);
                        i = 0;
                    }

                    for (int j = 0; j < badApple.Count; j++)
                    {
                        if (app.X == badApple[j].Y && app.Y == badApple[j].Y)
                        {
                            app.X = random.Next(0, max_x);
                            app.Y = random.Next(0, max_y);
                            i = 0;
                            j = 0;
                        }
                    }
                }
            }
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

                        for (int k = 0; k < badApple.Count; k++) if (snake[i].X == badApple[k].X && snake[i].Y == badApple[k].Y) end = true;

                        //If the snake has eaten a prey
                        if ((snake[i].X == apple.X && snake[i].Y == apple.Y) || (snake[i].X == goldApple.X && snake[i].Y == goldApple.Y))
                        {
                            
                      
                                //We create a new part whose the location is the last link of the snake
                                SnakePart part = new SnakePart(snake[snake.Count - 1].X, snake[snake.Count - 1].Y, GRID_X, GRID_Y);
                                snake.Add(part);
                                viewSnake.createViewPart(part);
                               

                                if (score != 0 && nb_red_apple % 3 == 0) createPurpleApple();
                                //increase the score
                                if (snake[i].X == apple.X && snake[i].Y == apple.Y)
                                {
                                    score++;
                                    nb_red_apple++;
                                }
                                if (snake[i].X == goldApple.X && snake[i].Y == goldApple.Y)
                                {
                                    score += 5;
                                    nb_gold_apple++;
                                    hideGoldApple();
                                }
                                //create a new prey
                                if (score != 0 && nb_red_apple % 6 == 0) createGoldApple();
                                createApple();
                               

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

        public int Nb_red_apple
        {
            get { return nb_red_apple; }
            set { nb_red_apple = value; }
        }

        public int Nb_gold_apple
        {
            get { return nb_gold_apple; }
            set { nb_gold_apple = value; }
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

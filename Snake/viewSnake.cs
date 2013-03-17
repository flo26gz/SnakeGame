using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    /*This class represents the view of the entire snake */
    class viewSnake
    {
        List<SnakePart> snake;
        System.Windows.Forms.Panel snakePanel;

        /*Constructor */
        public viewSnake(List<SnakePart> snake, System.Windows.Forms.Panel snakePanel)
        {
            this.snake = snake;
            this.snakePanel = snakePanel;
        }

        /*function to add a pictureBox to our snake */
        public void createViewPart(SnakePart part)
        {
            //we instantiate a new viewSnakePart, this object is the view for a pictureBox
            viewSnakePart viewSnakePart = new viewSnakePart(part);
            if (snake.Count == 1)
            {
                viewSnakePart.drawHead();
                viewSnakePart.PBox.Refresh();
            }
            //We link this viewSnakePart to our SnakePart ==> very important to update the right pictureBox
            part.View = viewSnakePart;
            //we add this pictureBox to our Panel
            snakePanel.Controls.Add(viewSnakePart.PBox);
        }

        /*function to update the coordinate of all the pictureBox (our snake) */
        public void updateViewSnake()
        {
            for (int i = 0; i < snake.Count; i++)
            {
                snake[i].View.PBox.Left = snake[i].X * snake[i].SizeX;
                snake[i].View.PBox.Top = snake[i].Y * snake[i].SizeY;
            }
        }

        /*Hide the picture box if we want to do another game */
        public void clearViewSnake()
        {
            for (int i = 0; i < snake.Count; i++) snake[i].View.PBox.Hide();
        }

 
    }
}

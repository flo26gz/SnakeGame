using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    /*This class represents the view of an apple */
    class viewApple
    {
        private System.Windows.Forms.PictureBox pBox;
        private Apple apple;
        System.Windows.Forms.Panel snakePanel;

        /*function to initialize and add our picture box, which reprensents the Apple for the snake */
        public void init()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pBox.BackColor = System.Drawing.Color.Yellow;
            this.pBox.Location = new System.Drawing.Point(apple.X*apple.SizeX, apple.Y*apple.SizeY);
            this.pBox.Margin = new System.Windows.Forms.Padding(4);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(apple.SizeX, apple.SizeY);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Visible=true;
            snakePanel.Controls.Add(pBox);
            
        }

        /*Constructor */
        public viewApple(Apple apple, System.Windows.Forms.Panel snakePanel)
        {
            this.apple = apple;
            this.snakePanel = snakePanel;
            init();
            
        }

        public void updateViewApple()
        {
            pBox.Left = apple.X *apple.SizeX;
            pBox.Top = apple.Y *apple.SizeY;
            pBox.Width = apple.SizeX;
            pBox.Height = apple.SizeY;
            if (apple.Type == 1) drawRedApple();
            else if (apple.Type == 2) drawGoldApple();
            else drawPurpleApple();
        }

        public void drawRedApple()
        {
            //transparent color
            this.pBox.BackColor = Color.Transparent;
            //set image background
            this.pBox.BackgroundImage = Image.FromFile("C:\\Users\\Florian Ganzin\\Pictures\\red_apple.png");
            //center image
            this.pBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void drawGoldApple()
        {
            //transparent color
            this.pBox.BackColor = Color.Transparent;
            //set image background
            this.pBox.BackgroundImage = Image.FromFile("C:\\Users\\Florian Ganzin\\Pictures\\gold_apple.png");
            //center image
            this.pBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void drawPurpleApple()
        {
            //transparent color
            this.pBox.BackColor = Color.Transparent;
            //set image background
            this.pBox.BackgroundImage = Image.FromFile("C:\\Users\\Florian Ganzin\\Pictures\\purple_apple.png");
            //center image
            this.pBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void hideApple()
        {
            snakePanel.Controls.Remove(pBox);
        }

        public void displayApple()
        {
            snakePanel.Controls.Add(pBox);
        }

        /*Clear the apple if we want to do another game */
        public void clearViewApple()
        {
            pBox.Hide();
        }

        public System.Windows.Forms.PictureBox PBox
        {
            get { return pBox; }
            set { pBox = value; }
        }

    }
}

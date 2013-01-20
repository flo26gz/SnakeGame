using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            
          
        }

        private void playButton_Click(object sender, EventArgs e)
        {
         Controls.Clear();
         Controls.Add(this.mainGamePanel);
         game = new Game();
         this.timer1.Enabled = true;
         this.timer1.Start();
         //this.playButton.Focus();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.playButton.Location = new System.Drawing.Point(x, y);
            //if ((x+165) == this.mainIntroPanel.Width) x = 0;
            //if (y == SIZE_Y) y = 0;
            //this.x++;
            for (int i = 0; i < game.Snake.Count; i++)
            {
                if (game.Snake[i].Dir == game.DIR_DOWN1) game.Snake[i].Y++;
                if (game.Snake[i].Dir == game.DIR_UP1) game.Snake[i].Y--;
                if (game.Snake[i].Dir == game.DIR_LEFT1) game.Snake[i].X--;
                if (game.Snake[i].Dir == game.DIR_RIGHT1) game.Snake[i].X++;
            }
            this.pBoxGame.Invalidate();
           
            
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)122:
                    for (int i = 0; i < game.Snake.Count; i++)
                    {
                        game.Snake[i].Dir = game.DIR_UP1;
                    }
                break;
                case (char)115: 
                for (int i = 0; i < game.Snake.Count; i++)
                {
                    game.Snake[i].Dir = game.DIR_DOWN1;
                }
                break;
                case (char)113: 
                for (int i = 0; i < game.Snake.Count; i++)
                {
                    game.Snake[i].Dir = game.DIR_LEFT1;
                }
                break;//gauche
                case (char)100: 
                for (int i = 0; i < game.Snake.Count; i++)
                {
                    game.Snake[i].Dir = game.DIR_RIGHT1;
                }
                break;//droite
             

            }
        }
        private void pBoxGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics pBox = e.Graphics;
            for (int i = 0; i < game.Snake.Count; i++)
            {
                Brush color = Brushes.Black;
                pBox.FillRectangle(color, new Rectangle(game.Snake[i].X * game.GRID_X1, game.Snake[i].Y * game.GRID_Y1, game.GRID_X1, game.GRID_Y1));
            }
            
        }




    }
}

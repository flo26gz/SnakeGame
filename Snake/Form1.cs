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
         this.timer1.Enabled = true;
         this.timer1.Start();
         game = new Game();

         //this.playButton.Focus();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.playButton.Location = new System.Drawing.Point(x, y);
            //if ((x+165) == this.mainIntroPanel.Width) x = 0;
            //if (y == SIZE_Y) y = 0;
            //this.x++;
            this.pBoxGame.Invalidate();
           
            
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)122: this.y--; break;
                case (char)115: this.y++; break;
                case (char)113: this.x--; break;
                case (char)100: this.x++; break;
             

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

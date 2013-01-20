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
         //remove all the components from the intro menu
         Controls.Clear();
         //add the game panel to the window
         Controls.Add(this.mainGamePanel);
         //start a game
         game = new Game(pBoxGame.Size.Width,pBoxGame.Size.Height);
         //enable and start the timer
         this.timer1.Enabled = true;
         this.timer1.Start();
         

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //update the snake
            game.check();
            //repaint the pictureBox
            this.pBoxGame.Invalidate();
            //refresh the score
            this.scoreLabel.Text = "Score : " + game.Score;
            if (game.End == true)
            {
                this.timer1.Stop();
                this.res = MessageBox.Show("You loose ! Do you want to start a new game ?", "Game Over", MessageBoxButtons.YesNo);
                if (this.res == DialogResult.Yes)
                {
                    Controls.Clear();
                    
                    Controls.Add(this.mainIntroPanel);

                }
                else Application.Exit();
            }
            
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //UP
                case (char)122:
                 // this test allows us to test that the snake doesn't go in the wrong side 
                if (game.Snake.Count < 2 || game.Snake[0].Y == game.Snake[1].Y)
                        game.Direction = game.DIR_UP1;
                    
                break;
                case (char)115:
                if (game.Snake.Count < 2 || game.Snake[0].Y == game.Snake[1].Y)
                    game.Direction = game.DIR_DOWN1;
                
                break;
                case (char)113:
                if (game.Snake.Count < 2 || game.Snake[0].X == game.Snake[1].X)
                    game.Direction = game.DIR_LEFT1;
                
                break;//gauche
                case (char)100:
                if (game.Snake.Count < 2 || game.Snake[0].X == game.Snake[1].X)
                    game.Direction = game.DIR_RIGHT1;
                
                break;//droite
             

            }
        }
        private void pBoxGame_Paint(object sender, PaintEventArgs e)
        {
            //object for drawing
            Graphics pBox = e.Graphics;
            Brush colorprey = Brushes.Yellow;
            for (int i = 0; i < game.Snake.Count; i++)
            {
                Brush color = Brushes.Black;
               //draw a black rectangle for the snake part
                pBox.FillRectangle(color, new Rectangle(game.Snake[i].X * game.GRID_X1, game.Snake[i].Y * game.GRID_Y1, game.GRID_X1, game.GRID_Y1));
            }
            //draw an ellipse for the prey
            pBox.FillEllipse(colorprey, game.Prey.X * game.GRID_X1, game.Prey.Y * game.GRID_Y1, game.GRID_X1, game.GRID_Y1);
            
        }




    }
}

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
         
         game = new Game(snakePanel.Size.Width,snakePanel.Size.Height, snakePanel);
         //enable and start the timer
         this.timer1.Enabled = true;
         this.timer1.Start();
         

        }

        /*function to manage timer */
        private void timer1_Tick(object sender, EventArgs e)
        {
            //update the snake
            game.check();
            //repaint the pictureBox
            this.snakePanel.Refresh();
            //repaint the game Panel
            this.mainGamePanel.Refresh();
            //refresh the score
            this.scoreLabel.Text = "Score : " + game.Score;
        
            //if game over
            if (game.End == true)
            {
                this.timer1.Stop();
                this.res = MessageBox.Show("You loose ! Do you want to start a new game ?", "Game Over", MessageBoxButtons.YesNo);

                if (this.res == DialogResult.Yes)
                {
                    Controls.Clear();
                    game.clearApple();
                    game.clearSnake();
                    Controls.Add(this.mainIntroPanel);

                }
                else Application.Exit();
            }
             
            
        }

        /*function to manage keyboard event */
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

    }
}

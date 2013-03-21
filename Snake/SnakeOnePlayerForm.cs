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
    public partial class SnakeOnePlayerForm : Form
    {
        private Game game;
        private DialogResult res;
        MenuForm menu;
        

        public SnakeOnePlayerForm()
        {
            InitializeComponent();
            game = new Game(snakePanel.Size.Width, snakePanel.Size.Height, snakePanel);
            //enable and start the timer
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update the snake
            game.check();         

            //refresh the score
            this.scoreLabel.Text = "Score : " + game.Score;
            this.appleLabel.Text = "Apple : " + game.Nb_red_apple;
            this.goldLabel.Text = "Gold Apple : " + game.Nb_gold_apple;

            //if game over
            if (game.End == true)
            {
                this.timer1.Stop();
                this.res = MessageBox.Show("You loose ! Do you want to start a new game ?", "Game Over", MessageBoxButtons.YesNo);

                if (this.res == DialogResult.Yes)
                {

                    menu = new MenuForm();
                    menu.ShowDialog();
                    this.Close();

                }
                else Application.Exit();
            }
        }

        /*function to manage keyboard event */
        void snake_KeyPress(object sender, KeyPressEventArgs e)
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

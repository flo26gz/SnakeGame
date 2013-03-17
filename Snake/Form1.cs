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
        //panel that contains all the options and score for the snake (left side of the game)
        private System.Windows.Forms.Panel toolPanel;
        //main panel of the game window that contains the score  + the snakePanel
        private System.Windows.Forms.Panel mainGamePanel;
        //panel that contains our snake and apple (the game)
        private System.Windows.Forms.Panel snakePanel;
        //score
        private System.Windows.Forms.Label scoreLabel;
        //To get the choice of the user at the end of the game(messageBox)
        private DialogResult res;


        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
         //remove all the components from the intro menu
         Controls.Clear();
         myComponents();
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

        public void myComponents()
        {
            // 
            // scoreLabel
            // 
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Green;
            this.scoreLabel.Location = new System.Drawing.Point(10, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(123, 29);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score : 0";
            // 
            // toolPanel
            // 
            this.toolPanel = new System.Windows.Forms.Panel();
            this.toolPanel.BackColor = System.Drawing.Color.Wheat;
            this.toolPanel.Controls.Add(this.scoreLabel);
            this.toolPanel.Location = new System.Drawing.Point(-1, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(178, 504);
            this.toolPanel.TabIndex = 0;
            // 
            // snakePanel
            // 
            this.snakePanel = new System.Windows.Forms.Panel();
            this.snakePanel.BackColor = System.Drawing.Color.Gray;
            this.snakePanel.Location = new System.Drawing.Point(177, 0);
            this.snakePanel.Name = "snakePanel";
            this.snakePanel.Size = new System.Drawing.Size(560, 504);
            this.snakePanel.TabIndex = 0;
            // 
            // mainGamePanel
            // 
            this.mainGamePanel = new System.Windows.Forms.Panel();
            this.mainGamePanel.BackColor = System.Drawing.Color.Azure;
            this.mainGamePanel.Controls.Add(this.snakePanel);
            this.mainGamePanel.Controls.Add(this.toolPanel);
            this.mainGamePanel.Location = new System.Drawing.Point(-1, 0);
            this.mainGamePanel.Name = "mainGamePanel";
            this.mainGamePanel.Size = new System.Drawing.Size(737, 504);
            this.mainGamePanel.TabIndex = 0;



        }

        private void gameLabel_Click(object sender, EventArgs e)
        {
            this.gameLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.ruleLabel.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Visible = true;
            this.optionButton.Visible = true;
            this.contentRulesLabel.Visible = false;
        }

        private void ruleLabel_Click(object sender, EventArgs e)
        {
            this.ruleLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.gameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Visible = false;
            this.optionButton.Visible = false;
            this.contentRulesLabel.Visible = true;
        }

        private void creditsLabel_Click(object sender, EventArgs e)
        {

        }

        private void removeColorBackground(object sender, EventArgs e)
        {
            this.gameLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void addColorBackground(object sender, EventArgs e)
        {
            this.gameLabel.BackColor = System.Drawing.Color.DarkGreen;
        }


    }
}

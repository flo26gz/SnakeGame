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
    public partial class MenuForm : Form
    {
        private System.Windows.Forms.Label contentRulesLabel;
        private SnakeOnePlayerForm snakeOnePlayer;
        

        public MenuForm()
        {
            InitializeComponent();
            myComponents();
           
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            snakeOnePlayer = new SnakeOnePlayerForm();
    
            snakeOnePlayer.ShowDialog();

            


        }

        public void myComponents()
        {

            // contentRulesLabel
            // 
            this.contentRulesLabel = new System.Windows.Forms.Label();
            this.contentRulesLabel.AutoSize = true;
            this.contentRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentRulesLabel.ForeColor = System.Drawing.Color.White;
            this.contentRulesLabel.Location = new System.Drawing.Point(3, 1);
            this.contentRulesLabel.Name = "contentRulesLabel";
            this.contentRulesLabel.Size = new System.Drawing.Size(365, 160);
            this.contentRulesLabel.TabIndex = 7;
            this.contentRulesLabel.Text = "Rules :\r\n\r\n- The goal of the game is to have the highest score\r\n\r\n- If you touch " +
                "the walls, this is the end of the game\r\n\r\nGood Luck !\r\n\r\n";
            this.contentRulesLabel.Visible = false;
            this.sousMenu3Panel.Controls.Add(this.contentRulesLabel);




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

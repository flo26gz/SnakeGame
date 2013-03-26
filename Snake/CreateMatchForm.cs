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
    public partial class CreateMatchForm : Form
    {
        private Network network;
        SnakeOnePlayerForm snake;

        public CreateMatchForm(String name)
        {
            InitializeComponent();
            network = new Network(name);
            network.createMatch();
            this.createLabel2.Text = network.HostPlayer;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!network.OpponentPlayer.Equals("nothing"))
            {
                this.opponentLabel2.Text = network.OpponentPlayer;
                this.startButton.Enabled = true;
                this.timer1.Enabled = false;
                snake = new SnakeOnePlayerForm();
                 
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

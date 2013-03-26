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
    public partial class JoinMatchForm : Form
    {
        private Network network;
        

        public JoinMatchForm(String name)
        {
            InitializeComponent();
            network = new Network(name);   
            network.joinMatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!network.OpponentPlayer.Equals("nothing"))
                this.availableLabel2.Text = network.OpponentPlayer;
        }

    }
}

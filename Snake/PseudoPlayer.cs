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
    public partial class PseudoPlayer : Form
    {
        Lobby lobby;
        public PseudoPlayer()
        {
            InitializeComponent();
        }

        private void namePlayerUserControl1_BoutonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namePlayerUserControl1_BoutonValidClick(object sender, EventArgs e)
        {
            lobby = new Lobby(this.namePlayerUserControl1.getTB().Text);
            lobby.ShowDialog();
            
        }

    }
}

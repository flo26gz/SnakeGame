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
    public partial class Lobby : Form
    {
        //private Network network;
        private CreateMatchForm createMatch;
        private JoinMatchForm joinMatch;
        private String namePlayer;
        public Lobby(String name)
        {
            InitializeComponent();
            namePlayer = name;

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createMatch = new CreateMatchForm(namePlayer);
            createMatch.ShowDialog();
          
            
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            joinMatch = new JoinMatchForm(namePlayer);
            joinMatch.ShowDialog();
        }

    }
}

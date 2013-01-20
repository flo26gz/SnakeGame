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
         game = new Game(pBoxGame.Size.Width,pBoxGame.Size.Height);
         this.timer1.Enabled = true;
         this.timer1.Start();
         

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
   
            game.check();
            this.pBoxGame.Invalidate();
           
            
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)122:
                 
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
            Graphics pBox = e.Graphics;
            Brush colorprey = Brushes.Yellow;
            for (int i = 0; i < game.Snake.Count; i++)
            {
                Brush color = Brushes.Black;
                pBox.DrawString("coord :  " + game.Snake[i].X, this.Font, Brushes.White, new PointF(4*i, 4*i));
                pBox.FillRectangle(color, new Rectangle(game.Snake[i].X * game.GRID_X1, game.Snake[i].Y * game.GRID_Y1, game.GRID_X1, game.GRID_Y1));
            }

            pBox.FillEllipse(colorprey, game.Prey.X * game.GRID_X1, game.Prey.Y * game.GRID_Y1, game.GRID_X1, game.GRID_Y1);
            
        }




    }
}

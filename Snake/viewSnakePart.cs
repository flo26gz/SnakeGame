using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    /*This class represents the view of a snake part */
    class viewSnakePart
    {
        private System.Windows.Forms.PictureBox pBox;
      

        /*Constructor */
        public viewSnakePart(SnakePart part)
        {
    
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pBox.BackColor = System.Drawing.Color.Black;
         
            //pBox.Size = pBox.BackgroundImage.Size;
            this.pBox.Location = new System.Drawing.Point(part.X*part.SizeX, part.Y*part.SizeY);
            this.pBox.Margin = new System.Windows.Forms.Padding(4);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(part.SizeX, part.SizeY);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            
        }

        public void drawHead(){
            //transparent color
            this.pBox.BackColor = Color.Transparent;
            //set image background
            this.pBox.BackgroundImage = Image.FromFile("C:\\Users\\Florian Ganzin\\Pictures\\snakeHead.png");
            //center image
            this.pBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public System.Windows.Forms.PictureBox PBox
        {
            get { return pBox; }
            set { pBox = value; }
        }

    }
}

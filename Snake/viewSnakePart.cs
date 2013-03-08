using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            this.pBox.Location = new System.Drawing.Point(part.X*part.SizeX, part.Y*part.SizeY);
            this.pBox.Margin = new System.Windows.Forms.Padding(4);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(part.SizeX, part.SizeY);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            
        }

        public System.Windows.Forms.PictureBox PBox
        {
            get { return pBox; }
            set { pBox = value; }
        }

    }
}

namespace Snake
{
    partial class SnakeOnePlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.snakePanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.goldLabel = new System.Windows.Forms.Label();
            this.appleLabel = new System.Windows.Forms.Label();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.topBorder = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bottomBorder = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rightBorder = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.leftBorder = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // snakePanel
            // 
            this.snakePanel.BackgroundImage = global::Snake.Properties.Resources.green_back;
            this.snakePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snakePanel.Location = new System.Drawing.Point(184, 5);
            this.snakePanel.Name = "snakePanel";
            this.snakePanel.Size = new System.Drawing.Size(560, 504);
            this.snakePanel.TabIndex = 0;
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.Tan;
            this.toolPanel.Controls.Add(this.goldLabel);
            this.toolPanel.Controls.Add(this.appleLabel);
            this.toolPanel.Controls.Add(this.statisticLabel);
            this.toolPanel.Controls.Add(this.scoreLabel);
            this.toolPanel.Controls.Add(this.playerLabel);
            this.toolPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(178, 515);
            this.toolPanel.TabIndex = 1;
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.goldLabel.Location = new System.Drawing.Point(16, 227);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(128, 20);
            this.goldLabel.TabIndex = 4;
            this.goldLabel.Text = "Gold Apple :  0";
            // 
            // appleLabel
            // 
            this.appleLabel.AutoSize = true;
            this.appleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.appleLabel.Location = new System.Drawing.Point(16, 184);
            this.appleLabel.Name = "appleLabel";
            this.appleLabel.Size = new System.Drawing.Size(85, 20);
            this.appleLabel.TabIndex = 3;
            this.appleLabel.Text = "Apple :  0";
            // 
            // statisticLabel
            // 
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statisticLabel.Location = new System.Drawing.Point(16, 128);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(91, 24);
            this.statisticLabel.TabIndex = 2;
            this.statisticLabel.Text = "Statictics";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.scoreLabel.Location = new System.Drawing.Point(16, 60);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 20);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score :  0";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.playerLabel.Location = new System.Drawing.Point(16, 21);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(68, 24);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topBorder,
            this.bottomBorder,
            this.rightBorder,
            this.leftBorder});
            this.shapeContainer1.Size = new System.Drawing.Size(750, 515);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.Black;
            this.topBorder.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.topBorder.Location = new System.Drawing.Point(178, 0);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(568, 5);
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.Black;
            this.bottomBorder.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bottomBorder.Location = new System.Drawing.Point(178, 509);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(572, 5);
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.Black;
            this.rightBorder.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rightBorder.Location = new System.Drawing.Point(744, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(9, 517);
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.Black;
            this.leftBorder.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.leftBorder.Location = new System.Drawing.Point(178, -2);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(7, 514);
            // 
            // SnakeOnePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 515);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.snakePanel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "SnakeOnePlayerForm";
            this.Text = "SnakeOnePlayer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.snake_KeyPress);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel snakePanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topBorder;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bottomBorder;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rightBorder;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape leftBorder;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label appleLabel;
        private System.Windows.Forms.Label statisticLabel;
      
    }
}
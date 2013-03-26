namespace Snake
{
    partial class PseudoPlayer
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
            this.namePlayerUserControl1 = new Snake.NamePlayerUserControl();
            this.SuspendLayout();
            // 
            // namePlayerUserControl1
            // 
            this.namePlayerUserControl1.Location = new System.Drawing.Point(11, 12);
            this.namePlayerUserControl1.LoginText = "Player\'s Name :";
            this.namePlayerUserControl1.Name = "namePlayerUserControl1";
            this.namePlayerUserControl1.Size = new System.Drawing.Size(261, 136);
            this.namePlayerUserControl1.TabIndex = 0;
            this.namePlayerUserControl1.BoutonValidClick += new Snake.NamePlayerUserControl.ValidButtonClickHandler(this.namePlayerUserControl1_BoutonValidClick);
            this.namePlayerUserControl1.BoutonCancelClick += new Snake.NamePlayerUserControl.CancelButtonClickHandler(this.namePlayerUserControl1_BoutonCancelClick);
            // 
            // PseudoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.namePlayerUserControl1);
            this.Name = "PseudoPlayer";
            this.Text = "PseudoPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private NamePlayerUserControl namePlayerUserControl1;
    }
}
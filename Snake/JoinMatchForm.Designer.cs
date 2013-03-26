namespace Snake
{
    partial class JoinMatchForm
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
            this.availableLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.availableLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(27, 23);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(94, 13);
            this.availableLabel.TabIndex = 0;
            this.availableLabel.Text = "Available Matchs :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // availableLabel2
            // 
            this.availableLabel2.AutoSize = true;
            this.availableLabel2.Location = new System.Drawing.Point(27, 65);
            this.availableLabel2.Name = "availableLabel2";
            this.availableLabel2.Size = new System.Drawing.Size(105, 13);
            this.availableLabel2.TabIndex = 1;
            this.availableLabel2.Text = "aucune partie trouvé";
            // 
            // JoinMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 115);
            this.Controls.Add(this.availableLabel2);
            this.Controls.Add(this.availableLabel);
            this.Name = "JoinMatchForm";
            this.Text = "JoinMatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label availableLabel2;
    }
}
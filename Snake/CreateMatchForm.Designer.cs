namespace Snake
{
    partial class CreateMatchForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createLabel1 = new System.Windows.Forms.Label();
            this.opponentLabel1 = new System.Windows.Forms.Label();
            this.createLabel2 = new System.Windows.Forms.Label();
            this.opponentLabel2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(99, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create a match ";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(41, 153);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(158, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createLabel1
            // 
            this.createLabel1.AutoSize = true;
            this.createLabel1.Location = new System.Drawing.Point(38, 66);
            this.createLabel1.Name = "createLabel1";
            this.createLabel1.Size = new System.Drawing.Size(69, 13);
            this.createLabel1.TabIndex = 3;
            this.createLabel1.Text = "Your Game : ";
            // 
            // opponentLabel1
            // 
            this.opponentLabel1.AutoSize = true;
            this.opponentLabel1.Location = new System.Drawing.Point(38, 100);
            this.opponentLabel1.Name = "opponentLabel1";
            this.opponentLabel1.Size = new System.Drawing.Size(63, 13);
            this.opponentLabel1.TabIndex = 4;
            this.opponentLabel1.Text = "Opponent : ";
            // 
            // createLabel2
            // 
            this.createLabel2.AutoSize = true;
            this.createLabel2.Location = new System.Drawing.Point(144, 66);
            this.createLabel2.Name = "createLabel2";
            this.createLabel2.Size = new System.Drawing.Size(89, 13);
            this.createLabel2.TabIndex = 5;
            this.createLabel2.Text = "No game created";
            // 
            // opponentLabel2
            // 
            this.opponentLabel2.AutoSize = true;
            this.opponentLabel2.Location = new System.Drawing.Point(144, 100);
            this.opponentLabel2.Name = "opponentLabel2";
            this.opponentLabel2.Size = new System.Drawing.Size(69, 13);
            this.opponentLabel2.TabIndex = 6;
            this.opponentLabel2.Text = "No opponent";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CreateMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 227);
            this.Controls.Add(this.opponentLabel2);
            this.Controls.Add(this.createLabel2);
            this.Controls.Add(this.opponentLabel1);
            this.Controls.Add(this.createLabel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "CreateMatchForm";
            this.Text = "CreateMatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label createLabel1;
        private System.Windows.Forms.Label opponentLabel1;
        private System.Windows.Forms.Label createLabel2;
        private System.Windows.Forms.Label opponentLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}
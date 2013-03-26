namespace Snake
{
    partial class Lobby
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
            this.lobbyLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.explainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lobbyLabel
            // 
            this.lobbyLabel.AutoSize = true;
            this.lobbyLabel.Location = new System.Drawing.Point(228, 9);
            this.lobbyLabel.Name = "lobbyLabel";
            this.lobbyLabel.Size = new System.Drawing.Size(36, 13);
            this.lobbyLabel.TabIndex = 1;
            this.lobbyLabel.Text = "Lobby";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(92, 141);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(99, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create Match";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(324, 141);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 4;
            this.joinButton.Text = "Join Match";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // explainLabel
            // 
            this.explainLabel.AutoSize = true;
            this.explainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel.Location = new System.Drawing.Point(12, 47);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(498, 54);
            this.explainLabel.TabIndex = 5;
            this.explainLabel.Text = "To play with another player you have two solutions. \r\nThe first one is to create " +
                "a match and wait until the opponent join the game.\r\nThe other one is to join a c" +
                "reated match.\r\n";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 206);
            this.Controls.Add(this.explainLabel);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.lobbyLabel);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lobbyLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Label explainLabel;
    }
}
using System.Windows.Forms;
namespace Snake
{
    partial class Form1
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
            this.mainIntroPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.sousMenu2Panel = new System.Windows.Forms.Panel();
            this.sousMenu3Panel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.optionButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.ruleLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.teamLabel2 = new System.Windows.Forms.Label();
            this.teamLabel1 = new System.Windows.Forms.Label();
            this.SnakeTitleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contentRulesLabel = new System.Windows.Forms.Label();
            this.mainIntroPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.sousMenu2Panel.SuspendLayout();
            this.sousMenu3Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainIntroPanel
            // 
            this.mainIntroPanel.BackColor = System.Drawing.Color.Black;
            this.mainIntroPanel.Controls.Add(this.menuPanel);
            this.mainIntroPanel.Controls.Add(this.panel1);
            this.mainIntroPanel.Controls.Add(this.teamLabel2);
            this.mainIntroPanel.Controls.Add(this.teamLabel1);
            this.mainIntroPanel.Controls.Add(this.SnakeTitleLabel);
            this.mainIntroPanel.Location = new System.Drawing.Point(-1, -1);
            this.mainIntroPanel.Name = "mainIntroPanel";
            this.mainIntroPanel.Size = new System.Drawing.Size(737, 504);
            this.mainIntroPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkGray;
            this.menuPanel.Controls.Add(this.sousMenu2Panel);
            this.menuPanel.Controls.Add(this.creditsLabel);
            this.menuPanel.Controls.Add(this.ruleLabel);
            this.menuPanel.Controls.Add(this.gameLabel);
            this.menuPanel.Location = new System.Drawing.Point(59, 155);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(605, 237);
            this.menuPanel.TabIndex = 8;
            // 
            // sousMenu2Panel
            // 
            this.sousMenu2Panel.BackColor = System.Drawing.Color.DimGray;
            this.sousMenu2Panel.Controls.Add(this.sousMenu3Panel);
            this.sousMenu2Panel.Location = new System.Drawing.Point(136, 21);
            this.sousMenu2Panel.Name = "sousMenu2Panel";
            this.sousMenu2Panel.Size = new System.Drawing.Size(442, 198);
            this.sousMenu2Panel.TabIndex = 4;
            // 
            // sousMenu3Panel
            // 
            this.sousMenu3Panel.BackColor = System.Drawing.Color.Transparent;
            this.sousMenu3Panel.Controls.Add(this.contentRulesLabel);
            this.sousMenu3Panel.Controls.Add(this.playButton);
            this.sousMenu3Panel.Controls.Add(this.optionButton);
            this.sousMenu3Panel.Location = new System.Drawing.Point(14, 13);
            this.sousMenu3Panel.Name = "sousMenu3Panel";
            this.sousMenu3Panel.Size = new System.Drawing.Size(414, 172);
            this.sousMenu3Panel.TabIndex = 7;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Green;
            this.playButton.Location = new System.Drawing.Point(5, 1);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(165, 40);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // optionButton
            // 
            this.optionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton.ForeColor = System.Drawing.Color.Green;
            this.optionButton.Location = new System.Drawing.Point(5, 66);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(165, 40);
            this.optionButton.TabIndex = 6;
            this.optionButton.Text = "Options";
            this.optionButton.UseVisualStyleBackColor = false;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.White;
            this.creditsLabel.Location = new System.Drawing.Point(22, 115);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(87, 25);
            this.creditsLabel.TabIndex = 3;
            this.creditsLabel.Text = "Credits";
            this.creditsLabel.Click += new System.EventHandler(this.creditsLabel_Click);
            // 
            // ruleLabel
            // 
            this.ruleLabel.AutoSize = true;
            this.ruleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ruleLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleLabel.ForeColor = System.Drawing.Color.White;
            this.ruleLabel.Location = new System.Drawing.Point(22, 67);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(70, 25);
            this.ruleLabel.TabIndex = 2;
            this.ruleLabel.Text = "Rules";
            this.ruleLabel.Click += new System.EventHandler(this.ruleLabel_Click);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.gameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.White;
            this.gameLabel.Location = new System.Drawing.Point(22, 21);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(74, 25);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Game";
            this.gameLabel.Click += new System.EventHandler(this.gameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Location = new System.Drawing.Point(59, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 44);
            this.panel1.TabIndex = 7;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(27, 10);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(69, 25);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Menu";
            // 
            // teamLabel2
            // 
            this.teamLabel2.AutoSize = true;
            this.teamLabel2.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel2.ForeColor = System.Drawing.Color.Silver;
            this.teamLabel2.Location = new System.Drawing.Point(96, 432);
            this.teamLabel2.Name = "teamLabel2";
            this.teamLabel2.Size = new System.Drawing.Size(191, 29);
            this.teamLabel2.TabIndex = 3;
            this.teamLabel2.Text = "Ganzin Florian";
            // 
            // teamLabel1
            // 
            this.teamLabel1.AutoSize = true;
            this.teamLabel1.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel1.ForeColor = System.Drawing.Color.Silver;
            this.teamLabel1.Location = new System.Drawing.Point(380, 432);
            this.teamLabel1.Name = "teamLabel1";
            this.teamLabel1.Size = new System.Drawing.Size(224, 29);
            this.teamLabel1.TabIndex = 2;
            this.teamLabel1.Text = "Collignon Gabriel";
            // 
            // SnakeTitleLabel
            // 
            this.SnakeTitleLabel.AutoSize = true;
            this.SnakeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SnakeTitleLabel.Font = new System.Drawing.Font("Plantagenet Cherokee", 48.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.SnakeTitleLabel.Location = new System.Drawing.Point(297, 20);
            this.SnakeTitleLabel.Name = "SnakeTitleLabel";
            this.SnakeTitleLabel.Size = new System.Drawing.Size(214, 87);
            this.SnakeTitleLabel.TabIndex = 0;
            this.SnakeTitleLabel.Text = "Snake";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contentRulesLabel
            // 
            this.contentRulesLabel.AutoSize = true;
            this.contentRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentRulesLabel.ForeColor = System.Drawing.Color.White;
            this.contentRulesLabel.Location = new System.Drawing.Point(3, 1);
            this.contentRulesLabel.Name = "contentRulesLabel";
            this.contentRulesLabel.Size = new System.Drawing.Size(365, 160);
            this.contentRulesLabel.TabIndex = 7;
            this.contentRulesLabel.Text = "Rules :\r\n\r\n- The goal of the game is to have the highest score\r\n\r\n- If you touch " +
                "the walls, this is the end of the game\r\n\r\nGood Luck !\r\n\r\n";
            this.contentRulesLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 495);
            this.Controls.Add(this.mainIntroPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.mainIntroPanel.ResumeLayout(false);
            this.mainIntroPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.sousMenu2Panel.ResumeLayout(false);
            this.sousMenu3Panel.ResumeLayout(false);
            this.sousMenu3Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainIntroPanel;
        private System.Windows.Forms.Label SnakeTitleLabel;
        private System.Windows.Forms.Label teamLabel2;
        private System.Windows.Forms.Label teamLabel1;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timer1;
        private Panel menuPanel;
        private Panel panel1;
        private Label menuLabel;
        private Label creditsLabel;
        private Label ruleLabel;
        private Label gameLabel;
        private Panel sousMenu2Panel;
        private Panel sousMenu3Panel;
        private Label contentRulesLabel;
      


        }
    
}


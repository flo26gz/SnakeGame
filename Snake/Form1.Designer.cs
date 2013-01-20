﻿using System.Windows.Forms;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainIntroPanel = new System.Windows.Forms.Panel();
            this.optionButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.teamLabel2 = new System.Windows.Forms.Label();
            this.teamLabel1 = new System.Windows.Forms.Label();
            this.SnakeTitleLabel = new System.Windows.Forms.Label();
            this.imgSnakePanel = new System.Windows.Forms.Panel();
            this.pBoxGame = new System.Windows.Forms.PictureBox();
            this.mainGamePanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainIntroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).BeginInit();
            this.mainGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainIntroPanel
            // 
            this.mainIntroPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainIntroPanel.Controls.Add(this.optionButton);
            this.mainIntroPanel.Controls.Add(this.playButton);
            this.mainIntroPanel.Controls.Add(this.rulesButton);
            this.mainIntroPanel.Controls.Add(this.teamLabel2);
            this.mainIntroPanel.Controls.Add(this.teamLabel1);
            this.mainIntroPanel.Controls.Add(this.SnakeTitleLabel);
            this.mainIntroPanel.Controls.Add(this.imgSnakePanel);
            this.mainIntroPanel.Location = new System.Drawing.Point(-1, -1);
            this.mainIntroPanel.Name = "mainIntroPanel";
            this.mainIntroPanel.Size = new System.Drawing.Size(626, 594);
            this.mainIntroPanel.TabIndex = 0;
            // 
            // optionButton
            // 
            this.optionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton.ForeColor = System.Drawing.Color.Green;
            this.optionButton.Location = new System.Drawing.Point(351, 218);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(165, 40);
            this.optionButton.TabIndex = 6;
            this.optionButton.Text = "Options";
            this.optionButton.UseVisualStyleBackColor = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Green;
            this.playButton.Location = new System.Drawing.Point(351, 136);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(165, 40);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // rulesButton
            // 
            this.rulesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesButton.ForeColor = System.Drawing.Color.Green;
            this.rulesButton.Location = new System.Drawing.Point(351, 302);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(165, 40);
            this.rulesButton.TabIndex = 5;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            // 
            // teamLabel2
            // 
            this.teamLabel2.AutoSize = true;
            this.teamLabel2.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel2.ForeColor = System.Drawing.Color.Silver;
            this.teamLabel2.Location = new System.Drawing.Point(40, 432);
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
            this.teamLabel1.Location = new System.Drawing.Point(40, 371);
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
            this.SnakeTitleLabel.Location = new System.Drawing.Point(197, 19);
            this.SnakeTitleLabel.Name = "SnakeTitleLabel";
            this.SnakeTitleLabel.Size = new System.Drawing.Size(214, 87);
            this.SnakeTitleLabel.TabIndex = 0;
            this.SnakeTitleLabel.Text = "Snake";
            // 
            // imgSnakePanel
            // 
            this.imgSnakePanel.BackColor = System.Drawing.Color.Transparent;
            this.imgSnakePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSnakePanel.BackgroundImage")));
            this.imgSnakePanel.Location = new System.Drawing.Point(88, 136);
            this.imgSnakePanel.Name = "imgSnakePanel";
            this.imgSnakePanel.Size = new System.Drawing.Size(134, 169);
            this.imgSnakePanel.TabIndex = 7;
            // 
            // pBoxGame
            // 
            this.pBoxGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pBoxGame.Location = new System.Drawing.Point(36, 28);
            this.pBoxGame.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxGame.Name = "pBoxGame";
            this.pBoxGame.Size = new System.Drawing.Size(560, 490);
            this.pBoxGame.TabIndex = 0;
            this.pBoxGame.TabStop = false;
            this.pBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxGame_Paint);
            // 
            // mainGamePanel
            // 
            this.mainGamePanel.BackColor = System.Drawing.Color.Azure;
            this.mainGamePanel.Controls.Add(this.pBoxGame);
            this.mainGamePanel.Location = new System.Drawing.Point(-1, 0);
            this.mainGamePanel.Name = "mainGamePanel";
            this.mainGamePanel.Size = new System.Drawing.Size(626, 594);
            this.mainGamePanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 587);
            this.Controls.Add(this.mainIntroPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.mainIntroPanel.ResumeLayout(false);
            this.mainIntroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).EndInit();
            this.mainGamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainIntroPanel;
        private System.Windows.Forms.Label SnakeTitleLabel;
        private System.Windows.Forms.Panel imgSnakePanel;
        private System.Windows.Forms.Panel mainGamePanel;
        private System.Windows.Forms.Label teamLabel2;
        private System.Windows.Forms.Label teamLabel1;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBoxGame;

        int x = 0, y = 0;
        private int SIZE_X = 500;
        private int SIZE_Y = 500;
        }
    
}

namespace CardGameApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnTopScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CardGameApp.Properties.Resources.gif_image;
            this.pictureBox1.Location = new System.Drawing.Point(320, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInstruction
            // 
            this.btnInstruction.Location = new System.Drawing.Point(220, 205);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(381, 55);
            this.btnInstruction.TabIndex = 1;
            this.btnInstruction.Text = "Instruction";
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.BtnInstruction_Click);
            // 
            // btnTopScore
            // 
            this.btnTopScore.Location = new System.Drawing.Point(220, 267);
            this.btnTopScore.Name = "btnTopScore";
            this.btnTopScore.Size = new System.Drawing.Size(381, 76);
            this.btnTopScore.TabIndex = 2;
            this.btnTopScore.Text = "Top Scores";
            this.btnTopScore.UseVisualStyleBackColor = true;
            this.btnTopScore.Click += new System.EventHandler(this.BtnTopScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(220, 350);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(381, 54);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(220, 411);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(381, 71);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CardGameApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnTopScore);
            this.Controls.Add(this.btnInstruction);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Awsome Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnTopScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
    }
}


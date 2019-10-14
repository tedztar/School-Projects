namespace DeckShuffleApp
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
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.shuffleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            this.SuspendLayout();
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(52, 90);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(90, 150);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Tag = "0";
            this.card1.Click += new System.EventHandler(this.card_Click);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(187, 90);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(90, 150);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Tag = "1";
            this.card2.Click += new System.EventHandler(this.card_Click);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(318, 90);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(90, 150);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Tag = "2";
            this.card3.Click += new System.EventHandler(this.card_Click);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(444, 90);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(90, 150);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Tag = "3";
            this.card4.Click += new System.EventHandler(this.card_Click);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(571, 90);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(90, 150);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Tag = "4";
            this.card5.Click += new System.EventHandler(this.card_Click);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(698, 90);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(90, 150);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Tag = "5";
            this.card6.Click += new System.EventHandler(this.card_Click);
            // 
            // card7
            // 
            this.card7.Location = new System.Drawing.Point(829, 90);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(90, 150);
            this.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            this.card7.Tag = "6";
            this.card7.Click += new System.EventHandler(this.card_Click);
            // 
            // card8
            // 
            this.card8.Location = new System.Drawing.Point(961, 90);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(90, 150);
            this.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card8.TabIndex = 7;
            this.card8.TabStop = false;
            this.card8.Tag = "7";
            this.card8.Click += new System.EventHandler(this.card_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleBtn.Location = new System.Drawing.Point(483, 353);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(213, 88);
            this.shuffleBtn.TabIndex = 8;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 518);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.Button shuffleBtn;
    }
}


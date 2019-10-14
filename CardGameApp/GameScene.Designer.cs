namespace CardGameApp
{
    partial class GameScene
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.btnAppear = new System.Windows.Forms.Button();
            this.btnDisapear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME# SCENE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SCORE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // card1
            // 
            this.card1.Image = global::CardGameApp.Properties.Resources.card_back;
            this.card1.Location = new System.Drawing.Point(56, 143);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(134, 223);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 5;
            this.card1.TabStop = false;
            this.card1.Tag = "0";
            this.card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // card2
            // 
            this.card2.Image = global::CardGameApp.Properties.Resources.card_back;
            this.card2.Location = new System.Drawing.Point(219, 143);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(134, 223);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 6;
            this.card2.TabStop = false;
            this.card2.Tag = "1";
            this.card2.Click += new System.EventHandler(this.Card1_Click);
            // 
            // card3
            // 
            this.card3.Image = global::CardGameApp.Properties.Resources.card_back;
            this.card3.Location = new System.Drawing.Point(389, 143);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(134, 223);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 7;
            this.card3.TabStop = false;
            this.card3.Tag = "2";
            this.card3.Click += new System.EventHandler(this.Card1_Click);
            // 
            // card4
            // 
            this.card4.Image = global::CardGameApp.Properties.Resources.card_back;
            this.card4.Location = new System.Drawing.Point(570, 143);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(134, 223);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 8;
            this.card4.TabStop = false;
            this.card4.Tag = "3";
            this.card4.Click += new System.EventHandler(this.Card1_Click);
            // 
            // btnAppear
            // 
            this.btnAppear.Location = new System.Drawing.Point(48, 382);
            this.btnAppear.Name = "btnAppear";
            this.btnAppear.Size = new System.Drawing.Size(124, 26);
            this.btnAppear.TabIndex = 9;
            this.btnAppear.Text = "Appear";
            this.btnAppear.UseVisualStyleBackColor = true;
            this.btnAppear.Click += new System.EventHandler(this.BtnAppear_Click);
            // 
            // btnDisapear
            // 
            this.btnDisapear.Location = new System.Drawing.Point(45, 414);
            this.btnDisapear.Name = "btnDisapear";
            this.btnDisapear.Size = new System.Drawing.Size(126, 26);
            this.btnDisapear.TabIndex = 10;
            this.btnDisapear.Text = "Disapear";
            this.btnDisapear.UseVisualStyleBackColor = true;
            this.btnDisapear.Click += new System.EventHandler(this.BtnDisapear_Click);
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisapear);
            this.Controls.Add(this.btnAppear);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameScene";
            this.Text = "GameScene";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.Button btnAppear;
        private System.Windows.Forms.Button btnDisapear;
    }
}
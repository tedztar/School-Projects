namespace PraticalTestSolution_2016
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
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lv_test = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(449, 128);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(301, 83);
            this.tb_description.TabIndex = 0;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(449, 61);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 26);
            this.tb_id.TabIndex = 1;
            // 
            // lv_test
            // 
            this.lv_test.Location = new System.Drawing.Point(55, 75);
            this.lv_test.Name = "lv_test";
            this.lv_test.Size = new System.Drawing.Size(342, 316);
            this.lv_test.TabIndex = 2;
            this.lv_test.UseCompatibleStateImageBehavior = false;
            this.lv_test.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_test);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ListView lv_test;
    }
}


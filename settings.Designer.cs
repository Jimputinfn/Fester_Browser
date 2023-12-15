namespace SharpBrowser
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 62);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(250, 44);
            button1.TabIndex = 0;
            button1.Text = "Clear Browsing Data (keeps you logged in)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(12, 112);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(250, 44);
            button2.TabIndex = 1;
            button2.Text = "Open Our Website";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(12, 430);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Made By Jimputin:)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(12, 454);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(172, 15);
            label2.TabIndex = 3;
            label2.Text = "Project Based On SharpBrowser";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(250, 44);
            button3.TabIndex = 4;
            button3.Text = "About FesterBrowser";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(281, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(567, 496);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Blue;
            pictureBox2.Location = new System.Drawing.Point(-3, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(265, 24);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Blue;
            pictureBox3.Location = new System.Drawing.Point(239, 419);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(23, 63);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(774, 478);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Opacity = 0.8D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Settings";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
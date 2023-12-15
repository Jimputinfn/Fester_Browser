namespace SharpBrowser
{
    partial class AutokillWizard
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(404, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Auto Kill Browser! You can select time when browser kills it self";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(19, 34);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(244, 25);
            button1.TabIndex = 1;
            button1.Text = "10 Min";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(19, 65);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(244, 25);
            button2.TabIndex = 2;
            button2.Text = "30 Min";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(19, 96);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(244, 25);
            button3.TabIndex = 3;
            button3.Text = "60 Min";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AutokillWizard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(561, 139);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "AutokillWizard";
            Text = "Auto Kill Browser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
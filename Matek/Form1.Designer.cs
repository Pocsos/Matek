namespace Matek
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
            this.szam1 = new System.Windows.Forms.TextBox();
            this.szam2 = new System.Windows.Forms.TextBox();
            this.ered = new System.Windows.Forms.TextBox();
            this.ossz = new System.Windows.Forms.Button();
            this.kiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szam1
            // 
            this.szam1.Location = new System.Drawing.Point(59, 165);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(100, 20);
            this.szam1.TabIndex = 0;
            this.szam1.TextChanged += new System.EventHandler(this.szam1_TextChanged);
            // 
            // szam2
            // 
            this.szam2.Location = new System.Drawing.Point(213, 165);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(100, 20);
            this.szam2.TabIndex = 1;
            // 
            // ered
            // 
            this.ered.Location = new System.Drawing.Point(396, 165);
            this.ered.Name = "ered";
            this.ered.Size = new System.Drawing.Size(100, 20);
            this.ered.TabIndex = 2;
            // 
            // ossz
            // 
            this.ossz.Location = new System.Drawing.Point(55, 207);
            this.ossz.Name = "ossz";
            this.ossz.Size = new System.Drawing.Size(104, 56);
            this.ossz.TabIndex = 3;
            this.ossz.Text = "Összeadás";
            this.ossz.UseVisualStyleBackColor = true;
            this.ossz.Click += new System.EventHandler(this.button1_Click);
            // 
            // kiv
            // 
            this.kiv.Location = new System.Drawing.Point(213, 207);
            this.kiv.Name = "kiv";
            this.kiv.Size = new System.Drawing.Size(104, 56);
            this.kiv.TabIndex = 4;
            this.kiv.Text = "Kivonás";
            this.kiv.UseVisualStyleBackColor = true;
            this.kiv.Click += new System.EventHandler(this.kiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kiv);
            this.Controls.Add(this.ossz);
            this.Controls.Add(this.ered);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox szam1;
        private System.Windows.Forms.TextBox szam2;
        private System.Windows.Forms.TextBox ered;
        private System.Windows.Forms.Button ossz;
        private System.Windows.Forms.Button kiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


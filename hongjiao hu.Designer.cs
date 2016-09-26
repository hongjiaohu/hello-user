namespace hongjiao_hu
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
            this.Hellouserprogram = new System.Windows.Forms.Label();
            this.bigbox = new System.Windows.Forms.GroupBox();
            this.b1 = new System.Windows.Forms.Button();
            this.asd = new System.Windows.Forms.Label();
            this.bigbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hellouserprogram
            // 
            this.Hellouserprogram.AutoSize = true;
            this.Hellouserprogram.Location = new System.Drawing.Point(311, 9);
            this.Hellouserprogram.Name = "Hellouserprogram";
            this.Hellouserprogram.Size = new System.Drawing.Size(103, 13);
            this.Hellouserprogram.TabIndex = 0;
            this.Hellouserprogram.Text = "what are you doing?";
            // 
            // bigbox
            // 
            this.bigbox.Controls.Add(this.b1);
            this.bigbox.Location = new System.Drawing.Point(101, 77);
            this.bigbox.Name = "bigbox";
            this.bigbox.Size = new System.Drawing.Size(507, 372);
            this.bigbox.TabIndex = 1;
            this.bigbox.TabStop = false;
            this.bigbox.Enter += new System.EventHandler(this.bigbox_Enter);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(238, 158);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "b1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(356, 61);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(0, 13);
            this.asd.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 461);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.bigbox);
            this.Controls.Add(this.Hellouserprogram);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bigbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hellouserprogram;
        private System.Windows.Forms.GroupBox bigbox;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Button b1;
    }
}


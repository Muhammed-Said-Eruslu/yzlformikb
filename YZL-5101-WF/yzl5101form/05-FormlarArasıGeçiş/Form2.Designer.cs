namespace _05_FormlarArasıGeçiş
{
    partial class Form2
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
            label1 = new Label();
            lblAdSoyad = new Label();
            lblortlama = new Label();
            label3 = new Label();
            lblGeçmeDurumu = new Label();
            label5 = new Label();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 92);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad ve Soyad";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(163, 92);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(22, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = ".....";
            // 
            // lblortlama
            // 
            lblortlama.AutoSize = true;
            lblortlama.Location = new Point(163, 147);
            lblortlama.Name = "lblortlama";
            lblortlama.Size = new Size(22, 15);
            lblortlama.TabIndex = 3;
            lblortlama.Text = ".....";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 147);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Sınav Ortlaması";
            // 
            // lblGeçmeDurumu
            // 
            lblGeçmeDurumu.AutoSize = true;
            lblGeçmeDurumu.Location = new Point(163, 198);
            lblGeçmeDurumu.Name = "lblGeçmeDurumu";
            lblGeçmeDurumu.Size = new Size(22, 15);
            lblGeçmeDurumu.TabIndex = 5;
            lblGeçmeDurumu.Text = ".....";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 198);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Geçme Durumu";
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(82, 254);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 23);
            btnKapat.TabIndex = 6;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 394);
            Controls.Add(btnKapat);
            Controls.Add(lblGeçmeDurumu);
            Controls.Add(label5);
            Controls.Add(lblortlama);
            Controls.Add(label3);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Button btnKapat;
        public Label lblAdSoyad;
        public Label lblortlama;
        public Label lblGeçmeDurumu;
    }
}
namespace _05_FormlarArasıGeçiş
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtSınav1 = new TextBox();
            txtSınav2 = new TextBox();
            txtSınav3 = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı Ve Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 97);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Sınav Notu 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 144);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Sınav Notu 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 184);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Sınav Notu 3";
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtSınav1
            // 
            txtSınav1.Location = new Point(146, 97);
            txtSınav1.Name = "txtSınav1";
            txtSınav1.Size = new Size(100, 23);
            txtSınav1.TabIndex = 5;
            // 
            // txtSınav2
            // 
            txtSınav2.Location = new Point(146, 144);
            txtSınav2.Name = "txtSınav2";
            txtSınav2.Size = new Size(100, 23);
            txtSınav2.TabIndex = 6;
            // 
            // txtSınav3
            // 
            txtSınav3.Location = new Point(146, 184);
            txtSınav3.Name = "txtSınav3";
            txtSınav3.Size = new Size(100, 23);
            txtSınav3.TabIndex = 7;
            txtSınav3.TextChanged += textBox4_TextChanged;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(146, 224);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(100, 23);
            btnHesapla.TabIndex = 8;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 273);
            Controls.Add(btnHesapla);
            Controls.Add(txtSınav3);
            Controls.Add(txtSınav2);
            Controls.Add(txtSınav1);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnHesapla;
        public TextBox txtName;
        public TextBox txtSınav1;
        public TextBox txtSınav2;
        public TextBox txtSınav3;
    }
}

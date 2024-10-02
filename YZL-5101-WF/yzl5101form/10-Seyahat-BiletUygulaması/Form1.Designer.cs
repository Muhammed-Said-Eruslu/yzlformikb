namespace _10_Seyahat_BiletUygulaması
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
            grpKisiselBilgiler = new GroupBox();
            btnKaydet = new Button();
            txtKoltukNo = new TextBox();
            rdbKadın = new RadioButton();
            rdbErkek = new RadioButton();
            txtTelefon = new TextBox();
            TXTsOYAD = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flwPanel = new FlowLayoutPanel();
            lstSatılanKoltuklar = new ListBox();
            grpKisiselBilgiler.SuspendLayout();
            SuspendLayout();
            // 
            // grpKisiselBilgiler
            // 
            grpKisiselBilgiler.Controls.Add(btnKaydet);
            grpKisiselBilgiler.Controls.Add(txtKoltukNo);
            grpKisiselBilgiler.Controls.Add(rdbKadın);
            grpKisiselBilgiler.Controls.Add(rdbErkek);
            grpKisiselBilgiler.Controls.Add(txtTelefon);
            grpKisiselBilgiler.Controls.Add(TXTsOYAD);
            grpKisiselBilgiler.Controls.Add(txtAd);
            grpKisiselBilgiler.Controls.Add(label5);
            grpKisiselBilgiler.Controls.Add(label4);
            grpKisiselBilgiler.Controls.Add(label3);
            grpKisiselBilgiler.Controls.Add(label2);
            grpKisiselBilgiler.Controls.Add(label1);
            grpKisiselBilgiler.Location = new Point(268, 38);
            grpKisiselBilgiler.Name = "grpKisiselBilgiler";
            grpKisiselBilgiler.Size = new Size(200, 246);
            grpKisiselBilgiler.TabIndex = 0;
            grpKisiselBilgiler.TabStop = false;
            grpKisiselBilgiler.Text = "Kişisel Bilgiler";
            grpKisiselBilgiler.Enter += grpKisiselBilgiler_Enter;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(110, 171);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtKoltukNo
            // 
            txtKoltukNo.Enabled = false;
            txtKoltukNo.Location = new Point(75, 171);
            txtKoltukNo.Name = "txtKoltukNo";
            txtKoltukNo.Size = new Size(24, 23);
            txtKoltukNo.TabIndex = 10;
            // 
            // rdbKadın
            // 
            rdbKadın.AutoSize = true;
            rdbKadın.Location = new Point(130, 140);
            rdbKadın.Name = "rdbKadın";
            rdbKadın.Size = new Size(55, 19);
            rdbKadın.TabIndex = 9;
            rdbKadın.TabStop = true;
            rdbKadın.Text = "Kadın";
            rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(71, 140);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 8;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(65, 103);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 7;
            txtTelefon.Tag = "Telefon";
            // 
            // TXTsOYAD
            // 
            TXTsOYAD.Location = new Point(65, 70);
            TXTsOYAD.Name = "TXTsOYAD";
            TXTsOYAD.Size = new Size(100, 23);
            TXTsOYAD.TabIndex = 6;
            TXTsOYAD.Tag = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(65, 35);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 5;
            txtAd.Tag = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Koltuk No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 142);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 73);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // flwPanel
            // 
            flwPanel.Location = new Point(12, 38);
            flwPanel.Name = "flwPanel";
            flwPanel.Size = new Size(230, 650);
            flwPanel.TabIndex = 1;
            // 
            // lstSatılanKoltuklar
            // 
            lstSatılanKoltuklar.FormattingEnabled = true;
            lstSatılanKoltuklar.ItemHeight = 15;
            lstSatılanKoltuklar.Location = new Point(268, 320);
            lstSatılanKoltuklar.Name = "lstSatılanKoltuklar";
            lstSatılanKoltuklar.Size = new Size(200, 169);
            lstSatılanKoltuklar.TabIndex = 2;
            lstSatılanKoltuklar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 711);
            Controls.Add(lstSatılanKoltuklar);
            Controls.Add(flwPanel);
            Controls.Add(grpKisiselBilgiler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpKisiselBilgiler.ResumeLayout(false);
            grpKisiselBilgiler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKisiselBilgiler;
        private FlowLayoutPanel flwPanel;
        private ListBox lstSatılanKoltuklar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKaydet;
        private TextBox txtKoltukNo;
        private RadioButton rdbKadın;
        private RadioButton rdbErkek;
        private TextBox txtTelefon;
        private TextBox TXTsOYAD;
        private TextBox txtAd;
    }
}

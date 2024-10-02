namespace _02_KisiBilgileriMaas_Hesabı
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
            groupBox1 = new GroupBox();
            rbSingle = new RadioButton();
            rbMarried = new RadioButton();
            grpChildren = new GroupBox();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            rb0 = new RadioButton();
            grpLanguages = new GroupBox();
            chrTR = new CheckBox();
            chkİta = new CheckBox();
            chkFR = new CheckBox();
            chkDE = new CheckBox();
            chkENG = new CheckBox();
            txtSalary = new TextBox();
            btnCalculate = new Button();
            lblNewSalary = new Label();
            groupBox1.SuspendLayout();
            grpChildren.SuspendLayout();
            grpLanguages.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSingle);
            groupBox1.Controls.Add(rbMarried);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medeni Hal";
            // 
            // rbSingle
            // 
            rbSingle.AutoSize = true;
            rbSingle.ForeColor = Color.Red;
            rbSingle.Location = new Point(18, 98);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new Size(54, 19);
            rbSingle.TabIndex = 1;
            rbSingle.TabStop = true;
            rbSingle.Text = "Bekar";
            rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            rbMarried.AutoSize = true;
            rbMarried.ForeColor = Color.SteelBlue;
            rbMarried.Location = new Point(18, 59);
            rbMarried.Name = "rbMarried";
            rbMarried.Size = new Size(43, 19);
            rbMarried.TabIndex = 0;
            rbMarried.TabStop = true;
            rbMarried.Text = "Evli";
            rbMarried.UseVisualStyleBackColor = true;
            // 
            // grpChildren
            // 
            grpChildren.Controls.Add(rb3);
            grpChildren.Controls.Add(rb2);
            grpChildren.Controls.Add(rb1);
            grpChildren.Controls.Add(rb0);
            grpChildren.Enabled = false;
            grpChildren.Location = new Point(21, 252);
            grpChildren.Name = "grpChildren";
            grpChildren.Size = new Size(200, 150);
            grpChildren.TabIndex = 1;
            grpChildren.TabStop = false;
            grpChildren.Text = "Çocuk Sayısı";
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(28, 97);
            rb3.Name = "rb3";
            rb3.Size = new Size(31, 19);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(28, 72);
            rb2.Name = "rb2";
            rb2.Size = new Size(31, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(28, 47);
            rb1.Name = "rb1";
            rb1.Size = new Size(31, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            rb0.AutoSize = true;
            rb0.Location = new Point(28, 22);
            rb0.Name = "rb0";
            rb0.Size = new Size(31, 19);
            rb0.TabIndex = 0;
            rb0.TabStop = true;
            rb0.Text = "0";
            rb0.UseVisualStyleBackColor = true;
            // 
            // grpLanguages
            // 
            grpLanguages.Controls.Add(chrTR);
            grpLanguages.Controls.Add(chkİta);
            grpLanguages.Controls.Add(chkFR);
            grpLanguages.Controls.Add(chkDE);
            grpLanguages.Controls.Add(chkENG);
            grpLanguages.Location = new Point(240, 21);
            grpLanguages.Name = "grpLanguages";
            grpLanguages.Size = new Size(200, 272);
            grpLanguages.TabIndex = 2;
            grpLanguages.TabStop = false;
            grpLanguages.Text = "Bildiği Diler";
            // 
            // chrTR
            // 
            chrTR.AutoSize = true;
            chrTR.ForeColor = Color.Turquoise;
            chrTR.Location = new Point(12, 126);
            chrTR.Name = "chrTR";
            chrTR.Size = new Size(61, 19);
            chrTR.TabIndex = 4;
            chrTR.Text = "Türkçe";
            chrTR.UseVisualStyleBackColor = true;
            // 
            // chkİta
            // 
            chkİta.AutoSize = true;
            chkİta.Location = new Point(12, 101);
            chkİta.Name = "chkİta";
            chkİta.Size = new Size(73, 19);
            chkİta.TabIndex = 3;
            chkİta.Text = "İtalyanca";
            chkİta.UseVisualStyleBackColor = true;
            // 
            // chkFR
            // 
            chkFR.AutoSize = true;
            chkFR.Location = new Point(12, 76);
            chkFR.Name = "chkFR";
            chkFR.Size = new Size(74, 19);
            chkFR.TabIndex = 2;
            chkFR.Text = "Fransızca";
            chkFR.UseVisualStyleBackColor = true;
            // 
            // chkDE
            // 
            chkDE.AutoSize = true;
            chkDE.Location = new Point(12, 51);
            chkDE.Name = "chkDE";
            chkDE.Size = new Size(73, 19);
            chkDE.TabIndex = 1;
            chkDE.Text = "Almanca";
            chkDE.UseVisualStyleBackColor = true;
            // 
            // chkENG
            // 
            chkENG.AutoSize = true;
            chkENG.Location = new Point(12, 22);
            chkENG.Name = "chkENG";
            chkENG.Size = new Size(69, 19);
            chkENG.TabIndex = 0;
            chkENG.Text = "İngilizce";
            chkENG.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(227, 299);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Maaşınızı Giriniz";
            txtSalary.Size = new Size(147, 23);
            txtSalary.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(227, 390);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblNewSalary
            // 
            lblNewSalary.AutoSize = true;
            lblNewSalary.Location = new Point(240, 349);
            lblNewSalary.Name = "lblNewSalary";
            lblNewSalary.Size = new Size(60, 15);
            lblNewSalary.TabIndex = 5;
            lblNewSalary.Text = "Yeni Maaş";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNewSalary);
            Controls.Add(btnCalculate);
            Controls.Add(txtSalary);
            Controls.Add(grpLanguages);
            Controls.Add(grpChildren);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpChildren.ResumeLayout(false);
            grpChildren.PerformLayout();
            grpLanguages.ResumeLayout(false);
            grpLanguages.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbSingle;
        private RadioButton rbMarried;
        private GroupBox grpChildren;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private RadioButton rb0;
        private GroupBox grpLanguages;
        private CheckBox chrTR;
        private CheckBox chkİta;
        private CheckBox chkFR;
        private CheckBox chkDE;
        private CheckBox chkENG;
        private TextBox txtSalary;
        private Button btnCalculate;
        private Label lblNewSalary;
    }
}

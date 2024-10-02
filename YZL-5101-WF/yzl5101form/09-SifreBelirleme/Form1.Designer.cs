namespace _09_SifreBelirleme
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
            tztPassword = new TextBox();
            label1 = new Label();
            lblZorluk = new Label();
            SuspendLayout();
            // 
            // tztPassword
            // 
            tztPassword.Location = new Point(136, 82);
            tztPassword.Name = "tztPassword";
            tztPassword.Size = new Size(100, 23);
            tztPassword.TabIndex = 0;
            tztPassword.TextChanged += tztPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 139);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Şifre Zorluk Derecesi";
            // 
            // lblZorluk
            // 
            lblZorluk.AutoSize = true;
            lblZorluk.Location = new Point(226, 139);
            lblZorluk.Name = "lblZorluk";
            lblZorluk.Size = new Size(34, 15);
            lblZorluk.TabIndex = 2;
            lblZorluk.Text = ".........";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblZorluk);
            Controls.Add(label1);
            Controls.Add(tztPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tztPassword;
        private Label label1;
        private Label lblZorluk;
    }
}

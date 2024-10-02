namespace _06_RenkVer
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
            cmbColors = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbColors
            // 
            cmbColors.FormattingEnabled = true;
            cmbColors.Location = new Point(75, 77);
            cmbColors.Name = "cmbColors";
            cmbColors.Size = new Size(121, 23);
            cmbColors.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(21, 133);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Tag = "1";
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(168, 133);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Tag = "2";
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 217);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbColors);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbColors;
        private Button btnOK;
        private Button btnCancel;
    }
}
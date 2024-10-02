namespace _01_TutarHesaplama
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
            grpDiscount = new GroupBox();
            chkSpecialDiscount = new CheckBox();
            chkCampainDiscount = new CheckBox();
            chkCashDiscount = new CheckBox();
            groupBox1 = new GroupBox();
            btnCalculate = new Button();
            txtPrice = new TextBox();
            label1 = new Label();
            grpDiscount.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDiscount
            // 
            grpDiscount.Controls.Add(chkSpecialDiscount);
            grpDiscount.Controls.Add(chkCampainDiscount);
            grpDiscount.Controls.Add(chkCashDiscount);
            grpDiscount.Location = new Point(24, 45);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(200, 236);
            grpDiscount.TabIndex = 0;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "İndirimler";
            // 
            // chkSpecialDiscount
            // 
            chkSpecialDiscount.AutoSize = true;
            chkSpecialDiscount.Location = new Point(22, 127);
            chkSpecialDiscount.Name = "chkSpecialDiscount";
            chkSpecialDiscount.Size = new Size(116, 19);
            chkSpecialDiscount.TabIndex = 2;
            chkSpecialDiscount.Text = "% 10 özel indirim";
            chkSpecialDiscount.UseVisualStyleBackColor = true;
            // 
            // chkCampainDiscount
            // 
            chkCampainDiscount.AutoSize = true;
            chkCampainDiscount.Location = new Point(23, 83);
            chkCampainDiscount.Name = "chkCampainDiscount";
            chkCampainDiscount.Size = new Size(150, 19);
            chkCampainDiscount.TabIndex = 1;
            chkCampainDiscount.Text = "%10 kampanya indirimi";
            chkCampainDiscount.UseVisualStyleBackColor = true;
            // 
            // chkCashDiscount
            // 
            chkCashDiscount.AutoSize = true;
            chkCashDiscount.Location = new Point(25, 43);
            chkCashDiscount.Name = "chkCashDiscount";
            chkCashDiscount.Size = new Size(115, 19);
            chkCashDiscount.TabIndex = 0;
            chkCashDiscount.Text = "%5 nakit indirimi";
            chkCashDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(259, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 236);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesaplama";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(75, 151);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(75, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 105);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Tutar :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(grpDiscount);
            Name = "Form1";
            Text = "Form1";
            grpDiscount.ResumeLayout(false);
            grpDiscount.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDiscount;
        private CheckBox chkSpecialDiscount;
        private CheckBox chkCampainDiscount;
        private CheckBox chkCashDiscount;
        private GroupBox groupBox1;
        private Button btnCalculate;
        private TextBox txtPrice;
        private Label label1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_RenkVer
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            cmbColors.Items.AddRange(new object[]
            {
                    Color.AliceBlue,
                    Color.Turquoise,
                    Color.DarkKhaki,
                    Color.Black,
                    Color.White,
                    Color.DarkTurquoise,
                    Color.Green,
                    Color.Red,
                    Color.Magenta,
                    Color.Blue,
            });
            btnOK.Click += MyClick;
            btnCancel.Click += MyClick;

        }
        public Color renkSeçimi { get; set; }

        private void MyClick(object sender, EventArgs e) // MyClick hem tamama hemde ıptala atayacağım metot
        {
            // hem tamam butonuna hemde ıptal butonuna atıcam
            Button button = sender as Button;

            object tag = button.Tag; // butonun üzerinde ki tagi soyle
            
            switch (tag)
            {

                case "1":
                    if (cmbColors.SelectedIndex != -1) // default halı seçilmemis halı cmbden bir şey sectimi
                    {
                        btnOK.Enabled = true;
                        renkSeçimi = (Color)cmbColors.SelectedItem; // item seçildi mi
                    }
                    else if(cmbColors.SelectedIndex == -1)
                    {
                        btnOK.Enabled = false;
                    }
                    DialogResult = DialogResult.OK; // rengi alabildiysem ok don
                    break;

                case "2":
                    DialogResult = DialogResult.Cancel;
                    break;


            }
        }




        private void btnOK_Click(object sender, EventArgs e)
        {

           
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
/*if (cmbColors.Text == "Kırmızı")
{
    Form1 form1 = new Form1();
    form1.BackColor = Color.Red;
    form1.Show();
}
else if (cmbColors.Text == "Siyah")
{
    Form1 form1 = new Form1();
    form1.BackColor = Color.Black;
    form1.Show();
}
else if (cmbColors.Text == "Yeşil")
{
    Form1 form1 = new Form1();
    form1.BackColor = Color.Black;
    form1.Show();
}*/
/*
  Form1 form1 = new Form1();
            switch (cmbColors.Text)
            {
                case "Kırmızı":
                    form1.BackColor = Color.Red;
                    form1.Show();
                    break;

                case "Siyah":
                    form1.BackColor = Color.Black;
                    form1.Show();
                    break;
                case "Mavi":
                    form1.BackColor = Color.Blue;
                    form1.Show();
                    break;
                case "Yeşil":
                    form1.BackColor = Color.Green;
                    form1.Show();
                    break;
                case "Turuncu":
                    form1.BackColor = Color.Red;
                    form1.Show();
                    break;
                case "Turquaz":
                    form1.BackColor = Color.Turquoise;
                    form1.Show();
                    break;
                case "Sarı":
                    form1.BackColor = Color.Yellow;
                    form1.Show();
                    break;
                case "Okyanus":
                    form1.BackColor = Color.AliceBlue;
                    form1.Show();
                    break;
                case "Pembe":
                    form1.BackColor = Color.Pink;
                    form1.Show();
                    break;

                default
                    :
                    form1.BackColor = Color.White;
                    break;

            }*/
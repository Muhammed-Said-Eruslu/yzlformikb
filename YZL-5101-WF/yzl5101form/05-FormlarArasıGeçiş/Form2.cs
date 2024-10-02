using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _05_FormlarArasıGeçiş
{
    public partial class Form2 : Form
    {
        public Form2(string isim,double ortlama,string mesaj)
        {
            InitializeComponent();
            lblAdSoyad.Text = isim;
            lblGeçmeDurumu.Text = mesaj;
            lblortlama.Text = ortlama.ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}

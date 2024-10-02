using System.Windows.Forms;

namespace _02_KisiBilgileriMaas_Hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double maas;
        private void Form1_Load(object sender, EventArgs e)
        {
            // form açıldığında bekar seçili gelsin ve haliyle çocuk sayısı grup boxe kullanılamaz gelsin 
            // evli seçilidiğinde çocuk sayısı grup boxı kullanıla bılır olsun fakat tekrar bekar seçilirse kapansın
            // evli seciliyse %3 bekar seçilirse %2 maaş artışı
            // her cocuk %2 maaş artışı
            // ve dil biligisi için %2 maas artısı hesaplansın 
            // textboxe yazılan değer ondalıklı sayıya cevriliyorsa (try-catch  olmadan metotkontrol) güncel zamlı maaş hesaplanarak labele basılsın
            // texbox boş olduğunda yada çevrilen değer yazılamadığında hata mesajı versin
            // Form yüklendiğinde bekar seçili gelsin ve çocuk sayısı grup kutusu kapalı olsun
            rbSingle.Checked = true;
            grpChildren.Enabled = false;

            
            rbSingle.CheckedChanged += (s, ev) =>
            {
                grpChildren.Enabled = false;
            };

            rbMarried.CheckedChanged += (s, ev) =>
            {
                grpChildren.Enabled = true;
            };

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Maaş Bilgisi Boş Geçilemez");
                return;
            }
            if (!double.TryParse(txtSalary.Text, out maas))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
               
            }

            if(rbMarried.Checked)
            {
                maas *= 1.03;
            }
            if(rbSingle.Checked)
            {
                maas *= 1.02;
            }
            if(rbMarried.Checked)
            {
                if(rb0.Checked)
                {
                    maas *= 1.03;
                }
                else if(rb1.Checked)
                {
                    maas *= 1.05;
                }
                else if(rb2.Checked)
                {
                    maas *= 1.07;
                }
                else if(rb3.Checked)
                {
                    maas *= 1.09;
                }
              if(chkDE.Checked)
                {
                    maas *= 1.02;
                }
              if(chkENG.Checked)
                {
                    maas *= 1.02;
                }
              if(chkFR.Checked)
                {
                    maas *= 1.02;
                }
              if(chkİta.Checked)
                {
                    maas *= 1.02;
                }
              if(chrTR.Checked)
                {
                    maas *= 1.02;
                }

            }
            lblNewSalary.Text = $"Güncel Maaş: {maas}";
            Temizle(this.Controls);
            
        }

        private void Temizle(Control.ControlCollection collection)
        {
           

            foreach (Control control in grpChildren.Controls)
            {
                if (control is RadioButton radiobox)
                {
                    radiobox.Checked = false;
                }
            }
            foreach (Control control in grpLanguages.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false; 
                }
            }
            // txtSalary.Text = null;

            foreach (Control item in collection)
            {
                if (item is TextBox text)
                {
                    text.Text = ""; 
                }
            }
            rbSingle.Checked = true;
        }
    }
}

/*  rbSingle.Checked = true;

            if (rbSingle.Checked)
            {
                grpChildren.Enabled = false;
            }
            else if (rbMarried.Checked)
            {
                grpChildren.Enabled = true;
            }

            if (rbMarried.Checked == true)
            {
                if (rb0.Checked)
                {
                    maas = 0.03;
                }
                else if (rb1.Checked)
                {
                    maas = 0.05;
                }
                else if (rb2.Checked)
                {
                    maas = 0.07;
                }
                else if (rb3.Checked)
                {
                    maas = 0.09;
                }
            }
            else if (rbSingle.Checked == true)
            {
                maas = 0.02;
            }
            if (chkDE.Checked == true && chkENG.Checked == true && chkFR.Checked == true && chkİta.Checked == true && chrTR.Checked == true)
            {
                double artis = maas * 0.02;
                maas += artis;
            }
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Maaş Bilgisi Boş Geçilemez");
            }

            if (!double.TryParse(txtSalary.Text, out maas))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            MessageBox.Show($"Yeni Maaşsın {lblNewSalary} {maas}");*/
/*    foreach(Control item in grpLanguages.Controls)
            {
               if (((CheckBox)item).Checked)
                { 
                }
            }*/
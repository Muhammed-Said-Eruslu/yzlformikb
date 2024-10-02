namespace _10_Seyahat_BiletUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpKisiselBilgiler.Enabled = false;
            rdbKadın.Checked = true;
            int araKoltuk = 3;
            int bosHazırlanacaklarIcınEklenekicekler = 0;
            int koridorKoltukNO = 0;


            for (int i = 1; i <= 54 + bosHazırlanacaklarIcınEklenekicekler; i++)
            {
                Button button = new Button();
                button.Width = 35;

                if (i == araKoltuk)
                {
                    button.Height = 0;
                    araKoltuk += 5;
                    bosHazırlanacaklarIcınEklenekicekler++;
                }
                else
                {
                    button.Height = 35;
                    koridorKoltukNO++;
                    button.Text = koridorKoltukNO.ToString();
                    button.Click += MyClick;
                    secilenButon = button;
                    button.BackgroundImageLayout = ImageLayout.Stretch;



                }


                flwPanel.Controls.Add(button);
            }
            Label label = new Label();
            label.Height = 35;
            label.Width = 75;
            label.BackColor = Color.Turquoise;
            label.Text = "Kapı";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(42, 2, 30, 0);
            flwPanel.Controls.Add(label);


        }


        private bool Bosmu()
        {
            string boslar = string.Empty;

            foreach (var item in grpKisiselBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tx = (TextBox)item;

                    if (string.IsNullOrEmpty(tx.Text))
                    {
                        boslar += tx.Tag + " ";
                    }
                }
            }

            if (!string.IsNullOrEmpty(boslar))
            {
                MessageBox.Show(boslar, "Boş Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        Button secilenButon;
        private void MyClick(object? sender, EventArgs e)
        {
            grpKisiselBilgiler.Enabled = true;
            Button basilanButon = sender as Button;

            if (basilanButon != null)
            {
                secilenButon = basilanButon;
                txtKoltukNo.Text = basilanButon.Text;
                grpKisiselBilgiler.Enabled = true;
            }

        }

        private void grpKisiselBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Bosmu())
            {
               
                if(rdbErkek.Checked)
                {
                    if(rdbErkek.Checked)
                    {
                        // kullanıcı bilgilerini toparla, sonra listboxa ekle

                        string cinsiyet = rdbErkek.Checked ? rdbKadın.Text : rdbKadın.Text;
                        string ad = txtAd.Text;
                        string soyAd = TXTsOYAD.Text;
                        string telefon = txtTelefon.Text;
                        string koltukNo = txtKoltukNo.Text;
                        string bilgi = $"{koltukNo} noluk koltukta . {ad} {soyAd} {cinsiyet}-tel no: {telefon}";
                        lstSatılanKoltuklar.Items.Add(bilgi);

                     
                        secilenButon.Enabled = false;
                        secilenButon.Tag = cinsiyet;
                     
                        string dosyaYolu = rdbErkek.Checked ? "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\man.png" : "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\woman.png";

                        secilenButon.BackgroundImage = Image.FromFile(dosyaYolu);
                        grpKisiselBilgiler.Enabled = false;
                        MessageBox.Show("Yolcu Eklendi");
                    }
                   else if(rdbKadın.Checked)
                    {
                        if(rdbKadın.Checked)
                        {
                            // kullanıcı bilgilerini toparla, sonra listboxa ekle

                            string cinsiyet = rdbErkek.Checked ? rdbKadın.Text : rdbKadın.Text;
                            string ad = txtAd.Text;
                            string soyAd = TXTsOYAD.Text;
                            string telefon = txtTelefon.Text;
                            string koltukNo = txtKoltukNo.Text;
                            string bilgi = $"{koltukNo} noluk koltukta . {ad} {soyAd} {cinsiyet}-tel no: {telefon}";
                            lstSatılanKoltuklar.Items.Add(bilgi);

                            // seçilen buton kullanılamaz hale getir
                            secilenButon.Enabled = false;
                            secilenButon.Tag = cinsiyet;
                            //   secilenButon.BackColor = rdbErkek.Checked ? Color.Blue : Color.Pink;
                            string dosyaYolu = rdbErkek.Checked ? "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\man.png" : "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\woman.png";

                            secilenButon.BackgroundImage = Image.FromFile(dosyaYolu);
                            grpKisiselBilgiler.Enabled = false;
                            MessageBox.Show("Yolcu Eklendi");
                        }
                    }
                }
                

            }
        }

        //private void CinsiyetKontrol()
        //{
        //    if()
        //}
    }
}

/*   // kullanıcı bilgilerini toparla, sonra listboxa ekle

                string cinsiyet = rdbErkek.Checked ? rdbKadın.Text : rdbKadın.Text;
                string ad = txtAd.Text;
                string soyAd = TXTsOYAD.Text;
                string telefon = txtTelefon.Text;
                string koltukNo = txtKoltukNo.Text;
                string bilgi = $"{koltukNo} noluk koltukta . {ad} {soyAd} {cinsiyet}-tel no: {telefon}";
                lstSatılanKoltuklar.Items.Add(bilgi);

                // seçilen buton kullanılamaz hale getir
                secilenButon.Enabled = false;
                secilenButon.Tag = cinsiyet;
             //   secilenButon.BackColor = rdbErkek.Checked ? Color.Blue : Color.Pink;
                string dosyaYolu = rdbErkek.Checked ? "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\man.png" : "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101-WF\\yzl5101form\\10-Seyahat-BiletUygulaması\\İmages\\woman.png";

                secilenButon.BackgroundImage = Image.FromFile(dosyaYolu);
                grpKisiselBilgiler.Enabled = false;
                MessageBox.Show("Yolcu Eklendi");  */
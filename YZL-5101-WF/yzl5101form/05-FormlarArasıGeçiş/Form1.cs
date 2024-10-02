namespace _05_FormlarArasıGeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            string isim = txtName.Text;
            double sınav1 = double.Parse(txtSınav1.Text);
            double sınav2 = double.Parse(txtSınav2.Text);
            double sınav3 = double.Parse(txtSınav3.Text);
            double ortlama = (sınav1 + sınav2 + sınav3)/ 3;
            string mesaj = ortlama >= 50 ? "Geçti" : "Kaldı";

            Form2 form2 = new Form2(isim,ortlama,mesaj);
            //form2.lblAdSoyad.Text = isim;
            //form2.lblortlama.Text =  ortlama.ToString();
           // form2.lblGeçmeDurumu.Text = mesaj;
            
            form2.ShowDialog();

        }
    }
}

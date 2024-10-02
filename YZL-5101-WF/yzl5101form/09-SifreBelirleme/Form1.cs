namespace _09_SifreBelirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tztPassword_TextChanged(object sender, EventArgs e)
        {
            string sıfre = tztPassword.Text;
           lblZorluk.Text =   CheckPassword(sıfre);

        }
        private string CheckPassword(string sıfre)
        {
            // Any bir koleksıyonda en az bir elemanın belirli bir koşolun sağlayıp sağlamadığını kontrol eder
            // All: Tüm elemanların belirli koşulu sağlayıp sağlamadığını kontrol eder

            if (sıfre.Length <= 6)
            {
               // lblZorluk.Text = "Düşük";
                lblZorluk.ForeColor = Color.Red;

                return "Düşük";
            }

            else if (sıfre.Length <= 6 || sıfre.All(char.IsDigit)) // ıfre.All(char.IsDigit) içerdeki herkes rakam mı 
            {
                //lblZorluk.Text = "Düşük";
                lblZorluk.ForeColor = Color.Red;

                return "Düşük";
            }

            else if (sıfre.Length == 7 && sıfre.Any(char.IsDigit) && sıfre.Any(char.IsLetter))
            // sifrenin uzunluğu 7 ye eşit mi ve içerdeki rakam ve karakter var mı
            {
               // lblZorluk.Text = "Orta";
                lblZorluk.ForeColor = Color.Orange;

                return "Orta";
            }

            else if (sıfre.Length >= 8 && sıfre.Any(char.IsDigit) && sıfre.Any(char.IsLetter))
            {
              //  lblZorluk.Text = "Yüksek";
                lblZorluk.ForeColor = Color.Green;

                return "Yüksek";
            }
            
            return "Düşük";
        }
    }
}

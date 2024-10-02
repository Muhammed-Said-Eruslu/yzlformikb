namespace _01_TutarHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // kullanıcının yazdığı değeri okumak lazım

            string strCost = txtPrice.Text;
            double price = 0, discount1 = 0, discount2 = 0, discount3 = 0;

            bool cashDicount = chkCashDiscount.Checked, campignDiscount = chkCampainDiscount.Checked, specialDiscoun = chkSpecialDiscount.Checked;

            try
            {
                // hata olması mutemel kodlar

                double cost = double.Parse(strCost);
                discount1 = cashDicount ? 0.05 : 0;
                discount2 = campignDiscount ? 0.1 : 0;
                discount3 = specialDiscoun ? 0.1 : 0;
                double totalDiscount = discount1 + discount2 + discount3;
                price = cost * (1 - totalDiscount);
                MessageBox.Show($"Ödemeniz Gereken Tutar Şudur {price}");


            }
            catch (Exception)
            {
                // hata alındığında çalışacak kodlar
               
                if(strCost == null || strCost == string.Empty)
                {
                    MessageBox.Show("Tutar Boş Bırakılamaz");
                }
                else
                {
                    MessageBox.Show("Hatalı İşlem yaptınız");
                }


            }

        }
    }
}

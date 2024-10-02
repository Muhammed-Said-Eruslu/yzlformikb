namespace _06_RenkVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog()== DialogResult.OK)
            {
                BackColor = form2.renkSeçimi;
            }
            
        }
    }
}

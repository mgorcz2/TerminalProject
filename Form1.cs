

using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        private BaseOfProducts b1 = new BaseOfProducts();
        public Form1()
        {
            InitializeComponent();
        }
        private void START_Click(object sender, EventArgs e)
        {
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void rachunek_Click(object sender, EventArgs e)
        {
            textBox2.Text = b1.ToString();
        }

        public void add_Click(object sender, EventArgs e)
        {
            string productCode = display.Text;
            Product foundProduct = b1.Find(productCode);
            if (foundProduct != null)
            {
                textBox2.Text = foundProduct.ToString();
            }
            else
            {
                MessageBox.Show("nie zostal znaleziony");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Base_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        
    }
}

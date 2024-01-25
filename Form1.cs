

using System.Runtime.CompilerServices;
using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        private Transaction t1;
        public Form1()  
        {
            InitializeComponent();
            DisableButtons(); // Wy³¹cz przyciski na starcie
        }
        private void DisableButtons()
        {
            add.Enabled = false;
            add.BackColor = Color.Gray;
        }
        private void EnableButtons()
        {
            // W³¹cz przyciski
            add.Enabled = true;
            add.BackColor = Color.Green;
        }
        public void START_Click(object sender, EventArgs e)
        {
            EnableButtons();
            t1 = new Transaction();
            t1.Start();
            textBox2.Text = "";

        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public void rachunek_Click(object sender, EventArgs e)
        {
        }

        public void add_Click(object sender, EventArgs e)
        {
            string productCode = display.Text;
            Product foundProduct = t1.GetBaseOfProducts().Find(productCode);
            if (foundProduct != null)
            {
                t1.GetReceipt().AddProduct(foundProduct);
            }
            else
            {
                MessageBox.Show("nie zostal znaleziony");
            }

            textBox2.Text = t1.GetReceipt().ToString();
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

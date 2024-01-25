

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

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void rachunek_Click(object sender, EventArgs e)
        {
            textBox2.Text = b1.ToString();
            b1.RemoveProduct("0001");
            textBox2.Text = b1.ToString();

        }

        public void add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

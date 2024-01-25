

using System.Media;
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
            rachunek.Enabled = false;
            rachunek.BackColor = Color.Gray;
        }
        private void EnableButtons()
        {
            // W³¹cz przyciski
            add.Enabled = true;
            add.BackColor = Color.Green;
            rachunek.Enabled = true;
            rachunek.BackColor = Color.LightCoral;
        }

        private void AddTextToTextBox<T>(T text)
        {
            // Funkcja generyczna, która dodaje przekazany tekst do TextBoxa
            display.Text += text.ToString();
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
            t1.GetReceipt().RemoveLast();
            textBox2.Text = GetUpdatedText();
        }
        private string GetUpdatedText()
        {
            string newText = string.Join(Environment.NewLine, t1.GetReceipt());

            return newText;
        }
        public void add_Click(object sender, EventArgs e)
        {
            string productCode = display.Text;
            Product foundProduct = t1.GetBaseOfProducts().Find(productCode);
            if (foundProduct != null)
            {
                t1.GetReceipt().AddProduct(foundProduct);
                adderror.ForeColor = Color.Green;
                adderror.Text = "Dodano";
            }
            else
            {
                adderror.ForeColor = Color.Red;
                adderror.Text = "Nie znaleziono produktu o takim kodzie";
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

        private void emergency_Click(object sender, EventArgs e)
        {
            SoundPlayer s1 = new SoundPlayer("Emergency.wav");
            s1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTextToTextBox(button1.Text);
        }
    }
}

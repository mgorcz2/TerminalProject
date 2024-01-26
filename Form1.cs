

using System.Media;
using System.Runtime.CompilerServices;
using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        private Transaction t1;
        private readonly BaseOfProducts baseOfProducts;
        public void Form1_Load(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
            DisableButtons(); // Wy³¹cz przyciski na starcie
            EnableDisplay(false);
        }
        private void DisableButtons()
        {
            add.Enabled = false;
            add.BackColor = Color.Gray;
            delLastFromReceipt.Enabled = false;
            delLastFromReceipt.BackColor = Color.Gray;
        }
        private void EnableButtons()
        {
            // W³¹cz przyciski
            add.Enabled = true;
            add.BackColor = Color.Green;
            delLastFromReceipt.Enabled = true;
            delLastFromReceipt.BackColor = Color.LightCoral;
        }

        private void EnableDisplay(bool on)
        {
            if (on)
            {
                display.Enabled = true;
            }
            else
            {
                display.Enabled = false;
            }
        }

        public void START_Click(object sender, EventArgs e)
        {
            EnableButtons();
            ReceiptBox.Text = "";
            display.Text = "";
            EnableDisplay(true);
            t1 = new Transaction();
            t1.StartTransaction();
        }

        public void delLastFromReceiptButton_Click(object sender, EventArgs e)
        {
            t1.GetReceipt().RemoveLast();
            ReceiptBox.Text = GetUpdatedText();
        }
        private string GetUpdatedText()
        {
            string newText = string.Join(Environment.NewLine, t1.GetReceipt());

            return newText;
        }
        public void add_Click(object sender, EventArgs e)
        {
            string productCode = display.Text;
            Product foundProduct = t1.addItem(productCode,BaseOfProducts.Instance);
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

            ReceiptBox.Text = t1.GetReceipt().ToString();
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

        public void ButtonValueToDisplay(Button button)
        {
            if (display.Text.Length < 4)
            {
                display.Text += button.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ButtonValueToDisplay(button0);
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (display.Text.Length>0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            
        }
    }
}

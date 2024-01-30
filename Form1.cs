

using System.Media;
using System.Runtime.CompilerServices;
using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        private Transaction t1;
        private readonly BaseOfProducts baseOfProducts;
        Form2 form2 = new();
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
            delChosenFromReceipt.Enabled = false;
            delChosenFromReceipt.BackColor = Color.Gray;
            PaymentButton.Enabled = false;
            PaymentButton.BackColor = Color.Gray;
        }
        private void EnableButtons()
        {
            // W³¹cz przyciski
            add.Enabled = true;
            add.BackColor = Color.Green;
            delChosenFromReceipt.Enabled = true;
            delChosenFromReceipt.BackColor = Color.OrangeRed;
            PaymentButton.Enabled = true;
            PaymentButton.BackColor = Color.DarkOrange;
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
            display.Text = "";
            EnableDisplay(true);
            t1 = new Transaction();
            t1.StartTransaction();
            ReceiptBox.Clear();
        }

        public void delChosenFromReceiptButton_Click(object sender, EventArgs e)
        {
            if (ReceiptBox.SelectedItems.Count > 0)
            {
                t1.GetReceipt().RemoveSelectedProducts(ReceiptBox);
            }
            ReceiptBoxRefresh();
        }
        private void ReceiptBoxRefresh()
        {
            ReceiptBox.Clear();
            ReceiptBox.Columns.Add("Nazwa produktu", 100);
            ReceiptBox.Columns.Add("Cena", 100);
            ReceiptBox.View = View.Details;
            foreach (var el in t1.GetReceipt().getItems())
            {
                ListViewItem item = new ListViewItem(el.getName());
                item.SubItems.Add(el.getPrice().ToString("C2"));
                ReceiptBox.Items.Add(item);
            }

            if (ReceiptBox.Items.Count > 1)
            {
                ReceiptBox.EnsureVisible(ReceiptBox.Items.Count - 1);
            }
        }
        public void add_Click(object sender, EventArgs e)
        {
            string productCode = display.Text;
            Product foundProduct = t1.addItem(productCode, BaseOfProducts.Instance);
            if (foundProduct != null)
            {
                t1.GetReceipt().AddProduct(foundProduct);
                adderror.ForeColor = Color.Green;
                adderror.Text = "Dodano produkt do rachunku";
                ReceiptBoxRefresh();
            }
            else
            {
                adderror.ForeColor = Color.Red;
                adderror.Text = "Nie znaleziono produktu o takim kodzie";
            }
        }

        private void PaymentButtonClick(object sender, EventArgs e)
        {
        }

        private void Base_Click(object sender, EventArgs e)
        {
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
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }

        }

        private void receiptBoxColumnChanger(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ReceiptBox.Columns[e.ColumnIndex].Width;
        }
    }
}

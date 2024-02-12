
using KasaFiskalna.Produkt;
using System.Media;
using KasaFiskalna.Payment;

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        private Transaction t1;
        private Form2 form2Instance;
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
            CashPaymentCheckBox.Enabled = false;
            CashPaymentCheckBox.BackColor = Color.Gray;
            TerminaPaymentCheckBox.Enabled = false;
            TerminaPaymentCheckBox.BackColor = Color.Gray;
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
            CashPaymentCheckBox.Enabled = true;
            CashPaymentCheckBox.BackColor= Color.LightYellow;
            TerminaPaymentCheckBox.Enabled = true;
            TerminaPaymentCheckBox.BackColor = Color.LightYellow;
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
            RefreshTotalLabel();
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
                RefreshTotalLabel();
            }
            else
            {
                adderror.ForeColor = Color.Red;
                adderror.Text = "Nie znaleziono produktu o takim kodzie";
            }
        }

        private void RefreshTotalLabel()
        {
            TotalPriceLabel.Text = "£¹czna kwota: " + t1.GetReceipt().getTotalPrice().ToString("C2");
        }
        private void PaymentButtonClick(object sender, EventArgs e)
        {
            if (CashPaymentCheckBox.Checked && !TerminaPaymentCheckBox.Checked)
            {
                CashPayment cashPayment = new CashPayment();
                if(cashPayment.isPaymentSuccessful(t1))
                {
                    t1.SaveAndPrintReceipt(ReceiptBox);
                    t1.End();
                }
            }
            else if (!CashPaymentCheckBox.Checked && TerminaPaymentCheckBox.Checked)
            {
                TerminalPayment terminalPayment = new TerminalPayment();
                if (terminalPayment.isPaymentSuccessful(t1))
                {
                    t1.SaveAndPrintReceipt(ReceiptBox);
                    t1.End();
                }
            }
            else
            {
                CashPaymentCheckBox.Checked= false;
                TerminaPaymentCheckBox.Checked = false;
                MessageBox.Show("Wybierz jedn¹ opcje p³atnoœci");
            }
        }
        private void Base_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2();
                form2Instance.Show();
            }
            else
            {
                form2Instance.Focus();
            }
        }
        private void emergency_Click(object sender, EventArgs e)
        {
            SoundPlayer s1 = new SoundPlayer("Emergency.wav");
            s1.Play();
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
        private void ButtonValueToDisplay(object sender, EventArgs e)
        {
            if (display.Text.Length < 4)
            {
                display.Text += ((Button)sender).Text;
            }
        }
    }
}

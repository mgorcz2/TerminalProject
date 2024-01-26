using System.Security.Cryptography;
using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form2 : Form
    {
        internal Form2()
        {
            InitializeComponent();
            listViewRefresh();
            
        }

        public void listViewRefresh()
        {
            listView1.Clear();
            listView1.Columns.Add("Code", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.View = View.Details;
            foreach (var product in BaseOfProducts.Instance.GetProducts())
            {
                string[] row = { product.getCode(), product.getName(), product.getPrice().ToString("C") };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            listView1.Scrollable = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            string searchProduct = findBox.Text;
            Product product = BaseOfProducts.Instance.FindByNameProduct(searchProduct);
            if (product != null)
            {
                ResultOfFindProduct.Text = product.getCode();
            }
            else
            {
                ResultOfFindProduct.Text = "BRAK";
            }
        }

        private void findBox_Click(object sender, EventArgs e)
        {
            findBox.Text = "";
        }

        private void AddProductToBaseButton_Click(object sender, EventArgs e)
        {
            double price;
            if (Double.TryParse(PriceBox.Text, out price))
            {
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format ceny");
            }
            Product addedProduct = new Product(BaseOfProducts.Instance.RandomCode(), NameBox.Text, price);
            if (BaseOfProducts.Instance.FindByNameProduct(addedProduct.getName()) == null)
            {
                BaseOfProducts.Instance.AddProduct(addedProduct);
                listViewRefresh();
            }
            else
            {
                MessageBox.Show("Produkt o takiej nazwie istnieje");
            }
        }
    }
}

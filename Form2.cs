using KasaFiskalna.Produkt;

namespace KasaFiskalna
{
    public partial class Form2 : Form
    {
        internal Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                ResultOfFindProduct.Text = "Brak produktu o takiej nazwie";
            }
        }

        private void findBox_Click(object sender, EventArgs e)
        {
            findBox.Text = "";
        }
    }
}

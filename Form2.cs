using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            textBox1.Text = BaseOfProducts.Instance.ToString();
        }
    }
}

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
            textBox1.Text = BaseOfProducts.Instance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseOfProducts.Instance.RemoveProduct("0001");
        }
    }
}

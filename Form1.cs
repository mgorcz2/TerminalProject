

namespace KasaFiskalna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rachunek_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
            
        }
    }
}

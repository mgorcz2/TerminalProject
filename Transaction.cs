using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaFiskalna.Produkt;
using KasaFiskalna.receipt;

namespace KasaFiskalna
{
    internal class Transaction : IKasa
    {
        private Receipt receipt;
        private List<Transaction> historyTransactions = new List<Transaction>();    //database
        public Receipt GetReceipt()
        {
            return receipt;
        }

        public Product addItem(String productCode, BaseOfProducts baseof)
        {
           return baseof.FindByCodeProduct(productCode);
        }

        public void End()
        {
            historyTransactions.Add(this);
        }
        public void StartTransaction()
        {
            receipt = new Receipt();
        }
        public void SaveAndPrintReceipt(ListView receiptBox)    //should export transaction and print receiptbox
        {
            if (receiptBox.Columns.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save As";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(receiptBox.Columns[0].Text + "\t" + receiptBox.Columns[1].Text);
                        foreach (ListViewItem item in receiptBox.Items)
                        {
                            writer.WriteLine(item.SubItems[0].Text + "\t\t" + item.SubItems[1].Text);
                        }
                        writer.WriteLine("\tKwota: "+receipt.getTotalPrice().ToString("C2"));
                        writer.WriteLine(receipt.getDate());
                    }
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += (sender, e) => PrintPageHandler(sender, e, filePath);
                    pd.Print();
                    MessageBox.Show("DRUKOWANIE");
                }
            }
            
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e, string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Font font = new Font("Arial", 10);
                float yPos = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    e.Graphics.DrawString(line, font, Brushes.Black, 10, yPos);
                    yPos += 15;
                }
            }

        }
    }
}
    

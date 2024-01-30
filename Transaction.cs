using System;
using System.Collections.Generic;
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
        private List<Transaction> historyTransactions;    //database
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
        public void SaveAndPrintReceipt(ListView receiptBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save As";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(receiptBox.Columns[0].Text + "\t" + receiptBox.Columns[1].Text);
                    foreach (ListViewItem item in receiptBox.Items)
                    {
                        writer.WriteLine(item.SubItems[0].Text + "\t\t" + item.SubItems[1].Text);
                    }
                    writer.WriteLine(receipt.getDate()+"\t"+receipt.getTotalPrice()+"zł");
                }
            }
            MessageBox.Show("eksport");
        }
    }
}
    

namespace KasaFiskalna
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            FindProductButton = new Button();
            ResultOfFindProduct = new TextBox();
            findBox = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(302, 568);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FindProductButton
            // 
            FindProductButton.Location = new Point(340, 41);
            FindProductButton.Name = "FindProductButton";
            FindProductButton.Size = new Size(220, 44);
            FindProductButton.TabIndex = 1;
            FindProductButton.Text = "SZUKAJ PRODUKTU";
            FindProductButton.UseVisualStyleBackColor = true;
            FindProductButton.Click += FindProductButton_Click;
            // 
            // ResultOfFindProduct
            // 
            ResultOfFindProduct.Location = new Point(566, 24);
            ResultOfFindProduct.Multiline = true;
            ResultOfFindProduct.Name = "ResultOfFindProduct";
            ResultOfFindProduct.Size = new Size(87, 44);
            ResultOfFindProduct.TabIndex = 3;
            // 
            // findBox
            // 
            findBox.Location = new Point(340, 12);
            findBox.Name = "findBox";
            findBox.Size = new Size(220, 23);
            findBox.TabIndex = 4;
            findBox.Text = "nazwa produktu";
            findBox.TextAlign = HorizontalAlignment.Center;
            findBox.Click += findBox_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1023, 623);
            Controls.Add(findBox);
            Controls.Add(ResultOfFindProduct);
            Controls.Add(FindProductButton);
            Controls.Add(listView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button FindProductButton;
        private TextBox ResultOfFindProduct;
        private TextBox findBox;
    }
}
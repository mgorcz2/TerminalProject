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
            AddProductToBaseButton = new Button();
            RemoveProductFromBaseButton = new Button();
            NameBox = new TextBox();
            PriceBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(322, 384);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // FindProductButton
            // 
            FindProductButton.BackColor = SystemColors.InactiveCaption;
            FindProductButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FindProductButton.ForeColor = Color.Red;
            FindProductButton.Location = new Point(340, 47);
            FindProductButton.Name = "FindProductButton";
            FindProductButton.Size = new Size(220, 44);
            FindProductButton.TabIndex = 1;
            FindProductButton.Text = "SZUKAJ PRODUKTU";
            FindProductButton.UseVisualStyleBackColor = false;
            FindProductButton.Click += FindProductButton_Click;
            // 
            // ResultOfFindProduct
            // 
            ResultOfFindProduct.BackColor = Color.FromArgb(192, 255, 192);
            ResultOfFindProduct.Enabled = false;
            ResultOfFindProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ResultOfFindProduct.ForeColor = Color.Red;
            ResultOfFindProduct.Location = new Point(566, 23);
            ResultOfFindProduct.Multiline = true;
            ResultOfFindProduct.Name = "ResultOfFindProduct";
            ResultOfFindProduct.Size = new Size(93, 45);
            ResultOfFindProduct.TabIndex = 3;
            ResultOfFindProduct.TextAlign = HorizontalAlignment.Center;
            // 
            // findBox
            // 
            findBox.BackColor = SystemColors.ScrollBar;
            findBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            findBox.Location = new Point(340, 12);
            findBox.Name = "findBox";
            findBox.Size = new Size(220, 29);
            findBox.TabIndex = 4;
            findBox.Text = "nazwa produktu";
            findBox.TextAlign = HorizontalAlignment.Center;
            findBox.Click += findBox_Click;
            // 
            // AddProductToBaseButton
            // 
            AddProductToBaseButton.BackColor = Color.Honeydew;
            AddProductToBaseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddProductToBaseButton.Location = new Point(474, 348);
            AddProductToBaseButton.Name = "AddProductToBaseButton";
            AddProductToBaseButton.Size = new Size(133, 48);
            AddProductToBaseButton.TabIndex = 5;
            AddProductToBaseButton.Text = "Dodaj produkt do bazy";
            AddProductToBaseButton.UseVisualStyleBackColor = false;
            AddProductToBaseButton.Click += AddProductToBaseButton_Click;
            // 
            // RemoveProductFromBaseButton
            // 
            RemoveProductFromBaseButton.BackColor = Color.RosyBrown;
            RemoveProductFromBaseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RemoveProductFromBaseButton.Location = new Point(383, 97);
            RemoveProductFromBaseButton.Name = "RemoveProductFromBaseButton";
            RemoveProductFromBaseButton.Size = new Size(133, 50);
            RemoveProductFromBaseButton.TabIndex = 6;
            RemoveProductFromBaseButton.Text = "Usuń produkt z bazy";
            RemoveProductFromBaseButton.UseVisualStyleBackColor = false;
            RemoveProductFromBaseButton.Click += RemoveProductFromBaseButton_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(438, 402);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(544, 402);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(100, 23);
            PriceBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(575, 428);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 12;
            label3.Text = "CENA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(459, 428);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 11;
            label4.Text = "NAZWA";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(712, 485);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(PriceBox);
            Controls.Add(NameBox);
            Controls.Add(RemoveProductFromBaseButton);
            Controls.Add(AddProductToBaseButton);
            Controls.Add(ResultOfFindProduct);
            Controls.Add(findBox);
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
        private Button AddProductToBaseButton;
        private Button RemoveProductFromBaseButton;
        private TextBox NameBox;
        private TextBox PriceBox;
        private Label label3;
        private Label label4;
    }
}
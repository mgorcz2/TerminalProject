namespace KasaFiskalna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttondel = new Button();
            textBox1 = new TextBox();
            START = new Button();
            add = new Button();
            rachunek = new Button();
            button10 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 129);
            button1.Name = "button1";
            button1.Size = new Size(58, 58);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(76, 129);
            button2.Name = "button2";
            button2.Size = new Size(58, 58);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(140, 129);
            button3.Name = "button3";
            button3.Size = new Size(58, 58);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 193);
            button4.Name = "button4";
            button4.Size = new Size(58, 58);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(76, 193);
            button5.Name = "button5";
            button5.Size = new Size(58, 58);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(140, 193);
            button6.Name = "button6";
            button6.Size = new Size(58, 58);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 257);
            button7.Name = "button7";
            button7.Size = new Size(58, 58);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(76, 257);
            button8.Name = "button8";
            button8.Size = new Size(58, 58);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(140, 257);
            button9.Name = "button9";
            button9.Size = new Size(58, 58);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(12, 321);
            button0.Name = "button0";
            button0.Size = new Size(58, 58);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttondel
            // 
            buttondel.Location = new Point(140, 321);
            buttondel.Name = "buttondel";
            buttondel.Size = new Size(58, 58);
            buttondel.TabIndex = 10;
            buttondel.Text = "DELETE";
            buttondel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 72);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 51);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = false;
            // 
            // START
            // 
            START.BackColor = Color.FromArgb(192, 255, 192);
            START.Cursor = Cursors.Hand;
            START.FlatStyle = FlatStyle.Popup;
            START.ForeColor = SystemColors.ControlText;
            START.Location = new Point(12, 12);
            START.Name = "START";
            START.Size = new Size(111, 35);
            START.TabIndex = 12;
            START.Text = "START";
            START.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(192, 255, 192);
            add.Location = new Point(204, 72);
            add.Name = "add";
            add.Size = new Size(92, 43);
            add.TabIndex = 13;
            add.Text = "DODAJ";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // rachunek
            // 
            rachunek.Location = new Point(409, 45);
            rachunek.Name = "rachunek";
            rachunek.Size = new Size(140, 49);
            rachunek.TabIndex = 14;
            rachunek.Text = "RACHUNEK";
            rachunek.UseVisualStyleBackColor = true;
            rachunek.Click += rachunek_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 192, 192);
            button10.Location = new Point(204, 327);
            button10.Name = "button10";
            button10.Size = new Size(92, 46);
            button10.TabIndex = 15;
            button10.Text = "ZAKONCZ";
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(388, 100);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(187, 273);
            textBox2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(621, 461);
            Controls.Add(textBox2);
            Controls.Add(button10);
            Controls.Add(rachunek);
            Controls.Add(add);
            Controls.Add(START);
            Controls.Add(textBox1);
            Controls.Add(buttondel);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttondel;
        private TextBox textBox1;
        private Button START;
        private Button add;
        private Button rachunek;
        private Button button10;
        private TextBox textBox2;
    }
}

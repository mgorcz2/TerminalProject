﻿namespace KasaFiskalna
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
            button2 = new Button();
            button5 = new Button();
            button9 = new Button();
            button6 = new Button();
            button8 = new Button();
            buttondel = new Button();
            button0 = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            delChosenFromReceipt = new Button();
            display = new TextBox();
            add = new Button();
            START = new Button();
            PaymentButton = new Button();
            BaseButton = new Button();
            emergency = new Button();
            panel1 = new Panel();
            TerminaPaymentCheckBox = new CheckBox();
            CashPaymentCheckBox = new CheckBox();
            TotalPriceLabel = new Label();
            adderror = new Label();
            ReceiptBox = new ListView();
            nameofproduct = new ColumnHeader();
            priceofproduct = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button2.Location = new Point(201, 86);
            button2.Name = "button2";
            button2.Size = new Size(163, 90);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonValueToDisplay;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button5.Location = new Point(200, 182);
            button5.Name = "button5";
            button5.Size = new Size(163, 90);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonValueToDisplay;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button9.Location = new Point(369, 278);
            button9.Name = "button9";
            button9.Size = new Size(163, 90);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonValueToDisplay;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button6.Location = new Point(369, 182);
            button6.Name = "button6";
            button6.Size = new Size(163, 90);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonValueToDisplay;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button8.Location = new Point(200, 278);
            button8.Name = "button8";
            button8.Size = new Size(163, 90);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonValueToDisplay;
            // 
            // buttondel
            // 
            buttondel.Anchor = AnchorStyles.None;
            buttondel.Cursor = Cursors.Hand;
            buttondel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttondel.Location = new Point(369, 374);
            buttondel.Name = "buttondel";
            buttondel.Size = new Size(163, 90);
            buttondel.TabIndex = 10;
            buttondel.Text = "DELETE";
            buttondel.UseVisualStyleBackColor = true;
            buttondel.Click += buttondel_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.None;
            button0.Cursor = Cursors.Hand;
            button0.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button0.Location = new Point(28, 374);
            button0.Name = "button0";
            button0.Size = new Size(163, 90);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += ButtonValueToDisplay;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button7.Location = new Point(28, 278);
            button7.Name = "button7";
            button7.Size = new Size(163, 90);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonValueToDisplay;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button4.Location = new Point(31, 182);
            button4.Name = "button4";
            button4.Size = new Size(163, 90);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonValueToDisplay;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(31, 86);
            button1.Name = "button1";
            button1.Size = new Size(163, 90);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonValueToDisplay;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button3.Location = new Point(369, 86);
            button3.Name = "button3";
            button3.Size = new Size(163, 90);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonValueToDisplay;
            // 
            // delChosenFromReceipt
            // 
            delChosenFromReceipt.Anchor = AnchorStyles.None;
            delChosenFromReceipt.BackColor = Color.IndianRed;
            delChosenFromReceipt.Cursor = Cursors.Hand;
            delChosenFromReceipt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            delChosenFromReceipt.ForeColor = Color.White;
            delChosenFromReceipt.Location = new Point(538, 468);
            delChosenFromReceipt.Name = "delChosenFromReceipt";
            delChosenFromReceipt.Size = new Size(126, 27);
            delChosenFromReceipt.TabIndex = 14;
            delChosenFromReceipt.Text = "Usuń wybrane";
            delChosenFromReceipt.UseVisualStyleBackColor = false;
            delChosenFromReceipt.Click += delChosenFromReceiptButton_Click;
            // 
            // display
            // 
            display.Anchor = AnchorStyles.None;
            display.BackColor = SystemColors.Info;
            display.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            display.ForeColor = Color.Black;
            display.Location = new Point(250, 23);
            display.MaxLength = 4;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(282, 51);
            display.TabIndex = 11;
            display.Text = "----";
            display.TextAlign = HorizontalAlignment.Center;
            display.WordWrap = false;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.None;
            add.BackColor = Color.FromArgb(192, 255, 192);
            add.Cursor = Cursors.Hand;
            add.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            add.Location = new Point(538, 23);
            add.Name = "add";
            add.Size = new Size(117, 51);
            add.TabIndex = 13;
            add.Text = "DODAJ";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // START
            // 
            START.Anchor = AnchorStyles.None;
            START.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            START.BackColor = Color.FromArgb(192, 255, 192);
            START.Cursor = Cursors.Hand;
            START.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            START.ForeColor = SystemColors.ControlText;
            START.Location = new Point(31, 23);
            START.Name = "START";
            START.Size = new Size(205, 50);
            START.TabIndex = 12;
            START.Text = "Rozpocznij transakcje";
            START.UseVisualStyleBackColor = false;
            START.Click += START_Click;
            // 
            // PaymentButton
            // 
            PaymentButton.Anchor = AnchorStyles.None;
            PaymentButton.BackColor = Color.FromArgb(255, 255, 128);
            PaymentButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PaymentButton.Location = new Point(670, 516);
            PaymentButton.Name = "PaymentButton";
            PaymentButton.Size = new Size(119, 79);
            PaymentButton.TabIndex = 15;
            PaymentButton.Text = "PŁATNOŚĆ";
            PaymentButton.UseVisualStyleBackColor = false;
            PaymentButton.Click += PaymentButtonClick;
            // 
            // BaseButton
            // 
            BaseButton.Anchor = AnchorStyles.None;
            BaseButton.Location = new Point(31, 609);
            BaseButton.Name = "BaseButton";
            BaseButton.Size = new Size(138, 33);
            BaseButton.TabIndex = 17;
            BaseButton.Text = "Baza produktów";
            BaseButton.UseVisualStyleBackColor = true;
            BaseButton.Click += Base_Click;
            // 
            // emergency
            // 
            emergency.Anchor = AnchorStyles.None;
            emergency.BackColor = Color.Red;
            emergency.Cursor = Cursors.Cross;
            emergency.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emergency.ForeColor = SystemColors.ButtonFace;
            emergency.Location = new Point(201, 532);
            emergency.Name = "emergency";
            emergency.Size = new Size(183, 109);
            emergency.TabIndex = 18;
            emergency.Text = "EMERGENCY BUTTON";
            emergency.UseVisualStyleBackColor = false;
            emergency.Click += emergency_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(TerminaPaymentCheckBox);
            panel1.Controls.Add(CashPaymentCheckBox);
            panel1.Controls.Add(TotalPriceLabel);
            panel1.Controls.Add(adderror);
            panel1.Controls.Add(ReceiptBox);
            panel1.Controls.Add(emergency);
            panel1.Controls.Add(BaseButton);
            panel1.Controls.Add(PaymentButton);
            panel1.Controls.Add(START);
            panel1.Controls.Add(add);
            panel1.Controls.Add(display);
            panel1.Controls.Add(delChosenFromReceipt);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button0);
            panel1.Controls.Add(buttondel);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 644);
            panel1.TabIndex = 18;
            // 
            // TerminaPaymentCheckBox
            // 
            TerminaPaymentCheckBox.Anchor = AnchorStyles.None;
            TerminaPaymentCheckBox.AutoSize = true;
            TerminaPaymentCheckBox.BackColor = Color.LightYellow;
            TerminaPaymentCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            TerminaPaymentCheckBox.Cursor = Cursors.Hand;
            TerminaPaymentCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TerminaPaymentCheckBox.ForeColor = Color.FromArgb(255, 128, 0);
            TerminaPaymentCheckBox.Location = new Point(560, 557);
            TerminaPaymentCheckBox.Name = "TerminaPaymentCheckBox";
            TerminaPaymentCheckBox.Size = new Size(109, 25);
            TerminaPaymentCheckBox.TabIndex = 24;
            TerminaPaymentCheckBox.Text = "TERMINAL";
            TerminaPaymentCheckBox.UseVisualStyleBackColor = false;
            // 
            // CashPaymentCheckBox
            // 
            CashPaymentCheckBox.Anchor = AnchorStyles.None;
            CashPaymentCheckBox.AutoSize = true;
            CashPaymentCheckBox.BackColor = Color.LightYellow;
            CashPaymentCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            CashPaymentCheckBox.Cursor = Cursors.Hand;
            CashPaymentCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CashPaymentCheckBox.ForeColor = Color.Green;
            CashPaymentCheckBox.Location = new Point(561, 526);
            CashPaymentCheckBox.Name = "CashPaymentCheckBox";
            CashPaymentCheckBox.Size = new Size(108, 25);
            CashPaymentCheckBox.TabIndex = 23;
            CashPaymentCheckBox.Text = "GOTÓWKA";
            CashPaymentCheckBox.UseVisualStyleBackColor = false;
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.Anchor = AnchorStyles.None;
            TotalPriceLabel.BackColor = Color.FromArgb(192, 255, 255);
            TotalPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TotalPriceLabel.Location = new Point(670, 468);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(119, 45);
            TotalPriceLabel.TabIndex = 22;
            TotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adderror
            // 
            adderror.Anchor = AnchorStyles.None;
            adderror.BackColor = Color.DarkGray;
            adderror.Location = new Point(661, 23);
            adderror.Name = "adderror";
            adderror.Size = new Size(128, 51);
            adderror.TabIndex = 21;
            // 
            // ReceiptBox
            // 
            ReceiptBox.Anchor = AnchorStyles.None;
            ReceiptBox.Columns.AddRange(new ColumnHeader[] { nameofproduct, priceofproduct });
            ReceiptBox.FullRowSelect = true;
            ReceiptBox.GridLines = true;
            ReceiptBox.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ReceiptBox.Location = new Point(538, 86);
            ReceiptBox.Name = "ReceiptBox";
            ReceiptBox.Size = new Size(251, 378);
            ReceiptBox.TabIndex = 20;
            ReceiptBox.UseCompatibleStateImageBehavior = false;
            ReceiptBox.ColumnWidthChanging += receiptBoxColumnChanger;
            // 
            // nameofproduct
            // 
            nameofproduct.Text = "Nazwa produktu";
            nameofproduct.Width = 30;
            // 
            // priceofproduct
            // 
            priceofproduct.Text = "Cena produktu";
            priceofproduct.Width = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(822, 648);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button5;
        private Button button9;
        private Button button6;
        private Button button8;
        private Button buttondel;
        private Button button0;
        private Button button7;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button delChosenFromReceipt;
        public TextBox display;
        private Button add;
        private Button START;
        private Button PaymentButton;
        private Button BaseButton;
        private Button emergency;
        private Panel panel1;
        private ListView ReceiptBox;
        private ColumnHeader nameofproduct;
        private ColumnHeader priceofproduct;
        private Label adderror;
        private Label TotalPriceLabel;
        private CheckBox TerminaPaymentCheckBox;
        private CheckBox CashPaymentCheckBox;
    }
}

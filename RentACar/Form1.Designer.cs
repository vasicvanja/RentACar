﻿namespace RentACar
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
            lbCars = new ListBox();
            groupBox1 = new GroupBox();
            btnDeleteCar = new Button();
            btnAddCar = new Button();
            groupBox2 = new GroupBox();
            btnRentalHistory = new Button();
            btnHistoryOfRentals = new Button();
            btnDeleteClient = new Button();
            btnAddClient = new Button();
            lbCustomers = new ListBox();
            groupBox3 = new GroupBox();
            tbMinRent = new TextBox();
            label9 = new Label();
            tbMaxRent = new TextBox();
            label15 = new Label();
            tbAvgRent = new TextBox();
            label7 = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            tbTotalPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDetails = new Button();
            btnDeleteRental = new Button();
            btnAddRental = new Button();
            lbRentals = new ListBox();
            label4 = new Label();
            tbTotalEarned = new TextBox();
            tbCheapest = new TextBox();
            label5 = new Label();
            tbMostExpensive = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lbCars
            // 
            lbCars.FormattingEnabled = true;
            lbCars.ItemHeight = 20;
            lbCars.Location = new Point(6, 28);
            lbCars.Margin = new Padding(3, 4, 3, 4);
            lbCars.Name = "lbCars";
            lbCars.Size = new Size(348, 464);
            lbCars.TabIndex = 0;
            lbCars.SelectedIndexChanged += lbCars_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteCar);
            groupBox1.Controls.Add(btnAddCar);
            groupBox1.Controls.Add(lbCars);
            groupBox1.Location = new Point(43, 39);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(360, 669);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автомобили";
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Enabled = false;
            btnDeleteCar.Location = new Point(6, 563);
            btnDeleteCar.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(347, 31);
            btnDeleteCar.TabIndex = 2;
            btnDeleteCar.Text = "Избриши автомобил";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(6, 509);
            btnAddCar.Margin = new Padding(3, 4, 3, 4);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(347, 31);
            btnAddCar.TabIndex = 1;
            btnAddCar.Text = "Додади автомобил";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRentalHistory);
            groupBox2.Controls.Add(btnHistoryOfRentals);
            groupBox2.Controls.Add(btnDeleteClient);
            groupBox2.Controls.Add(btnAddClient);
            groupBox2.Controls.Add(lbCustomers);
            groupBox2.Location = new Point(445, 39);
            groupBox2.Margin = new Padding(3, 5, 3, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(360, 669);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Клиенти";
            // 
            // btnRentalHistory
            // 
            btnRentalHistory.Enabled = false;
            btnRentalHistory.Location = new Point(7, 617);
            btnRentalHistory.Margin = new Padding(3, 4, 3, 4);
            btnRentalHistory.Name = "btnRentalHistory";
            btnRentalHistory.Size = new Size(347, 31);
            btnRentalHistory.TabIndex = 4;
            btnRentalHistory.Text = "Историја на изнајмувања";
            btnRentalHistory.UseVisualStyleBackColor = true;
            btnRentalHistory.Click += btnRentalHistory_Click;
            // 
            // btnHistoryOfRentals
            // 
            btnHistoryOfRentals.Location = new Point(7, 823);
            btnHistoryOfRentals.Margin = new Padding(3, 5, 3, 5);
            btnHistoryOfRentals.Name = "btnHistoryOfRentals";
            btnHistoryOfRentals.Size = new Size(398, 41);
            btnHistoryOfRentals.TabIndex = 3;
            btnHistoryOfRentals.Text = "Историја на изнајмувања";
            btnHistoryOfRentals.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Enabled = false;
            btnDeleteClient.Location = new Point(6, 563);
            btnDeleteClient.Margin = new Padding(3, 4, 3, 4);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(347, 31);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Избриши клиент";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(6, 509);
            btnAddClient.Margin = new Padding(3, 4, 3, 4);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(347, 31);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Додади клиент";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 20;
            lbCustomers.Location = new Point(6, 29);
            lbCustomers.Margin = new Padding(3, 5, 3, 5);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(348, 464);
            lbCustomers.TabIndex = 0;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbMinRent);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbMaxRent);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(tbAvgRent);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(dtpTo);
            groupBox3.Controls.Add(dtpFrom);
            groupBox3.Controls.Add(tbTotalPrice);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnDetails);
            groupBox3.Controls.Add(btnDeleteRental);
            groupBox3.Controls.Add(btnAddRental);
            groupBox3.Controls.Add(lbRentals);
            groupBox3.Location = new Point(863, 39);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(406, 926);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Изнајмувања";
            // 
            // tbMinRent
            // 
            tbMinRent.Location = new Point(196, 892);
            tbMinRent.Name = "tbMinRent";
            tbMinRent.ReadOnly = true;
            tbMinRent.Size = new Size(204, 27);
            tbMinRent.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 895);
            label9.Name = "label9";
            label9.Size = new Size(181, 20);
            label9.TabIndex = 14;
            label9.Text = "Најефтино изнајмување:";
            // 
            // tbMaxRent
            // 
            tbMaxRent.Location = new Point(182, 847);
            tbMaxRent.Name = "tbMaxRent";
            tbMaxRent.ReadOnly = true;
            tbMaxRent.Size = new Size(215, 27);
            tbMaxRent.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 850);
            label15.Name = "label15";
            label15.Size = new Size(170, 20);
            label15.TabIndex = 12;
            label15.Text = "Најскапо изнајмување:";
            // 
            // tbAvgRent
            // 
            tbAvgRent.Location = new Point(247, 801);
            tbAvgRent.Name = "tbAvgRent";
            tbAvgRent.ReadOnly = true;
            tbAvgRent.Size = new Size(150, 27);
            tbAvgRent.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 804);
            label7.Name = "label7";
            label7.Size = new Size(235, 20);
            label7.TabIndex = 10;
            label7.Text = "Просечна цена на изнајмување:";
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Location = new Point(135, 713);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(262, 27);
            dtpTo.TabIndex = 9;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Location = new Point(135, 671);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(262, 27);
            dtpFrom.TabIndex = 4;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Location = new Point(135, 757);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.ReadOnly = true;
            tbTotalPrice.Size = new Size(262, 27);
            tbTotalPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 760);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Вкупна цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 717);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 4;
            label2.Text = "До:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 677);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 4;
            label1.Text = "Од:";
            // 
            // btnDetails
            // 
            btnDetails.Enabled = false;
            btnDetails.Location = new Point(6, 617);
            btnDetails.Margin = new Padding(3, 5, 3, 5);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(391, 31);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Детали за изнајмување";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Enabled = false;
            btnDeleteRental.Location = new Point(6, 563);
            btnDeleteRental.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(391, 31);
            btnDeleteRental.TabIndex = 2;
            btnDeleteRental.Text = "Избриши изнајмување";
            btnDeleteRental.UseVisualStyleBackColor = true;
            btnDeleteRental.Click += btnDeleteRental_Click;
            // 
            // btnAddRental
            // 
            btnAddRental.Enabled = false;
            btnAddRental.Location = new Point(6, 509);
            btnAddRental.Margin = new Padding(3, 4, 3, 4);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(391, 31);
            btnAddRental.TabIndex = 1;
            btnAddRental.Text = "Додади изнајмување";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += btnAddRental_Click;
            // 
            // lbRentals
            // 
            lbRentals.FormattingEnabled = true;
            lbRentals.ItemHeight = 20;
            lbRentals.Location = new Point(6, 27);
            lbRentals.Margin = new Padding(3, 4, 3, 4);
            lbRentals.Name = "lbRentals";
            lbRentals.Size = new Size(391, 464);
            lbRentals.TabIndex = 0;
            lbRentals.SelectedIndexChanged += lbRentals_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 736);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 4;
            label4.Text = "Вкупна заработувачка:";
            // 
            // tbTotalEarned
            // 
            tbTotalEarned.Location = new Point(216, 733);
            tbTotalEarned.Margin = new Padding(3, 4, 3, 4);
            tbTotalEarned.Name = "tbTotalEarned";
            tbTotalEarned.ReadOnly = true;
            tbTotalEarned.Size = new Size(187, 27);
            tbTotalEarned.TabIndex = 5;
            // 
            // tbCheapest
            // 
            tbCheapest.Location = new Point(216, 768);
            tbCheapest.Margin = new Padding(3, 4, 3, 4);
            tbCheapest.Name = "tbCheapest";
            tbCheapest.ReadOnly = true;
            tbCheapest.Size = new Size(348, 27);
            tbCheapest.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 771);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 6;
            label5.Text = "Најефтин автомобил:";
            // 
            // tbMostExpensive
            // 
            tbMostExpensive.Location = new Point(216, 803);
            tbMostExpensive.Margin = new Padding(3, 4, 3, 4);
            tbMostExpensive.Name = "tbMostExpensive";
            tbMostExpensive.ReadOnly = true;
            tbMostExpensive.Size = new Size(348, 27);
            tbMostExpensive.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 806);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 8;
            label6.Text = "Најскап автомобил:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 999);
            Controls.Add(tbMostExpensive);
            Controls.Add(label6);
            Controls.Add(tbCheapest);
            Controls.Add(label5);
            Controls.Add(tbTotalEarned);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Rent a Car";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCars;
        private GroupBox groupBox1;
        private Button btnDeleteCar;
        private Button btnAddCar;
        private GroupBox groupBox2;
        private Button btnDeleteClient;
        private Button btnAddClient;
        private ListBox lbCustomers;
        private GroupBox groupBox3;
        private Button btnDeleteRental;
        private Button btnAddRental;
        private ListBox lbRentals;
        private Button btnDetails;
        private Button btnHistoryOfRentals;
        private TextBox tbTotalPrice;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label4;
        private TextBox tbTotalEarned;
        private Button btnRentalHistory;
        private TextBox tbCheapest;
        private Label label5;
        private TextBox tbMostExpensive;
        private Label label6;
        private TextBox tbMinRent;
        private Label label9;
        private TextBox tbMaxRent;
        private Label label15;
        private TextBox tbAvgRent;
        private Label label7;
    }
}
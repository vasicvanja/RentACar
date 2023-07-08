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
            btnHistoryOfRentals = new Button();
            btnDeleteClient = new Button();
            btnAddClient = new Button();
            lbCustomers = new ListBox();
            groupBox3 = new GroupBox();
            tbTotal = new TextBox();
            label3 = new Label();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDetails = new Button();
            btnDeleteRental = new Button();
            btnAddRental = new Button();
            lbRentals = new ListBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lbCars
            // 
            lbCars.FormattingEnabled = true;
            lbCars.ItemHeight = 15;
            lbCars.Location = new Point(5, 21);
            lbCars.Name = "lbCars";
            lbCars.Size = new Size(305, 349);
            lbCars.TabIndex = 0;
            lbCars.SelectedIndexChanged += lbCars_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteCar);
            groupBox1.Controls.Add(btnAddCar);
            groupBox1.Controls.Add(lbCars);
            groupBox1.Location = new Point(38, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 502);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автомобили";
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Enabled = false;
            btnDeleteCar.Location = new Point(5, 422);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(304, 23);
            btnDeleteCar.TabIndex = 2;
            btnDeleteCar.Text = "Избриши автомобил";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(5, 382);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(304, 23);
            btnAddCar.TabIndex = 1;
            btnAddCar.Text = "Додади автомобил";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHistoryOfRentals);
            groupBox2.Controls.Add(btnDeleteClient);
            groupBox2.Controls.Add(btnAddClient);
            groupBox2.Controls.Add(lbCustomers);
            groupBox2.Location = new Point(389, 29);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 502);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Клиенти";
            // 
            // btnHistoryOfRentals
            // 
            btnHistoryOfRentals.Location = new Point(6, 617);
            btnHistoryOfRentals.Margin = new Padding(3, 4, 3, 4);
            btnHistoryOfRentals.Name = "btnHistoryOfRentals";
            btnHistoryOfRentals.Size = new Size(348, 31);
            btnHistoryOfRentals.TabIndex = 3;
            btnHistoryOfRentals.Text = "Историја на изнајмувања";
            btnHistoryOfRentals.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Enabled = false;
            btnDeleteClient.Location = new Point(5, 422);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(304, 23);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Избриши клиент";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(5, 382);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(304, 23);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Додади клиент";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(5, 22);
            lbCustomers.Margin = new Padding(3, 4, 3, 4);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(305, 349);
            lbCustomers.TabIndex = 0;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbTotal);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(tbTo);
            groupBox3.Controls.Add(tbFrom);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnDetails);
            groupBox3.Controls.Add(btnDeleteRental);
            groupBox3.Controls.Add(btnAddRental);
            groupBox3.Controls.Add(lbRentals);
            groupBox3.Location = new Point(755, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 602);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Изнајмувања";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(162, 568);
            tbTotal.Margin = new Padding(3, 2, 3, 2);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(110, 23);
            tbTotal.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 570);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 7;
            label3.Text = "Вкупна цена:";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(162, 536);
            tbTo.Margin = new Padding(3, 2, 3, 2);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(110, 23);
            tbTo.TabIndex = 6;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(162, 505);
            tbFrom.Margin = new Padding(3, 2, 3, 2);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(110, 23);
            tbFrom.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 538);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "До:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 507);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "Од:";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(5, 463);
            btnDetails.Margin = new Padding(3, 4, 3, 4);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(304, 23);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Детали за изнајмување";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new Point(5, 422);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(304, 23);
            btnDeleteRental.TabIndex = 2;
            btnDeleteRental.Text = "Избриши изнајмување";
            btnDeleteRental.UseVisualStyleBackColor = true;
            // 
            // btnAddRental
            // 
            btnAddRental.Location = new Point(5, 382);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(304, 23);
            btnAddRental.TabIndex = 1;
            btnAddRental.Text = "Додади изнајмување";
            btnAddRental.UseVisualStyleBackColor = true;
            // 
            // lbRentals
            // 
            lbRentals.FormattingEnabled = true;
            lbRentals.ItemHeight = 15;
            lbRentals.Location = new Point(5, 20);
            lbRentals.Name = "lbRentals";
            lbRentals.Size = new Size(305, 349);
            lbRentals.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 749);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Rent a Car";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
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
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnHistoryOfRentals;
        private TextBox tbTotal;
        private Label label3;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Label label2;
        private Label label1;
    }
}
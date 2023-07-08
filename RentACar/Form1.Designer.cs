namespace RentACar
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
            groupBox3.Controls.Add(btnDetails);
            groupBox3.Controls.Add(btnDeleteRental);
            groupBox3.Controls.Add(btnAddRental);
            groupBox3.Controls.Add(lbRentals);
            groupBox3.Location = new Point(863, 39);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(360, 669);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Изнајмувања";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(6, 617);
            btnDetails.Margin = new Padding(3, 5, 3, 5);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(347, 31);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Детали за изнајмување";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new Point(6, 563);
            btnDeleteRental.Margin = new Padding(3, 4, 3, 4);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(347, 31);
            btnDeleteRental.TabIndex = 2;
            btnDeleteRental.Text = "Избриши изнајмување";
            btnDeleteRental.UseVisualStyleBackColor = true;
            // 
            // btnAddRental
            // 
            btnAddRental.Location = new Point(6, 509);
            btnAddRental.Margin = new Padding(3, 4, 3, 4);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(347, 31);
            btnAddRental.TabIndex = 1;
            btnAddRental.Text = "Додади изнајмување";
            btnAddRental.UseVisualStyleBackColor = true;
            // 
            // lbRentals
            // 
            lbRentals.FormattingEnabled = true;
            lbRentals.ItemHeight = 20;
            lbRentals.Location = new Point(6, 27);
            lbRentals.Margin = new Padding(3, 4, 3, 4);
            lbRentals.Name = "lbRentals";
            lbRentals.Size = new Size(348, 464);
            lbRentals.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 999);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Rent a Car";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
    }
}
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
            btnDeleteClient = new Button();
            btnAddClient = new Button();
            lbClients = new ListBox();
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
            groupBox2.Controls.Add(btnDeleteClient);
            groupBox2.Controls.Add(btnAddClient);
            groupBox2.Controls.Add(lbClients);
            groupBox2.Location = new Point(394, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 502);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Клиенти";
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(5, 422);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(304, 23);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Избриши клиент";
            btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(5, 382);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(304, 23);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Додади клиент";
            btnAddClient.UseVisualStyleBackColor = true;
            // 
            // lbClients
            // 
            lbClients.FormattingEnabled = true;
            lbClients.ItemHeight = 15;
            lbClients.Location = new Point(4, 20);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(305, 349);
            lbClients.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDetails);
            groupBox3.Controls.Add(btnDeleteRental);
            groupBox3.Controls.Add(btnAddRental);
            groupBox3.Controls.Add(lbRentals);
            groupBox3.Location = new Point(755, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 502);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Клиенти";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(5, 463);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(304, 23);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Детали за изнајмување";
            btnDetails.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1418, 595);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
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
        private ListBox lbClients;
        private GroupBox groupBox3;
        private Button btnDeleteRental;
        private Button btnAddRental;
        private ListBox lbRentals;
        private Button btnDetails;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
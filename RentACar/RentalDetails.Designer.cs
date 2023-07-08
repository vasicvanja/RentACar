namespace RentACar
{
    partial class RentalDetails
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
            gbDetails = new GroupBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label9 = new Label();
            lbRentEndDate = new Label();
            lbRentStartDate = new Label();
            groupBox3 = new GroupBox();
            lbPriceForDay = new Label();
            lbTotalPrice = new Label();
            label11 = new Label();
            label1 = new Label();
            label8 = new Label();
            lbRentPrice = new Label();
            groupBox2 = new GroupBox();
            lbCarYear = new Label();
            lbCarMileage = new Label();
            label6 = new Label();
            label7 = new Label();
            lbCarModel = new Label();
            lbCarBrand = new Label();
            label5 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            lbClientNumber = new Label();
            lbClientName = new Label();
            label2 = new Label();
            label3 = new Label();
            gbDetails.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(groupBox4);
            gbDetails.Controls.Add(groupBox3);
            gbDetails.Controls.Add(label8);
            gbDetails.Controls.Add(lbRentPrice);
            gbDetails.Controls.Add(groupBox2);
            gbDetails.Controls.Add(groupBox1);
            gbDetails.Location = new Point(39, 23);
            gbDetails.Margin = new Padding(3, 4, 3, 4);
            gbDetails.Name = "gbDetails";
            gbDetails.Padding = new Padding(3, 4, 3, 4);
            gbDetails.Size = new Size(841, 656);
            gbDetails.TabIndex = 1;
            gbDetails.TabStop = false;
            gbDetails.Text = "Детали";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(lbRentEndDate);
            groupBox4.Controls.Add(lbRentStartDate);
            groupBox4.Location = new Point(474, 348);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(281, 276);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Датуми на изнајмување:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 37);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 8;
            label4.Text = "Почеток на рентање:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 161);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 12;
            label9.Text = "Крај на рентање:";
            // 
            // lbRentEndDate
            // 
            lbRentEndDate.AutoSize = true;
            lbRentEndDate.Location = new Point(8, 201);
            lbRentEndDate.Name = "lbRentEndDate";
            lbRentEndDate.Size = new Size(108, 20);
            lbRentEndDate.TabIndex = 11;
            lbRentEndDate.Text = "Километража:";
            // 
            // lbRentStartDate
            // 
            lbRentStartDate.AutoSize = true;
            lbRentStartDate.Location = new Point(7, 72);
            lbRentStartDate.Name = "lbRentStartDate";
            lbRentStartDate.Size = new Size(108, 20);
            lbRentStartDate.TabIndex = 10;
            lbRentStartDate.Text = "Километража:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbPriceForDay);
            groupBox3.Controls.Add(lbTotalPrice);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(474, 53);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(281, 261);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Информации за цена:";
            // 
            // lbPriceForDay
            // 
            lbPriceForDay.AutoSize = true;
            lbPriceForDay.Location = new Point(23, 84);
            lbPriceForDay.Name = "lbPriceForDay";
            lbPriceForDay.Size = new Size(108, 20);
            lbPriceForDay.TabIndex = 15;
            lbPriceForDay.Text = "Матичен број:";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(23, 200);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(108, 20);
            lbTotalPrice.TabIndex = 14;
            lbTotalPrice.Text = "Матичен број:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 151);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 7;
            label11.Text = "Вкупна цена:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Цена за еден ден:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 385);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 9;
            // 
            // lbRentPrice
            // 
            lbRentPrice.AutoSize = true;
            lbRentPrice.Location = new Point(490, 91);
            lbRentPrice.Name = "lbRentPrice";
            lbRentPrice.Size = new Size(0, 20);
            lbRentPrice.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCarYear);
            groupBox2.Controls.Add(lbCarMileage);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lbCarModel);
            groupBox2.Controls.Add(lbCarBrand);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(42, 348);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(382, 276);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Информации за автомобилот:";
            // 
            // lbCarYear
            // 
            lbCarYear.AutoSize = true;
            lbCarYear.Location = new Point(186, 201);
            lbCarYear.Name = "lbCarYear";
            lbCarYear.Size = new Size(0, 20);
            lbCarYear.TabIndex = 8;
            // 
            // lbCarMileage
            // 
            lbCarMileage.AutoSize = true;
            lbCarMileage.Location = new Point(186, 84);
            lbCarMileage.Name = "lbCarMileage";
            lbCarMileage.Size = new Size(0, 20);
            lbCarMileage.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 137);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 6;
            label6.Text = "Mодел:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 37);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 5;
            label7.Text = "Километража:";
            // 
            // lbCarModel
            // 
            lbCarModel.AutoSize = true;
            lbCarModel.Location = new Point(27, 201);
            lbCarModel.Name = "lbCarModel";
            lbCarModel.Size = new Size(0, 20);
            lbCarModel.TabIndex = 4;
            lbCarModel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbCarBrand
            // 
            lbCarBrand.AutoSize = true;
            lbCarBrand.Location = new Point(24, 84);
            lbCarBrand.Name = "lbCarBrand";
            lbCarBrand.Size = new Size(0, 20);
            lbCarBrand.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 37);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 1;
            label5.Text = "Бренд и модел:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 137);
            label10.Name = "label10";
            label10.Size = new Size(185, 20);
            label10.TabIndex = 2;
            label10.Text = "Година на производство:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbClientNumber);
            groupBox1.Controls.Add(lbClientName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(42, 53);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(382, 261);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информации за клиент:";
            // 
            // lbClientNumber
            // 
            lbClientNumber.AutoSize = true;
            lbClientNumber.Location = new Point(27, 175);
            lbClientNumber.Name = "lbClientNumber";
            lbClientNumber.Size = new Size(0, 20);
            lbClientNumber.TabIndex = 4;
            // 
            // lbClientName
            // 
            lbClientName.AutoSize = true;
            lbClientName.Location = new Point(24, 84);
            lbClientName.Name = "lbClientName";
            lbClientName.Size = new Size(0, 20);
            lbClientName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 37);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Име и презиме:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 132);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Матичен број:";
            // 
            // RentalDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 717);
            Controls.Add(gbDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RentalDetails";
            Text = "Детали за изнајмување";
            Load += RentalDetails_Load;
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDetails;
        private GroupBox groupBox4;
        private Label label4;
        private Label label9;
        private Label lbRentEndDate;
        private Label lbRentStartDate;
        private GroupBox groupBox3;
        private Label lbPriceForDay;
        private Label lbTotalPrice;
        private Label label11;
        private Label label1;
        private Label label8;
        private Label lbRentPrice;
        private GroupBox groupBox2;
        private Label lbCarYear;
        private Label lbCarMileage;
        private Label label6;
        private Label label7;
        private Label lbCarModel;
        private Label lbCarBrand;
        private Label label5;
        private Label label10;
        private GroupBox groupBox1;
        private Label lbClientNumber;
        private Label lbClientName;
        private Label label2;
        private Label label3;
    }
}
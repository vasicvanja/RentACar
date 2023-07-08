namespace RentACar
{
    partial class NewCar
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
            components = new System.ComponentModel.Container();
            tbCarBrand = new TextBox();
            tbCarModel = new TextBox();
            tbYear = new TextBox();
            lbBrand = new Label();
            lbModel = new Label();
            lbYear = new Label();
            tbMileage = new TextBox();
            label1 = new Label();
            tbPrice = new TextBox();
            label2 = new Label();
            btnSaveCar = new Button();
            btnCancel = new Button();
            cbAvailable = new CheckBox();
            tbId = new TextBox();
            lbId = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbCarBrand
            // 
            tbCarBrand.Location = new Point(6, 123);
            tbCarBrand.Margin = new Padding(3, 4, 3, 4);
            tbCarBrand.Name = "tbCarBrand";
            tbCarBrand.Size = new Size(275, 27);
            tbCarBrand.TabIndex = 0;
            tbCarBrand.TextChanged += tbCarBrand_TextChanged;
            tbCarBrand.Validating += carBrand_Validating;
            // 
            // tbCarModel
            // 
            tbCarModel.Location = new Point(6, 196);
            tbCarModel.Margin = new Padding(3, 4, 3, 4);
            tbCarModel.Name = "tbCarModel";
            tbCarModel.Size = new Size(275, 27);
            tbCarModel.TabIndex = 1;
            tbCarModel.TextChanged += tbCarModel_TextChanged;
            tbCarModel.Validating += tbCarModel_Validating;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(6, 272);
            tbYear.Margin = new Padding(3, 4, 3, 4);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(275, 27);
            tbYear.TabIndex = 2;
            tbYear.TextChanged += tbYear_TextChanged;
            tbYear.Validating += tbYear_Validating;
            // 
            // lbBrand
            // 
            lbBrand.AutoSize = true;
            lbBrand.Location = new Point(6, 99);
            lbBrand.Name = "lbBrand";
            lbBrand.Size = new Size(55, 20);
            lbBrand.TabIndex = 3;
            lbBrand.Text = "Бренд:";
            // 
            // lbModel
            // 
            lbModel.AutoSize = true;
            lbModel.Location = new Point(6, 172);
            lbModel.Name = "lbModel";
            lbModel.Size = new Size(58, 20);
            lbModel.TabIndex = 4;
            lbModel.Text = "Модел:";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(6, 248);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(62, 20);
            lbYear.TabIndex = 5;
            lbYear.Text = "Година:";
            // 
            // tbMileage
            // 
            tbMileage.Location = new Point(6, 357);
            tbMileage.Margin = new Padding(3, 4, 3, 4);
            tbMileage.Name = "tbMileage";
            tbMileage.Size = new Size(275, 27);
            tbMileage.TabIndex = 6;
            tbMileage.TextChanged += tbMileage_TextChanged;
            tbMileage.Validating += tbMileage_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 333);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 7;
            label1.Text = "Километража:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(6, 444);
            tbPrice.Margin = new Padding(3, 4, 3, 4);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(275, 27);
            tbPrice.TabIndex = 8;
            tbPrice.TextChanged += tbPrice_TextChanged;
            tbPrice.Validating += tbPrice_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 420);
            label2.Name = "label2";
            label2.Size = new Size(253, 20);
            label2.TabIndex = 9;
            label2.Text = "Цена за изнајмување на ден (EUR):";
            // 
            // btnSaveCar
            // 
            btnSaveCar.Enabled = false;
            btnSaveCar.Location = new Point(6, 551);
            btnSaveCar.Margin = new Padding(3, 4, 3, 4);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(114, 39);
            btnSaveCar.TabIndex = 10;
            btnSaveCar.Text = "Додади";
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += btnSaveCar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(167, 551);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 39);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbAvailable
            // 
            cbAvailable.AutoSize = true;
            cbAvailable.Location = new Point(6, 503);
            cbAvailable.Margin = new Padding(3, 4, 3, 4);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(97, 24);
            cbAvailable.TabIndex = 14;
            cbAvailable.Text = "Достапна";
            cbAvailable.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            tbId.Location = new Point(6, 52);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.Size = new Size(275, 27);
            tbId.TabIndex = 15;
            tbId.TextChanged += tbId_TextChanged;
            tbId.Validating += tbId_Validating;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(6, 28);
            lbId.Name = "lbId";
            lbId.Size = new Size(173, 20);
            lbId.TabIndex = 16;
            lbId.Text = "Идентификациски број:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(lbId);
            groupBox1.Controls.Add(tbCarBrand);
            groupBox1.Controls.Add(tbCarModel);
            groupBox1.Controls.Add(cbAvailable);
            groupBox1.Controls.Add(tbYear);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(lbBrand);
            groupBox1.Controls.Add(btnSaveCar);
            groupBox1.Controls.Add(lbModel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbYear);
            groupBox1.Controls.Add(tbPrice);
            groupBox1.Controls.Add(tbMileage);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 599);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додади нов автомобил";
            // 
            // NewCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 672);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewCar";
            Text = "Нов автомобил";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbCarBrand;
        private TextBox tbCarModel;
        private TextBox tbYear;
        private Label lbBrand;
        private Label lbModel;
        private Label lbYear;
        private TextBox tbMileage;
        private Label label1;
        private TextBox tbPrice;
        private Label label2;
        private Button btnSaveCar;
        private Button btnCancel;
        private CheckBox cbAvailable;
        private TextBox tbId;
        private Label lbId;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
    }
}
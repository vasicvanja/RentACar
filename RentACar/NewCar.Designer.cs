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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbCarBrand
            // 
            tbCarBrand.Location = new Point(43, 119);
            tbCarBrand.Name = "tbCarBrand";
            tbCarBrand.Size = new Size(241, 23);
            tbCarBrand.TabIndex = 0;
            tbCarBrand.TextChanged += tbCarBrand_TextChanged;
            tbCarBrand.Validating += carBrand_Validating;
            // 
            // tbCarModel
            // 
            tbCarModel.Location = new Point(43, 184);
            tbCarModel.Name = "tbCarModel";
            tbCarModel.Size = new Size(241, 23);
            tbCarModel.TabIndex = 1;
            tbCarModel.TextChanged += tbCarModel_TextChanged;
            tbCarModel.Validating += tbCarModel_Validating;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(43, 253);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(241, 23);
            tbYear.TabIndex = 2;
            tbYear.TextChanged += tbYear_TextChanged;
            tbYear.Validating += tbYear_Validating;
            // 
            // lbBrand
            // 
            lbBrand.AutoSize = true;
            lbBrand.Location = new Point(43, 90);
            lbBrand.Name = "lbBrand";
            lbBrand.Size = new Size(40, 15);
            lbBrand.TabIndex = 3;
            lbBrand.Text = "Бренд";
            // 
            // lbModel
            // 
            lbModel.AutoSize = true;
            lbModel.Location = new Point(43, 156);
            lbModel.Name = "lbModel";
            lbModel.Size = new Size(44, 15);
            lbModel.TabIndex = 4;
            lbModel.Text = "Модел";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(43, 224);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(46, 15);
            lbYear.TabIndex = 5;
            lbYear.Text = "Година";
            // 
            // tbMileage
            // 
            tbMileage.Location = new Point(42, 323);
            tbMileage.Name = "tbMileage";
            tbMileage.Size = new Size(237, 23);
            tbMileage.TabIndex = 6;
            tbMileage.TextChanged += tbMileage_TextChanged;
            tbMileage.Validating += tbMileage_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 292);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "Километража";
            label1.Click += label1_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(42, 406);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(237, 23);
            tbPrice.TabIndex = 8;
            tbPrice.TextChanged += tbPrice_TextChanged;
            tbPrice.Validating += tbPrice_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 373);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 9;
            label2.Text = "Цена за изнајмување на ден";
            // 
            // btnSaveCar
            // 
            btnSaveCar.Enabled = false;
            btnSaveCar.Location = new Point(42, 502);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(75, 23);
            btnSaveCar.TabIndex = 10;
            btnSaveCar.Text = "Додади";
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += btnSaveCar_Click;
            btnSaveCar.Validating += btnSaveCar_Validating;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(43, 550);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbAvailable
            // 
            cbAvailable.AutoSize = true;
            cbAvailable.Location = new Point(42, 456);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(78, 19);
            cbAvailable.TabIndex = 14;
            cbAvailable.Text = "Достапна";
            cbAvailable.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            tbId.Location = new Point(43, 55);
            tbId.Name = "tbId";
            tbId.Size = new Size(241, 23);
            tbId.TabIndex = 15;
            tbId.TextChanged += tbId_TextChanged;
            tbId.Validating += tbId_Validating;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(43, 27);
            lbId.Name = "lbId";
            lbId.Size = new Size(135, 15);
            lbId.TabIndex = 16;
            lbId.Text = "Идентификациски број";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NewCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 603);
            Controls.Add(lbId);
            Controls.Add(tbId);
            Controls.Add(cbAvailable);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveCar);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(label1);
            Controls.Add(tbMileage);
            Controls.Add(lbYear);
            Controls.Add(lbModel);
            Controls.Add(lbBrand);
            Controls.Add(tbYear);
            Controls.Add(tbCarModel);
            Controls.Add(tbCarBrand);
            Name = "NewCar";
            Text = "NewCar";
            Load += NewCar_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
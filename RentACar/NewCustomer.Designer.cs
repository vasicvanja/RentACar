using System.ComponentModel;

namespace RentACar
{
    partial class NewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            btnCancel = new Button();
            tbAddress = new TextBox();
            tbSurname = new TextBox();
            tbName = new TextBox();
            tbId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(tbSurname);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(69, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 405);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додади нов клиент";
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(6, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Додади";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(6, 301);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(373, 27);
            tbAddress.TabIndex = 7;
            tbAddress.TextChanged += tbAddress_TextChanged;
            tbAddress.Validating += tbAddress_Validating;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(6, 217);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(373, 27);
            tbSurname.TabIndex = 6;
            tbSurname.TextChanged += tbSurname_TextChanged;
            tbSurname.Validating += tbSurname_Validating;
            // 
            // tbName
            // 
            tbName.Location = new Point(6, 133);
            tbName.Name = "tbName";
            tbName.Size = new Size(373, 27);
            tbName.TabIndex = 5;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Validating += tbName_Validating;
            // 
            // tbId
            // 
            tbId.Location = new Point(6, 57);
            tbId.Name = "tbId";
            tbId.Size = new Size(373, 27);
            tbId.TabIndex = 4;
            tbId.TextChanged += tbId_TextChanged;
            tbId.Validating += tbId_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 278);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Адреса:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 194);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Презиме:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Име:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Матичен број:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 496);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "Нов клиент";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbAddress;
        private TextBox tbSurname;
        private TextBox tbName;
        private TextBox tbId;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}
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
            groupBox1.Location = new Point(60, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(375, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додади нов клиент";
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(5, 269);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Додади";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(214, 269);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(5, 226);
            tbAddress.Margin = new Padding(3, 2, 3, 2);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(327, 23);
            tbAddress.TabIndex = 7;
            tbAddress.TextChanged += tbAddress_TextChanged;
            tbAddress.Validating += tbAddress_Validating;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(5, 163);
            tbSurname.Margin = new Padding(3, 2, 3, 2);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(327, 23);
            tbSurname.TabIndex = 6;
            tbSurname.TextChanged += tbSurname_TextChanged;
            tbSurname.Validating += tbSurname_Validating;
            // 
            // tbName
            // 
            tbName.Location = new Point(5, 100);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(327, 23);
            tbName.TabIndex = 5;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Validating += tbName_Validating;
            // 
            // tbId
            // 
            tbId.Location = new Point(5, 43);
            tbId.Margin = new Padding(3, 2, 3, 2);
            tbId.Name = "tbId";
            tbId.Size = new Size(327, 23);
            tbId.TabIndex = 4;
            tbId.TextChanged += tbId_TextChanged;
            tbId.Validating += tbId_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 208);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Адреса:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 146);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Презиме:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 82);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Име:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Матичен број:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 372);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewCustomer";
            Text = "Нов клиент";
            Load += NewCustomer_Load;
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
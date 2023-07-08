namespace RentACar
{
    partial class RentalHistory
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
            groupBox1 = new GroupBox();
            lbListOfRentals = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbListOfRentals);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Историја";
            // 
            // lbListOfRentals
            // 
            lbListOfRentals.FormattingEnabled = true;
            lbListOfRentals.ItemHeight = 20;
            lbListOfRentals.Location = new Point(6, 63);
            lbListOfRentals.Name = "lbListOfRentals";
            lbListOfRentals.Size = new Size(438, 304);
            lbListOfRentals.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            // 
            // RentalHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 440);
            Controls.Add(groupBox1);
            Name = "RentalHistory";
            Text = "Историја на изнајмувања";
            Load += RentalHistory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lbListOfRentals;
        private Label label1;
    }
}
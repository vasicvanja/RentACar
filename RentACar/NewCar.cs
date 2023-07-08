using RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class NewCar : Form
    {
        public Car Car { get; set; }
        public Form1 Form1 { get; set; }

        public NewCar()
        {
            InitializeComponent();
        }

        private void NewCar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            bool ifChecked = false;
            if (cbAvailable.Checked)
            {
                ifChecked = true;
            }
            Car = new Car(tbId.Text.Trim(), tbCarBrand.Text.Trim(), tbCarModel.Text.Trim(), tbYear.Text.Trim(), Int32.Parse(tbMileage.Text.Trim()), Int32.Parse(tbPrice.Text.Trim()), ifChecked);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void carBrand_Validating(object sender, CancelEventArgs e)
        {

            if (tbCarBrand.Text.Trim().Length > 0)
            {
                errorProvider1.SetError(tbCarBrand, null);
            }
            else
            {
                errorProvider1.SetError(tbCarBrand, "Името на брендот на колата е задолжително");
            }
        }

        private void tbCarBrand_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        public void setButtonVisibility()
        {
            if ((tbId.Text != "") && (tbCarBrand.Text != "") && (tbCarModel.Text != "") && (tbMileage.Text != "") && (tbYear.Text != "") && (tbPrice.Text != ""))
            {
                int i;
                if (int.TryParse(tbMileage.Text, out i) && int.TryParse(tbPrice.Text, out i))
                {
                    btnSaveCar.Enabled = true;
                }
                else
                {
                    btnSaveCar.Enabled = false;
                }
            }
            else
            {
                btnSaveCar.Enabled = false;
            }

        }

        private void tbCarModel_Validating(object sender, CancelEventArgs e)
        {
            if (tbCarModel.Text.Trim().Length > 0)
            {
                errorProvider1.SetError(tbCarModel, null);
            }
            else
            {
                errorProvider1.SetError(tbCarModel, "Името на моделот на колата е задолжително");
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            if (tbYear.Text.Trim().Length > 0)
            {
                errorProvider1.SetError(tbYear, null);
            }
            else
            {
                errorProvider1.SetError(tbYear, "Годината на производство на колата е задолжителна");
            }
        }

        private void tbMileage_Validating(object sender, CancelEventArgs e)
        {
            int i;
            errorProvider1.SetError(tbMileage, null);
            if (tbMileage.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbMileage, "Километражата на колата е задолжителна");
            }
            if (!int.TryParse(tbMileage.Text, out i))
            {
                errorProvider1.SetError(tbMileage, "Километражата мора да биде број");
            }

        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            int i;
            errorProvider1.SetError(tbPrice, null);
            if (tbPrice.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbPrice, "Цената на изнајмување на колата е задолжителна");
            }
            if (!int.TryParse(tbPrice.Text, out i))
            {
                errorProvider1.SetError(tbPrice, "Цената на изнајмување мора да биде број");
            }
        }

        private void btnSaveCar_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbCarModel_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void tbMileage_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                errorProvider1.SetError(tbId, "Полето за идентификациски број е задолжително!");
            }
            else
            {
                errorProvider1.SetError(tbId, null);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }
    }
}

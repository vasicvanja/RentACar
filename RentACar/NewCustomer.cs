using RentACar.Models;
using System.ComponentModel;

namespace RentACar
{
    public partial class NewCustomer : Form
    {
        public Customer Customer { get; set; }
        public Form1 Form1 { get; set; } = new Form1();

        public NewCustomer()
        {
            InitializeComponent();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer = new Customer();
            Customer.Id = tbId.Text;
            Customer.Name = tbName.Text;
            Customer.Surname = tbSurname.Text;
            Customer.Address = tbAddress.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Полето за матичен број е задолжително!");
            }
            else if (Form1.checkIfCustomerExists(tbId.Text.ToString()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Клиент со овој матичен број веќе постои!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbId, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Полето за име е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSurname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSurname, "Полето за презиме е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSurname, null);
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAddress, "Полето за адреса е задолжително!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAddress, null);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void Validate()
        {
            if (tbId.Text != "" && tbName.Text != "" && tbSurname.Text != "" && tbAddress.Text != "")
            {
                btnAdd.Enabled = true;
            }
        }
    }
}

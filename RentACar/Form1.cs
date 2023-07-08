using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            if (newCustomer.ShowDialog() == DialogResult.OK)
            {
                lbCustomers.Items.Add(newCustomer.Customer);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој клиент?", "Избриши клиент", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbCustomers.Items.RemoveAt(lbCustomers.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Селектирајте го клиентот од листата на клиенти којшто сакате да го избришете!", "Избриши клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool checkIfCustomerExists(string Id)
        {
            for (int i = 0; i < lbCustomers.Items.Count; ++i)
            {
                Customer customer = lbCustomers.Items[i] as Customer;
                if (customer.Id == Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
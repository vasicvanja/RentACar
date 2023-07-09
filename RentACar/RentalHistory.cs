using RentACar.Models;

namespace RentACar
{
    public partial class RentalHistory : Form
    {
        public Customer Customer;
        public RentalHistory(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
        }

        private void RentalHistory_Load(object sender, EventArgs e)
        {
            label1.Text = Customer.Name.ToString() + " " + Customer.Surname.ToString();
            foreach (Rent rent in Customer.Rentals)
            {
                string temp = rent.ToString() + " " + String.Format("{0:MM/dd/yyyy}", rent.From) + " - " + String.Format("{0:MM/dd/yyyy}", rent.To);
                lbListOfRentals.Items.Add(temp);
            }
        }
    }
}

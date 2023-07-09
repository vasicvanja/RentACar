using RentACar.Models;

namespace RentACar
{
    public partial class RentalDetails : Form
    {
        public Rent selectedRental;
        public RentalDetails(Rent rental)
        {
            InitializeComponent();
            selectedRental = rental;
        }

        private void RentalDetails_Load(object sender, EventArgs e)
        {
            lbClientName.Text = selectedRental.Customer.Name + " " + selectedRental.Customer.Surname;
            lbClientNumber.Text = selectedRental.Customer.Id;
            lbCarBrand.Text = selectedRental.Car.Brand;
            lbCarModel.Text = selectedRental.Car.Model;
            lbCarMileage.Text = selectedRental.Car.Mileage.ToString();
            lbCarYear.Text = selectedRental.Car.Year;
            lbPriceForDay.Text = selectedRental.Car.PricePerDay.ToString();
            lbRentStartDate.Text = selectedRental.From.ToString();
            lbRentEndDate.Text = selectedRental.To.ToString();
            lbTotalPrice.Text = selectedRental.TotalPrice.ToString();
        }
    }
}

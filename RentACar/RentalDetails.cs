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
            lbPriceForDay.Text = selectedRental.Car.Price.ToString();
            lbRentStartDate.Text = selectedRental.From.ToString();
            lbRentEndDate.Text = selectedRental.To.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

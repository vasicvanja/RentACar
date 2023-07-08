using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbCars.Items.Add(new Car("1", "BMW", "520", "2023", 1000, 200, true));
            lbCustomers.Items.Add(new Customer("1", "Vanja", "Vasic", "bul. V. S. Bato 28/28"));
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar();
            if (newCar.ShowDialog() == DialogResult.OK)
            {
                foreach (Car car in lbCars.Items)
                {
                    if (car.Id == newCar.Car.Id)
                    {
                        MessageBox.Show("Автомобил со овој идентификациски број веќе постои!", "Додади клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                lbCars.Items.Add(newCar.Car);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој автомобил?", "Избриши автомобил", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbCars.Items.RemoveAt(lbCars.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Селектирајте автомобил од листата на автомобили којшто сакате да го избришете!", "Избриши автомобил", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void lbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotalPrice();
            handleEnableStates();
            if (lbCars.Items.Count == 0)
            {
                btnDeleteCar.Enabled = false;
            }
            else
            {
                btnDeleteCar.Enabled = true;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            if (newCustomer.ShowDialog() == DialogResult.OK)
            {
                foreach (Customer customer in lbCustomers.Items)
                {
                    MessageBox.Show("Клиент со овој матичен број веќе постои!", "Додади клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleEnableStates();
            if (lbCustomers.Items.Count == 0)
            {
                btnDeleteClient.Enabled = false;
            }
            else
            {
                btnDeleteClient.Enabled = true;
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            Rent rental = new Rent();
            rental.Car = lbCars.SelectedItem as Car;
            rental.Customer = lbCustomers.SelectedItem as Customer;
            rental.From = Convert.ToDateTime(dtpFrom.Text);
            rental.To = Convert.ToDateTime(dtpTo.Text);
            checkAvailability(rental.From, rental.To);
            if (rental.Car != null && rental.Customer != null)
            {
                if (rental.Car.IsAvailable)
                {
                    rental.TotalPrice = int.Parse(tbTotalPrice.Text);
                    lbRentals.Items.Add(rental);
                    lbCars.SelectedItems.Clear();
                    lbCustomers.SelectedItems.Clear();
                    btnAddRental.Enabled = false;
                    dtpFrom.Enabled = false;
                    dtpTo.Enabled = false;
                }
                else
                {
                    MessageBox.Show(string.Format("Автомобилот {0} {1} не е достапен за избраните датуми.", rental.Car.Brand, rental.Car.Model), "Додади изнајмување", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbCars.SelectedItems.Clear();
                    lbCustomers.SelectedItems.Clear();
                    return;
                }
            }
        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
            if (lbRentals.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете ова изнајмување?", "Избриши изнајмување", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lbRentals.Items.RemoveAt(lbRentals.SelectedIndex);
                    tbTotalPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Селектирајте го изнајмувањето од листата на клиенти кое што сакате да го избришете!", "Избриши изнајмување", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lbRentals_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rent rent = lbRentals.SelectedItem as Rent;
            if (lbRentals.SelectedIndex != -1)
            {
                btnDetails.Enabled = true;
            }
            if (lbRentals.Items.Count == 0)
            {
                btnDeleteRental.Enabled = false;
            }
            else
            {
                btnDeleteRental.Enabled = true;
            }
            calculateTotalPrice();
            if (rent != null)
            {
                tbTotalPrice.Text = rent.TotalPrice.ToString();
            }
        }

        private void handleEnableStates()
        {
            if (lbCars.SelectedIndex != -1 && lbCustomers.SelectedIndex != -1)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
                btnAddRental.Enabled = true;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalPrice();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalPrice();
        }

        private void calculateTotalPrice()
        {
            Car car = lbCars.SelectedItem as Car;
            if (car != null)
            {
                DateTime from = Convert.ToDateTime(dtpFrom.Text);
                DateTime to = Convert.ToDateTime(dtpTo.Text);
                int totalDays = to.Subtract(from).Days;
                if (from == to)
                {
                    totalDays = 1;
                }
                tbTotalPrice.Text = (car.PricePerDay * totalDays).ToString();
            }
            else
            {
                tbTotalPrice.Text = "";
            }
        }

        public void checkAvailability(DateTime from, DateTime to)
        {
            Car car = lbCars.SelectedItem as Car;
            foreach (Rent rent in lbRentals.Items)
            {
                if (car != null)
                {
                    if (rent.Car.Id == car.Id)
                    {
                        if ((rent.From >= from && rent.To <= to) || (rent.From <= to && rent.To >= from))
                        {
                            car.IsAvailable = false;
                        }
                        else
                        {
                            car.IsAvailable = true;
                        }
                    }
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lbRentals.SelectedIndex != -1)
            {
                Rent selectedRental = lbRentals.Items[lbRentals.SelectedIndex] as Rent;
                RentalDetails rentalDetails = new RentalDetails(selectedRental);
                if (rentalDetails.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Селектирајте ставка од листата за активни рентирања", "Избриши клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
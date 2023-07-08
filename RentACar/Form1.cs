using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Селектирајте автомобил од листата на автомобили кој сакате да го избришете!", "Избриши автомобил", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void lbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (lbCustomers.Items.Count == 0)
            {
                btnDeleteClient.Enabled = false;
            }
            else
            {
                btnDeleteClient.Enabled = true;
            }
        }
    }
}
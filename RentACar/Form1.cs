using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
        public List<Car> cars;
        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>();
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
                        MessageBox.Show("Автомобил со овој идентификациски број веќе постои", "Додади клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } else
            {
                btnDeleteCar.Enabled = true;
            }
        }
    }
}
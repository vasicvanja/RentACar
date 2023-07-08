namespace RentACar.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }

        public Car() { }

        public Car(string brand, string model, string year, int mileage, int price, bool isAvailable)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Price = price;
            IsAvailable = isAvailable;
        }
    }
}

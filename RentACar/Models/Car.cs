using System.Xml.Linq;

namespace RentACar.Models
{
    public class Car
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }

        public Car(string id,string brand, string model, string year, int mileage, int price, bool isAvailable)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Price = price;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}km {5}eur - {6}",Id, Brand, Model, Year, Mileage, Price, IsAvailable ? "Достапна" : "Недостапна");
        }
    }
}

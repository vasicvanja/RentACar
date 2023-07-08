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
        public int PricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        public Car() { }

        public Car(string id,string brand, string model, string year, int mileage, int pricePerDay, bool isAvailable)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            PricePerDay = pricePerDay;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} KM {5} EUR", Id, Brand, Model, Year, Mileage, PricePerDay);
        }
    }
}

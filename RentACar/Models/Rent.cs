namespace RentACar.Models
{
    public class Rent
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public int TotalPrice { get; set; } 

        public Rent() { }

        public Rent(DateTime from, DateTime to, Customer customer, Car car, int totalPrice)
        {
            From = from;
            To = to;
            Customer = customer;
            Car = car;
            TotalPrice = totalPrice;
        }

        public override string? ToString()
        {
            return string.Format("{0} {1} - {2} {3}", Car.Brand, Car.Model, Customer.Name, Customer.Surname);
        }
    }
}

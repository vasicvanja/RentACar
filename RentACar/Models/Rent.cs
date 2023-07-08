namespace RentACar.Models
{
    public class Rent
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }

        public Rent(DateTime from, DateTime to, Customer customer, Car car)
        {
            From = from;
            To = to;
            Customer = customer;
            Car = car;
        }
    }
}

using System.Diagnostics;
using System.Reflection;

namespace RentACar.Models
{
    public class Rent
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }

        public Rent() { }

        public Rent(DateTime from, DateTime to, Customer customer, Car car)
        {
            From = from;
            To = to;
            Customer = customer;
            Car = car;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", String.Format("{0:M/d/yyyy}", From), String.Format("{0:M/d/yyyy}", To), Customer.ToString(),Car.ToString());
        }
    }
}

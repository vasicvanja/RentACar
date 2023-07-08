namespace RentACar.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public Customer(string id, string name, string surname, string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
        }
    }
}

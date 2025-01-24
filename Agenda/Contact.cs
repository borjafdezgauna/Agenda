
namespace AgendaLib
{
    public class Contact
    {
        public string Name { get; private set; }

        public string Address { get; private set; }

        public string City { get; private set; }

        public string Email { get; private set; }

        public Contact(string name, string address, string city, string email)
        {
            Name = name;
            Address = address;
            City = city;
            Email = email;
        }
    }
}

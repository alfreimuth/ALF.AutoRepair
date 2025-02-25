
namespace ALF.AutoRepair.BL
{
    public class Customer : IComparable<Customer>
    {
        // properties
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public string FullName{ get { return ToString(); } }

        public List<Vehicle> Vehicles { get; set; }

        // constructors
        public Customer()
        {
            Vehicles = new List<Vehicle>();
        }
        public Customer(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Vehicles = new List<Vehicle>();
        }

        // methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // "virtual" means a amethod CAN be overriden
        public virtual string GetFullName()
        {
            return ToString();
        }

        public int CompareTo(Customer? other)
        {
            if (other == null) return -1;
            return FirstName.CompareTo(other.FirstName);
        }
    }
}


namespace ALF.AutoRepair.BL
{
    public class Customer
    {
        // properties
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
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
    }
}

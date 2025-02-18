
namespace ALF.AutoRepair.BL
{
    public class Customer
    {
        // properties
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        // methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

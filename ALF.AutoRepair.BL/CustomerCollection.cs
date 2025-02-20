
namespace ALF.AutoRepair.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestData()
        {
            Customer c;

            c = new Customer("John", "Doe", "555-1212");
            Add(c);

            c = new Customer();
            c.FirstName = "Jane";
            c.LastName = "Doe";
            c.PhoneNumber = "555-5555";
            Add(c);

            c = new Customer();
            c.FirstName = "Jack";
            c.LastName = "Smith";
            c.PhoneNumber = "121-2555";
            Add(c);

            c = new Customer();
            c.FirstName = "Jill";
            c.LastName = "White";
            c.PhoneNumber = "123-4567";
            Add(c);
        }
    }
}

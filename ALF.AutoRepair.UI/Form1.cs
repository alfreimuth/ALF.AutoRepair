using ALF.AutoRepair.BL;

namespace ALF.AutoRepair.UI
{
    public partial class Form1 : Form
    {

        // fields
        private CustomerCollection customers = new CustomerCollection();

        public Form1()
        {
            InitializeComponent();

            customers.LoadTestData();

            RebindCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customers.Add(customer);

            RebindCustomers();
        }

        private void RebindCustomers()
        {
            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;
            }
        }
    }
}

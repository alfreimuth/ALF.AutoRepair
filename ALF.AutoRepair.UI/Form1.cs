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

        private void RebindVehicles(Customer customer)
        {
            lstVehicles.DataSource = null;
            lstVehicles.DataSource = customer.Vehicles;
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

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                try 
                { 
                    Vehicle vehicle = new Vehicle();
                    vehicle.Make = txtMake.Text;
                    vehicle.Model = txtModel.Text;
                    vehicle.Year = int.Parse(txtYear.Text);
                    selectedCustomer.Vehicles.Add(vehicle);

                    RebindVehicles(selectedCustomer);
                }
                catch (InvalidYearException iyex)
                {
                    //MessageBox.Show("The year is invalid (" + iyex.InvalidYear + ").");
                    MessageBox.Show(iyex.Message);
                    txtYear.Focus();
                    txtYear.SelectAll();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Year must be a number.");
                    txtYear.Focus();
                    txtYear.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }
        }

        private void lstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle? selectedVehicle = lstVehicles.SelectedItem as Vehicle;
            if (selectedVehicle != null)
            {
                txtMake.Text = selectedVehicle.Make;
                txtModel.Text = selectedVehicle.Model;
                txtYear.Text = selectedVehicle.Year.ToString();
            }
        }
    }
}

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

            //customers.LoadTestData();
            customers.LoadFromXml();

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
            customers.Sort();

            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;

            dgvCustomers.Columns["FullName"].Visible = false;
            dgvCustomers.Columns["FirstName"].HeaderText = "First Name";
            dgvCustomers.Columns["LastName"].HeaderText = "Last Name";
            dgvCustomers.Columns["PhoneNumber"].HeaderText = "Phone Number";
            //dgvCustomers.Columns["ID"].DefaultCellStyle.Format = "C";
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

                RebindVehicles(selectedCustomer);
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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                selectedCustomer.FirstName = txtFirstName.Text;
                selectedCustomer.LastName = txtLastName.Text;
                selectedCustomer.PhoneNumber = txtPhoneNumber.Text;

                RebindCustomers();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                customers.Remove(selectedCustomer);

                RebindCustomers();
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            Vehicle? selectedVehicle = lstVehicles.SelectedItem as Vehicle;
            if (selectedVehicle != null)
            {
                Customer selectedCustomer = (Customer)lstCustomers.SelectedItem!;

                selectedVehicle.Make = txtMake.Text;
                selectedVehicle.Model = txtModel.Text;
                selectedVehicle.Year = int.Parse(txtYear.Text);

                RebindVehicles(selectedCustomer);
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            Vehicle? selectedVehicle = lstVehicles.SelectedItem as Vehicle;
            if (selectedVehicle != null)
            {
                Customer selectedCustomer = (Customer)lstCustomers.SelectedItem!;

                selectedCustomer.Vehicles.Remove(selectedVehicle);

                RebindVehicles(selectedCustomer);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            customers.SaveToXml();
        }
    }
}

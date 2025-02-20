namespace ALF.AutoRepair.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstCustomers = new ListBox();
            btnAddCustomer = new Button();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAddVehicle = new Button();
            lstVehicles = new ListBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(165, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(165, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(165, 162);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 107);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 165);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Phone Number";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(304, 43);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(158, 319);
            lstCustomers.TabIndex = 4;
            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(101, 221);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(111, 23);
            btnAddCustomer.TabIndex = 5;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(652, 46);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(652, 104);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(652, 162);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 49);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Make";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(560, 107);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 165);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 3;
            label6.Text = "Year";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(604, 221);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(82, 23);
            btnAddVehicle.TabIndex = 6;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // lstVehicles
            // 
            lstVehicles.FormattingEnabled = true;
            lstVehicles.ItemHeight = 15;
            lstVehicles.Location = new Point(793, 46);
            lstVehicles.Name = "lstVehicles";
            lstVehicles.Size = new Size(170, 319);
            lstVehicles.TabIndex = 7;
            lstVehicles.SelectedIndexChanged += lstVehicles_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 404);
            Controls.Add(lstVehicles);
            Controls.Add(btnAddVehicle);
            Controls.Add(btnAddCustomer);
            Controls.Add(lstCustomers);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtYear);
            Controls.Add(label1);
            Controls.Add(txtModel);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtMake);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstCustomers;
        private Button btnAddCustomer;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAddVehicle;
        private ListBox lstVehicles;
    }
}

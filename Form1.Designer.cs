namespace _291_Group2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Customer = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.Province = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.MembershipG = new System.Windows.Forms.RadioButton();
            this.MembershipS = new System.Windows.Forms.RadioButton();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.DriverLicense = new System.Windows.Forms.TextBox();
            this.DriversLabel = new System.Windows.Forms.Label();
            this.Insurance = new System.Windows.Forms.TextBox();
            this.InsuranceLabel = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostalCode = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetAddress2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetAddress1 = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel1 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.TextBox();
            this.MNameLabel = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.TabPage();
            this.DeleteBranch = new System.Windows.Forms.Button();
            this.UpdateBranch = new System.Windows.Forms.Button();
            this.CreateBranch = new System.Windows.Forms.Button();
            this.BPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BProvince = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BPostalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BStreet_Address2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BStreet_Address1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BDescription = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.TabPage();
            this.displaypbranch = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dropoffTimeAMPM = new System.Windows.Forms.ComboBox();
            this.dropoffMinute = new System.Windows.Forms.NumericUpDown();
            this.dropoffHour = new System.Windows.Forms.NumericUpDown();
            this.dropoffDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pickupTimeAMPM = new System.Windows.Forms.ComboBox();
            this.pickupMinute = new System.Windows.Forms.NumericUpDown();
            this.pickupHour = new System.Windows.Forms.NumericUpDown();
            this.pickupDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dropoffbranchBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pickupbranchBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TransactionID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.displaypdate = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.displayptime = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.displaydtime = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.displayddate = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.displaydbranch = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Customer.SuspendLayout();
            this.Customers.SuspendLayout();
            this.Branch.SuspendLayout();
            this.DisplayButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropoffMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropoffHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupHour)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.AccessibleName = "Rentals";
            this.Customer.Controls.Add(this.Customers);
            this.Customer.Controls.Add(this.Branch);
            this.Customer.Controls.Add(this.DisplayButton);
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(32, 25);
            this.Customer.Margin = new System.Windows.Forms.Padding(2);
            this.Customer.Name = "Customer";
            this.Customer.SelectedIndex = 0;
            this.Customer.Size = new System.Drawing.Size(794, 557);
            this.Customer.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.LightYellow;
            this.Customers.Controls.Add(this.Province);
            this.Customers.Controls.Add(this.ProvinceLabel);
            this.Customers.Controls.Add(this.DeleteCustomer);
            this.Customers.Controls.Add(this.MembershipG);
            this.Customers.Controls.Add(this.MembershipS);
            this.Customers.Controls.Add(this.UpdateCustomer);
            this.Customers.Controls.Add(this.DOB);
            this.Customers.Controls.Add(this.CreateCustomer);
            this.Customers.Controls.Add(this.label2);
            this.Customers.Controls.Add(this.CID);
            this.Customers.Controls.Add(this.CustomerIDLabel);
            this.Customers.Controls.Add(this.DriverLicense);
            this.Customers.Controls.Add(this.DriversLabel);
            this.Customers.Controls.Add(this.Insurance);
            this.Customers.Controls.Add(this.InsuranceLabel);
            this.Customers.Controls.Add(this.PhoneNumber);
            this.Customers.Controls.Add(this.PhoneLabel);
            this.Customers.Controls.Add(this.label1);
            this.Customers.Controls.Add(this.PostalCode);
            this.Customers.Controls.Add(this.PostalCodeLabel);
            this.Customers.Controls.Add(this.City);
            this.Customers.Controls.Add(this.CityLabel);
            this.Customers.Controls.Add(this.StreetAddress2);
            this.Customers.Controls.Add(this.label5);
            this.Customers.Controls.Add(this.StreetAddress1);
            this.Customers.Controls.Add(this.StreetAddressLabel1);
            this.Customers.Controls.Add(this.LName);
            this.Customers.Controls.Add(this.LNameLabel);
            this.Customers.Controls.Add(this.MName);
            this.Customers.Controls.Add(this.MNameLabel);
            this.Customers.Controls.Add(this.FName);
            this.Customers.Controls.Add(this.FNameLabel);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Margin = new System.Windows.Forms.Padding(2);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(2);
            this.Customers.Size = new System.Drawing.Size(786, 531);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            // 
            // Province
            // 
            this.Province.Location = new System.Drawing.Point(561, 33);
            this.Province.Margin = new System.Windows.Forms.Padding(2);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(143, 19);
            this.Province.TabIndex = 33;
            this.Province.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(478, 30);
            this.ProvinceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(77, 20);
            this.ProvinceLabel.TabIndex = 32;
            this.ProvinceLabel.Text = "Province";
            this.ProvinceLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteCustomer.Location = new System.Drawing.Point(530, 445);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(196, 52);
            this.DeleteCustomer.TabIndex = 31;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // MembershipG
            // 
            this.MembershipG.AutoSize = true;
            this.MembershipG.Location = new System.Drawing.Point(668, 365);
            this.MembershipG.Margin = new System.Windows.Forms.Padding(2);
            this.MembershipG.Name = "MembershipG";
            this.MembershipG.Size = new System.Drawing.Size(51, 17);
            this.MembershipG.TabIndex = 30;
            this.MembershipG.TabStop = true;
            this.MembershipG.Text = "Gold";
            this.MembershipG.UseVisualStyleBackColor = true;
            // 
            // MembershipS
            // 
            this.MembershipS.AutoSize = true;
            this.MembershipS.Location = new System.Drawing.Point(574, 365);
            this.MembershipS.Margin = new System.Windows.Forms.Padding(2);
            this.MembershipS.Name = "MembershipS";
            this.MembershipS.Size = new System.Drawing.Size(76, 17);
            this.MembershipS.TabIndex = 29;
            this.MembershipS.TabStop = true;
            this.MembershipS.Text = "Standard";
            this.MembershipS.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateCustomer.Location = new System.Drawing.Point(293, 445);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(196, 52);
            this.UpdateCustomer.TabIndex = 28;
            this.UpdateCustomer.Text = "Update Information";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(562, 132);
            this.DOB.Margin = new System.Windows.Forms.Padding(2);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(142, 19);
            this.DOB.TabIndex = 27;
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.BackColor = System.Drawing.Color.SkyBlue;
            this.CreateCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateCustomer.Location = new System.Drawing.Point(61, 445);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(196, 52);
            this.CreateCustomer.TabIndex = 26;
            this.CreateCustomer.Text = "Register New Customer";
            this.CreateCustomer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Membership Status";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(186, 33);
            this.CID.Margin = new System.Windows.Forms.Padding(2);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(143, 19);
            this.CID.TabIndex = 23;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(75, 33);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(110, 20);
            this.CustomerIDLabel.TabIndex = 22;
            this.CustomerIDLabel.Text = "Customer ID";
            this.CustomerIDLabel.Click += new System.EventHandler(this.CustomerIDLabel_Click);
            // 
            // DriverLicense
            // 
            this.DriverLicense.Location = new System.Drawing.Point(562, 310);
            this.DriverLicense.Margin = new System.Windows.Forms.Padding(2);
            this.DriverLicense.Name = "DriverLicense";
            this.DriverLicense.Size = new System.Drawing.Size(143, 19);
            this.DriverLicense.TabIndex = 21;
            this.DriverLicense.TextChanged += new System.EventHandler(this.DriverLicense_TextChanged);
            // 
            // DriversLabel
            // 
            this.DriversLabel.AutoSize = true;
            this.DriversLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversLabel.Location = new System.Drawing.Point(429, 308);
            this.DriversLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DriversLabel.Name = "DriversLabel";
            this.DriversLabel.Size = new System.Drawing.Size(132, 20);
            this.DriversLabel.TabIndex = 20;
            this.DriversLabel.Text = "Drivers License";
            // 
            // Insurance
            // 
            this.Insurance.Location = new System.Drawing.Point(562, 250);
            this.Insurance.Margin = new System.Windows.Forms.Padding(2);
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(143, 19);
            this.Insurance.TabIndex = 19;
            this.Insurance.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // InsuranceLabel
            // 
            this.InsuranceLabel.AutoSize = true;
            this.InsuranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceLabel.Location = new System.Drawing.Point(470, 250);
            this.InsuranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InsuranceLabel.Name = "InsuranceLabel";
            this.InsuranceLabel.Size = new System.Drawing.Size(89, 20);
            this.InsuranceLabel.TabIndex = 18;
            this.InsuranceLabel.Text = "Insurance";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(562, 191);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(143, 19);
            this.PhoneNumber.TabIndex = 17;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(434, 188);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(127, 20);
            this.PhoneLabel.TabIndex = 16;
            this.PhoneLabel.Text = "Phone Number";
            this.PhoneLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date of Birth";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PostalCode
            // 
            this.PostalCode.Location = new System.Drawing.Point(562, 81);
            this.PostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(143, 19);
            this.PostalCode.TabIndex = 13;
            this.PostalCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.Location = new System.Drawing.Point(452, 78);
            this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(106, 20);
            this.PostalCodeLabel.TabIndex = 12;
            this.PostalCodeLabel.Text = "Postal Code";
            this.PostalCodeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(186, 365);
            this.City.Margin = new System.Windows.Forms.Padding(2);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(143, 19);
            this.City.TabIndex = 11;
            this.City.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(136, 365);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(39, 20);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City";
            this.CityLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // StreetAddress2
            // 
            this.StreetAddress2.Location = new System.Drawing.Point(186, 314);
            this.StreetAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.StreetAddress2.Name = "StreetAddress2";
            this.StreetAddress2.Size = new System.Drawing.Size(143, 19);
            this.StreetAddress2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Street Address 2";
            // 
            // StreetAddress1
            // 
            this.StreetAddress1.Location = new System.Drawing.Point(186, 264);
            this.StreetAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.StreetAddress1.Name = "StreetAddress1";
            this.StreetAddress1.Size = new System.Drawing.Size(143, 19);
            this.StreetAddress1.TabIndex = 7;
            // 
            // StreetAddressLabel1
            // 
            this.StreetAddressLabel1.AutoSize = true;
            this.StreetAddressLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddressLabel1.Location = new System.Drawing.Point(44, 261);
            this.StreetAddressLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StreetAddressLabel1.Name = "StreetAddressLabel1";
            this.StreetAddressLabel1.Size = new System.Drawing.Size(145, 20);
            this.StreetAddressLabel1.TabIndex = 6;
            this.StreetAddressLabel1.Text = "Street Address 1";
            this.StreetAddressLabel1.Click += new System.EventHandler(this.Address1Label_Click);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(186, 205);
            this.LName.Margin = new System.Windows.Forms.Padding(2);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(143, 19);
            this.LName.TabIndex = 5;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(88, 203);
            this.LNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(95, 20);
            this.LNameLabel.TabIndex = 4;
            this.LNameLabel.Text = "Last Name";
            this.LNameLabel.Click += new System.EventHandler(this.LNameLabel_Click);
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(186, 146);
            this.MName.Margin = new System.Windows.Forms.Padding(2);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(143, 19);
            this.MName.TabIndex = 3;
            // 
            // MNameLabel
            // 
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNameLabel.Location = new System.Drawing.Point(70, 144);
            this.MNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(112, 20);
            this.MNameLabel.TabIndex = 2;
            this.MNameLabel.Text = "Middle Name";
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(186, 89);
            this.FName.Margin = new System.Windows.Forms.Padding(2);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(143, 19);
            this.FName.TabIndex = 1;
            this.FName.TextChanged += new System.EventHandler(this.FName_TextChanged);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(87, 89);
            this.FNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(96, 20);
            this.FNameLabel.TabIndex = 0;
            this.FNameLabel.Text = "First Name";
            this.FNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Branch
            // 
            this.Branch.BackColor = System.Drawing.Color.Honeydew;
            this.Branch.Controls.Add(this.DeleteBranch);
            this.Branch.Controls.Add(this.UpdateBranch);
            this.Branch.Controls.Add(this.CreateBranch);
            this.Branch.Controls.Add(this.BPhoneNumber);
            this.Branch.Controls.Add(this.label10);
            this.Branch.Controls.Add(this.BProvince);
            this.Branch.Controls.Add(this.label8);
            this.Branch.Controls.Add(this.BPostalCode);
            this.Branch.Controls.Add(this.label9);
            this.Branch.Controls.Add(this.BCity);
            this.Branch.Controls.Add(this.label7);
            this.Branch.Controls.Add(this.BID);
            this.Branch.Controls.Add(this.label3);
            this.Branch.Controls.Add(this.BStreet_Address2);
            this.Branch.Controls.Add(this.label4);
            this.Branch.Controls.Add(this.BStreet_Address1);
            this.Branch.Controls.Add(this.label6);
            this.Branch.Controls.Add(this.BDescription);
            this.Branch.Controls.Add(this.DescriptionLabel);
            this.Branch.Location = new System.Drawing.Point(4, 22);
            this.Branch.Margin = new System.Windows.Forms.Padding(2);
            this.Branch.Name = "Branch";
            this.Branch.Padding = new System.Windows.Forms.Padding(2);
            this.Branch.Size = new System.Drawing.Size(786, 531);
            this.Branch.TabIndex = 1;
            this.Branch.Text = "Branch";
            // 
            // DeleteBranch
            // 
            this.DeleteBranch.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteBranch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBranch.Location = new System.Drawing.Point(534, 379);
            this.DeleteBranch.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBranch.Name = "DeleteBranch";
            this.DeleteBranch.Size = new System.Drawing.Size(196, 52);
            this.DeleteBranch.TabIndex = 46;
            this.DeleteBranch.Text = "Delete Branch";
            this.DeleteBranch.UseVisualStyleBackColor = false;
            // 
            // UpdateBranch
            // 
            this.UpdateBranch.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateBranch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBranch.Location = new System.Drawing.Point(298, 379);
            this.UpdateBranch.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBranch.Name = "UpdateBranch";
            this.UpdateBranch.Size = new System.Drawing.Size(196, 52);
            this.UpdateBranch.TabIndex = 45;
            this.UpdateBranch.Text = "Update Branch";
            this.UpdateBranch.UseVisualStyleBackColor = false;
            // 
            // CreateBranch
            // 
            this.CreateBranch.BackColor = System.Drawing.Color.SkyBlue;
            this.CreateBranch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateBranch.Location = new System.Drawing.Point(65, 379);
            this.CreateBranch.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBranch.Name = "CreateBranch";
            this.CreateBranch.Size = new System.Drawing.Size(196, 52);
            this.CreateBranch.TabIndex = 44;
            this.CreateBranch.Text = "Create Branch";
            this.CreateBranch.UseVisualStyleBackColor = false;
            // 
            // BPhoneNumber
            // 
            this.BPhoneNumber.Location = new System.Drawing.Point(523, 148);
            this.BPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.BPhoneNumber.Name = "BPhoneNumber";
            this.BPhoneNumber.Size = new System.Drawing.Size(143, 19);
            this.BPhoneNumber.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Phone Number";
            // 
            // BProvince
            // 
            this.BProvince.Location = new System.Drawing.Point(522, 35);
            this.BProvince.Margin = new System.Windows.Forms.Padding(2);
            this.BProvince.Name = "BProvince";
            this.BProvince.Size = new System.Drawing.Size(143, 19);
            this.BProvince.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Province";
            // 
            // BPostalCode
            // 
            this.BPostalCode.Location = new System.Drawing.Point(523, 83);
            this.BPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.BPostalCode.Name = "BPostalCode";
            this.BPostalCode.Size = new System.Drawing.Size(143, 19);
            this.BPostalCode.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Postal Code";
            // 
            // BCity
            // 
            this.BCity.Location = new System.Drawing.Point(185, 248);
            this.BCity.Margin = new System.Windows.Forms.Padding(2);
            this.BCity.Name = "BCity";
            this.BCity.Size = new System.Drawing.Size(143, 19);
            this.BCity.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "City";
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(185, 35);
            this.BID.Margin = new System.Windows.Forms.Padding(2);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(143, 19);
            this.BID.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Branch ID";
            // 
            // BStreet_Address2
            // 
            this.BStreet_Address2.Location = new System.Drawing.Point(185, 198);
            this.BStreet_Address2.Margin = new System.Windows.Forms.Padding(2);
            this.BStreet_Address2.Name = "BStreet_Address2";
            this.BStreet_Address2.Size = new System.Drawing.Size(143, 19);
            this.BStreet_Address2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Street Address 2";
            // 
            // BStreet_Address1
            // 
            this.BStreet_Address1.Location = new System.Drawing.Point(185, 149);
            this.BStreet_Address1.Margin = new System.Windows.Forms.Padding(2);
            this.BStreet_Address1.Name = "BStreet_Address1";
            this.BStreet_Address1.Size = new System.Drawing.Size(143, 19);
            this.BStreet_Address1.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Street Address 1";
            // 
            // BDescription
            // 
            this.BDescription.Location = new System.Drawing.Point(185, 90);
            this.BDescription.Margin = new System.Windows.Forms.Padding(2);
            this.BDescription.Name = "BDescription";
            this.BDescription.Size = new System.Drawing.Size(143, 19);
            this.BDescription.TabIndex = 25;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(86, 90);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.DescriptionLabel.TabIndex = 24;
            this.DescriptionLabel.Text = "Description";
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.PowderBlue;
            this.DisplayButton.Controls.Add(this.displaydtime);
            this.DisplayButton.Controls.Add(this.label24);
            this.DisplayButton.Controls.Add(this.displayddate);
            this.DisplayButton.Controls.Add(this.label27);
            this.DisplayButton.Controls.Add(this.displaydbranch);
            this.DisplayButton.Controls.Add(this.label29);
            this.DisplayButton.Controls.Add(this.displayptime);
            this.DisplayButton.Controls.Add(this.label25);
            this.DisplayButton.Controls.Add(this.displaypdate);
            this.DisplayButton.Controls.Add(this.label23);
            this.DisplayButton.Controls.Add(this.displaypbranch);
            this.DisplayButton.Controls.Add(this.label21);
            this.DisplayButton.Controls.Add(this.button2);
            this.DisplayButton.Controls.Add(this.label17);
            this.DisplayButton.Controls.Add(this.label16);
            this.DisplayButton.Controls.Add(this.button1);
            this.DisplayButton.Controls.Add(this.dropoffTimeAMPM);
            this.DisplayButton.Controls.Add(this.dropoffMinute);
            this.DisplayButton.Controls.Add(this.dropoffHour);
            this.DisplayButton.Controls.Add(this.dropoffDate);
            this.DisplayButton.Controls.Add(this.label19);
            this.DisplayButton.Controls.Add(this.label20);
            this.DisplayButton.Controls.Add(this.pickupTimeAMPM);
            this.DisplayButton.Controls.Add(this.pickupMinute);
            this.DisplayButton.Controls.Add(this.pickupHour);
            this.DisplayButton.Controls.Add(this.pickupDate);
            this.DisplayButton.Controls.Add(this.label18);
            this.DisplayButton.Controls.Add(this.label15);
            this.DisplayButton.Controls.Add(this.label14);
            this.DisplayButton.Controls.Add(this.dropoffbranchBox);
            this.DisplayButton.Controls.Add(this.label13);
            this.DisplayButton.Controls.Add(this.pickupbranchBox);
            this.DisplayButton.Controls.Add(this.label12);
            this.DisplayButton.Controls.Add(this.TransactionID);
            this.DisplayButton.Controls.Add(this.label11);
            this.DisplayButton.Location = new System.Drawing.Point(4, 22);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Padding = new System.Windows.Forms.Padding(2);
            this.DisplayButton.Size = new System.Drawing.Size(786, 531);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Rentals";
            // 
            // displaypbranch
            // 
            this.displaypbranch.AutoSize = true;
            this.displaypbranch.Location = new System.Drawing.Point(122, 326);
            this.displaypbranch.Name = "displaypbranch";
            this.displaypbranch.Size = new System.Drawing.Size(88, 13);
            this.displaypbranch.TabIndex = 26;
            this.displaypbranch.Text = "pickup branch";
            this.displaypbranch.Visible = false;
            this.displaypbranch.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(23, 326);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "Pickup branch:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 24;
            this.button2.Text = "Rent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(370, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(284, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "DROPOFF INFORMATION";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Display selected information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dropoffTimeAMPM
            // 
            this.dropoffTimeAMPM.FormattingEnabled = true;
            this.dropoffTimeAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.dropoffTimeAMPM.Location = new System.Drawing.Point(601, 233);
            this.dropoffTimeAMPM.Name = "dropoffTimeAMPM";
            this.dropoffTimeAMPM.Size = new System.Drawing.Size(69, 21);
            this.dropoffTimeAMPM.TabIndex = 20;
            // 
            // dropoffMinute
            // 
            this.dropoffMinute.Location = new System.Drawing.Point(544, 234);
            this.dropoffMinute.Name = "dropoffMinute";
            this.dropoffMinute.Size = new System.Drawing.Size(51, 19);
            this.dropoffMinute.TabIndex = 19;
            // 
            // dropoffHour
            // 
            this.dropoffHour.Location = new System.Drawing.Point(486, 234);
            this.dropoffHour.Name = "dropoffHour";
            this.dropoffHour.Size = new System.Drawing.Size(52, 19);
            this.dropoffHour.TabIndex = 18;
            // 
            // dropoffDate
            // 
            this.dropoffDate.Location = new System.Drawing.Point(486, 191);
            this.dropoffDate.Name = "dropoffDate";
            this.dropoffDate.Size = new System.Drawing.Size(184, 19);
            this.dropoffDate.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(372, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Dropoff Time";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(372, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "Dropoff Date";
            // 
            // pickupTimeAMPM
            // 
            this.pickupTimeAMPM.FormattingEnabled = true;
            this.pickupTimeAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.pickupTimeAMPM.Location = new System.Drawing.Point(249, 230);
            this.pickupTimeAMPM.Name = "pickupTimeAMPM";
            this.pickupTimeAMPM.Size = new System.Drawing.Size(69, 21);
            this.pickupTimeAMPM.TabIndex = 14;
            this.pickupTimeAMPM.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // pickupMinute
            // 
            this.pickupMinute.Location = new System.Drawing.Point(192, 231);
            this.pickupMinute.Name = "pickupMinute";
            this.pickupMinute.Size = new System.Drawing.Size(51, 19);
            this.pickupMinute.TabIndex = 13;
            // 
            // pickupHour
            // 
            this.pickupHour.Location = new System.Drawing.Point(134, 231);
            this.pickupHour.Name = "pickupHour";
            this.pickupHour.Size = new System.Drawing.Size(52, 19);
            this.pickupHour.TabIndex = 12;
            this.pickupHour.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pickupDate
            // 
            this.pickupDate.Location = new System.Drawing.Point(134, 188);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(184, 19);
            this.pickupDate.TabIndex = 11;
            this.pickupDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(258, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "PICKUP INFORMATION";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Pickup Time";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Pickup Date";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dropoffbranchBox
            // 
            this.dropoffbranchBox.FormattingEnabled = true;
            this.dropoffbranchBox.Items.AddRange(new object[] {
            "North Side",
            "West Side",
            "East Side",
            "South Side"});
            this.dropoffbranchBox.Location = new System.Drawing.Point(486, 138);
            this.dropoffbranchBox.Name = "dropoffbranchBox";
            this.dropoffbranchBox.Size = new System.Drawing.Size(184, 21);
            this.dropoffbranchBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(372, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Dropoff branch";
            // 
            // pickupbranchBox
            // 
            this.pickupbranchBox.FormattingEnabled = true;
            this.pickupbranchBox.Items.AddRange(new object[] {
            "North Side",
            "West Side",
            "East Side",
            "South Side"});
            this.pickupbranchBox.Location = new System.Drawing.Point(134, 138);
            this.pickupbranchBox.Name = "pickupbranchBox";
            this.pickupbranchBox.Size = new System.Drawing.Size(184, 21);
            this.pickupbranchBox.TabIndex = 3;
            this.pickupbranchBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Pickup branch";
            // 
            // TransactionID
            // 
            this.TransactionID.Location = new System.Drawing.Point(134, 18);
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Size = new System.Drawing.Size(155, 19);
            this.TransactionID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Transaction ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // displaypdate
            // 
            this.displaypdate.AutoSize = true;
            this.displaypdate.Location = new System.Drawing.Point(122, 352);
            this.displaypdate.Name = "displaypdate";
            this.displaypdate.Size = new System.Drawing.Size(74, 13);
            this.displaypdate.TabIndex = 28;
            this.displaypdate.Text = "pickup date";
            this.displaypdate.Visible = false;
            this.displaypdate.Click += new System.EventHandler(this.label22_Click_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(23, 352);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "Pickup date:";
            // 
            // displayptime
            // 
            this.displayptime.AutoSize = true;
            this.displayptime.Location = new System.Drawing.Point(122, 378);
            this.displayptime.Name = "displayptime";
            this.displayptime.Size = new System.Drawing.Size(72, 13);
            this.displayptime.TabIndex = 30;
            this.displayptime.Text = "pickup time";
            this.displayptime.Visible = false;
            this.displayptime.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(23, 378);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Pickup time:";
            // 
            // displaydtime
            // 
            this.displaydtime.AutoSize = true;
            this.displaydtime.Location = new System.Drawing.Point(471, 378);
            this.displaydtime.Name = "displaydtime";
            this.displaydtime.Size = new System.Drawing.Size(74, 13);
            this.displaydtime.TabIndex = 36;
            this.displaydtime.Text = "dropoff time";
            this.displaydtime.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(372, 378);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Dropoff time:";
            // 
            // displayddate
            // 
            this.displayddate.AutoSize = true;
            this.displayddate.Location = new System.Drawing.Point(471, 352);
            this.displayddate.Name = "displayddate";
            this.displayddate.Size = new System.Drawing.Size(76, 13);
            this.displayddate.TabIndex = 34;
            this.displayddate.Text = "dropoff date";
            this.displayddate.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(372, 352);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 13);
            this.label27.TabIndex = 33;
            this.label27.Text = "Dropoff date:";
            // 
            // displaydbranch
            // 
            this.displaydbranch.AutoSize = true;
            this.displaydbranch.Location = new System.Drawing.Point(471, 326);
            this.displaydbranch.Name = "displaydbranch";
            this.displaydbranch.Size = new System.Drawing.Size(90, 13);
            this.displaydbranch.TabIndex = 32;
            this.displaydbranch.Text = "dropoff branch";
            this.displaydbranch.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(372, 326);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "Dropoff branch:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 629);
            this.Controls.Add(this.Customer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Customer.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            this.Branch.ResumeLayout(false);
            this.Branch.PerformLayout();
            this.DisplayButton.ResumeLayout(false);
            this.DisplayButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropoffMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropoffHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Customer;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.TabPage Branch;
        private System.Windows.Forms.TabPage DisplayButton;
        private System.Windows.Forms.TextBox StreetAddress2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StreetAddress1;
        private System.Windows.Forms.Label StreetAddressLabel1;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.Label MNameLabel;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostalCode;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox DriverLicense;
        private System.Windows.Forms.Label DriversLabel;
        private System.Windows.Forms.TextBox Insurance;
        private System.Windows.Forms.Label InsuranceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.RadioButton MembershipG;
        private System.Windows.Forms.RadioButton MembershipS;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BStreet_Address2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BStreet_Address1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BDescription;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox Province;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox BCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BProvince;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BPostalCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBranch;
        private System.Windows.Forms.Button UpdateBranch;
        private System.Windows.Forms.Button CreateBranch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox pickupbranchBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TransactionID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox dropoffbranchBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker pickupDate;
        private System.Windows.Forms.NumericUpDown pickupMinute;
        private System.Windows.Forms.NumericUpDown pickupHour;
        private System.Windows.Forms.ComboBox pickupTimeAMPM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown dropoffMinute;
        private System.Windows.Forms.NumericUpDown dropoffHour;
        private System.Windows.Forms.DateTimePicker dropoffDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label displaypbranch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label displayptime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label displaypdate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label displaydtime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label displayddate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label displaydbranch;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox dropoffTimeAMPM;
    }
}


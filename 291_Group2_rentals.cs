using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _291_Group2
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=291_group2;Integrated Security=True; MultipleActiveResultSets=True");


        public Form1()
        {
            InitializeComponent();


            ///////////////////////////////
            /*operation.Items.Clear();
            operation.Items.Add("Show all");
            operation.Items.Add("Show with starting grade: ");*/
            //////////////////////////////////
            ///
            String connectionString = "Server = BALKIRATS-SURFA; Database = 291_group2; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            RSdReturnDatePicker.MinDate = DateTime.Today;

            CID.Text = "1";
            string q = "Select MAX(CID) AS max_id From Customer";
            myCommand.CommandText = q;

            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                CID.Text = (int.Parse(myReader["max_id"].ToString()) + 1).ToString();
            }
            myReader.Close();

        }


        private void CALCULATE_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Address1Label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void LNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DriverLicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pickupbranchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected_BID;
            selected_BID = pickupbranchBox.SelectedValue.ToString();
            int testing;

            if (int.TryParse(selected_BID, out testing) && !(selected_BID.Equals("0")))
            {
                SqlDataAdapter carType_adapter = new SqlDataAdapter("SELECT T.CarTypeID, T.Description from CarType T, Car C WHERE C.CarTypeID = T.CarTypeID and C.BID = " + selected_BID, con);


                DataTable car_type_table = new DataTable();
                carType_adapter.Fill(car_type_table);

                DataRow car_type_defalut = car_type_table.NewRow();

                car_type_defalut[0] = 0;
                car_type_defalut[1] = "Please select";
                car_type_table.Rows.InsertAt(car_type_defalut, 0);

                CarTypeBox.DataSource = car_type_table;
                CarTypeBox.DisplayMember = "Description";
                CarTypeBox.ValueMember = "CarTypeID";

                string query = "select Street_address1, Street_address2, (City + ', ' + Province + ', ' + PostalCode) as address_line3 from Branch where BID = " + selected_BID;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                p_address_line1.Visible = true;
                p_address_line2.Visible = true;
                p_address_line3.Visible = true;

                while (dr.Read())
                {
                    p_address_line1.Text = dr.GetString(0);

                    if (dr.GetString(1).Length > 0)
                    {
                        p_address_line2.Text = dr.GetString(1);
                        p_address_line3.Text = dr.GetString(2);
                    }
                    else
                    {
                        p_address_line3.Visible = false;
                        p_address_line2.Text = dr.GetString(2);
                    }

                }
                dr.Close();
            }
            else
            {
                p_address_line1.Visible = false;
                p_address_line2.Visible = false;
                p_address_line3.Visible = false;
            }



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarTypeBox.SelectedValue = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void show_rate()
        {

            //----------------rates---------------------------------------------
            TimeSpan rental_days = dropoffDate.Value - pickupDate.Value;
            int total_days = Int32.Parse(rental_days.Days.ToString()) + 1;

            int months = 0, weeks = 0, days = 0;

            while (total_days >= 7)
            {
                if (total_days >= 30)
                {
                    months += total_days / 30;
                    total_days %= 30;
                }
                else if (total_days >= 7)
                {
                    weeks += total_days / 7;
                    total_days %= 7;
                }
            }
            days = total_days;

            float selected_daiy_rate = float.Parse(Daily_rate.Text.Replace("$", ""));
            float selected_weekly_rate = float.Parse(weekly_rate.Text.Replace("$", ""));
            float selected_monthly_rate = float.Parse(monthly_rate.Text.Replace("$", ""));

            float f_price = ((float)months * selected_monthly_rate + (float)weeks * selected_weekly_rate + (float)days * selected_daiy_rate);
            float f_gst = (float)(f_price * 0.05);
            float f_branch_fee;
            string membership = "Standard";



            if ((Rental_customerID.SelectedValue != null) && !(Rental_customerID.SelectedValue.ToString().Equals("0")))
            {
                string query = "SELECT Membership FROM Customer WHERE CID = " + Rental_customerID.SelectedValue.ToString();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    membership = dr.GetString(0);
                }
                dr.Close();

            }


            if (!(int.TryParse(pickupbranchBox.SelectedValue.ToString(), out int result)) || !(int.TryParse(dropoffbranchBox.SelectedValue.ToString(), out int result2)) || pickupbranchBox.SelectedValue.ToString().Equals(dropoffbranchBox.SelectedValue.ToString()) || membership.Equals("Gold"))
            {
                f_branch_fee = 0;
            }
            else
            {
                f_branch_fee = 30;
            }



            float f_total = (float)(f_price + f_gst + f_branch_fee);


            price.Text = "$" + (f_price).ToString(".00#");
            gst.Text = "$" + (f_gst).ToString(".00#");
            branch_fee.Text = "$" + f_branch_fee.ToString(".00#");

            total_charge.Text = "$" + (f_total).ToString(".00#");

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void CreateBranch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BID From Branch where BID = '" + BID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (BID.Text == "")
            {
                MessageBox.Show("Invalid Branch ID");
                return;
            }
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Branch ID already exists. Choose another.");
                return;
            }

            try
            {
                myCommand.CommandText = "insert into Branch (BID, Description, Street_address1, Street_address2, City, Province, PostalCode, PhoneNumber) values " +
                    "('" + BID.Text + "'" +
                    ",'" + BDescription.Text + "'" +
                    ",'" + BStreet_Address1.Text + "'" +
                    ",'" + BStreet_Address2.Text + "'" +
                    ",'" + BCity.Text + "'" +
                    ",'" + BProvince.Text + "'" +
                    ",'" + BPostalCode.Text + "'" +
                    ",'" + BPhoneNumber.Text + "'" +
                    ")";

                //MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
                MessageBox.Show($"Branch {BDescription.Text} created in Branch Table!");
                clear_branch();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Customers_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291_group2DataSet.Branch' table. You can move, or remove it, as needed.
            //this.branchTableAdapter.Fill(this._291_group2DataSet.Branch);

        }

        private void CID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CID From Customer where CID = '" + CID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (CID.Text == "")
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Customer ID already exists. Choose another.");
                return;
            }


            try
            {


                //check which membership is checked, add to database
                string membershipText = string.Empty;

                if (MembershipS.Checked)
                {
                    membershipText = MembershipS.Text;
                }
                else if (MembershipG.Checked)
                {
                    membershipText = MembershipG.Text;
                }

                myCommand.CommandText = "insert into Customer (CID, Firstname, MiddleName, LastName, Phonenumber, DateofBirth, Street_address1, Street_address2, City, Province, PostalCode, Insurance,Membership, DriverLicense) values " +
                    "('" + CID.Text + "'" +
                    ",'" + FName.Text + "'" +
                    ",'" + MName.Text + "'" +
                    ",'" + LName.Text + "'" +
                    ",'" + PhoneNumber.Text + "'" +
                    ",'" + DOB.Text + "'" +
                    ",'" + StreetAddress1.Text + "'" +
                    ",'" + StreetAddress2.Text + "'" +
                    ",'" + City.Text + "'" +
                    ",'" + Province.Text + "'" +
                    ",'" + PostalCode.Text + "'" +
                    ",'" + Insurance.Text + "'" +
                    ",'" + membershipText + "'" +
                    ",'" + DriverLicense.Text + "'" +
                    ")";

                //MessageBox.Show(myCommand.CommandText);
                MessageBox.Show($"Customer {FName.Text} {LName.Text} created in Customer Table!");
                myCommand.ExecuteNonQuery();
                clear_customer();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void BID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand sc = new SqlCommand("select (BID) from Branch", con);
            //SqlDataReader reader;
            //reader = sc.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("BID", typeof(int));
            //dt.Load(reader);
            //CBID.ValueMember = "BID";
            //CBID.DataSource = dt;
            //con.Close();
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {

            string membershipText = string.Empty;

            if (MembershipS.Checked)
            {
                membershipText = MembershipS.Text;
            }
            else if (MembershipG.Checked)
            {
                membershipText = MembershipG.Text;
            }

            //find out if customer exists in database in order to update.


            SqlDataAdapter da = new SqlDataAdapter("Select CID From Customer where CID = '" + CID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (CID.Text == "")
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            else if (dt.Rows.Count > 0)
            {
                myCommand.CommandText = "update Customer set " +
                  "FirstName = " + "'" + FName.Text + "'," +
                  "MiddleName = " + "'" + MName.Text + "'," +
                  "LastName = " + "'" + LName.Text + "'," +
                  "Phonenumber = " + "'" + PhoneNumber.Text + "'," +
                  "DateofBirth = " + "'" + DOB.Text + "'," +
                  "Street_address1 = " + "'" + StreetAddress1.Text + "'," +
                  "Street_address2 = " + "'" + StreetAddress2.Text + "'," +
                  "City = " + "'" + City.Text + "'," +
                  "Province = " + "'" + Province.Text + "'," +
                  "PostalCode = " + "'" + PostalCode.Text + "'," +
                  "Insurance = " + "'" + Insurance.Text + "'," +
                  "Membership = " + "'" + membershipText + "'," +
                  "DriverLicense = " + "'" + DriverLicense.Text + "'" +
                  "where CID = " + "'" + CID.Text + "'";

                myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer updated");
                clear_customer();
            }
            else
            {
                MessageBox.Show("Customer with given CID does not exist.");
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //if all textboxes are empty, display message
            if (CID.Text == "" & FName.Text == "" && LName.Text == "")
            {
                MessageBox.Show("Please enter CustomerID or First and Last Name.");
                return;
            }


            if (CID.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select CID From Customer where CID = '" + CID.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Customer with entered ID not found");
                    return;
                }

                myCommand.CommandText = "select * from Customer where CID = " + CID.Text;

                try
                {

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        CID.Text = myReader["CID"].ToString();
                        FName.Text = myReader["FirstName"].ToString();
                        MName.Text = myReader["MiddleName"].ToString();
                        LName.Text = myReader["LastName"].ToString();
                        PhoneNumber.Text = myReader["Phonenumber"].ToString();
                        Insurance.Text = myReader["Insurance"].ToString();
                        PostalCode.Text = myReader["PostalCode"].ToString();
                        StreetAddress1.Text = myReader["Street_address1"].ToString();
                        StreetAddress2.Text = myReader["Street_address2"].ToString();
                        City.Text = myReader["City"].ToString();
                        Province.Text = myReader["Province"].ToString();
                        DriverLicense.Text = myReader["DriverLicense"].ToString();
                        DOB.Text = myReader["DateofBirth"].ToString();

                        //check which membership is checked, add to database
                        string membershipText = myReader["Membership"].ToString();

                        if (membershipText == "Standard")
                        {
                            MembershipS.Checked = true;
                            MembershipG.Checked = false;
                        }
                        else if (membershipText == "Gold")
                        {
                            MembershipS.Checked = false;
                            MembershipG.Checked = true;
                        }
                        MessageBox.Show("Customer " + FName.Text + " " + LName.Text + " found.");
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (CID.Text == "" & FName.Text != "" && LName.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter($"Select CID From Customer where FirstName = '{FName.Text}' and LastName = '{LName.Text}' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Customer with entered First and Last Name not found");
                    return;
                }
                myCommand.CommandText = $"Select * From Customer where FirstName = '{FName.Text}' and LastName = '{LName.Text}' ";

                try
                {

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        CID.Text = myReader["CID"].ToString();
                        FName.Text = myReader["FirstName"].ToString();
                        MName.Text = myReader["MiddleName"].ToString();
                        LName.Text = myReader["LastName"].ToString();
                        PhoneNumber.Text = myReader["Phonenumber"].ToString();
                        Insurance.Text = myReader["Insurance"].ToString();
                        PostalCode.Text = myReader["PostalCode"].ToString();
                        StreetAddress1.Text = myReader["Street_address1"].ToString();
                        StreetAddress2.Text = myReader["Street_address2"].ToString();
                        City.Text = myReader["City"].ToString();
                        Province.Text = myReader["Province"].ToString();
                        DriverLicense.Text = myReader["DriverLicense"].ToString();
                        DOB.Text = myReader["DateofBirth"].ToString();

                        //check which membership is checked, add to database
                        string membershipText = myReader["Membership"].ToString();

                        if (membershipText == "Standard")
                        {
                            MembershipS.Checked = true;
                            MembershipG.Checked = false;
                        }
                        else if (membershipText == "Gold")
                        {
                            MembershipS.Checked = false;
                            MembershipG.Checked = true;
                        }
                        MessageBox.Show("Customer " + FName.Text + " " + LName.Text + " found.");
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

            }
            else
            {
                MessageBox.Show("Please enter CustomerID or First and Last Name.");
                return;
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CID From Customer where CID = '" + CID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (CID.Text == "")
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Customer not found");
            }
            else
            {
                myCommand.CommandText = "delete from Customer where CID = '" + CID.Text + "'";
                //add a pop up box with "are you sure you want to delete customer?"

                //confirmation message
                string mess = "Are you sure you want to delete customer?";
                string title = "Confirmation";

                //condition
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mess, title, buttons);

                //answer condition
                if (result == DialogResult.Yes)
                {
                    string warning_message = "Deleting the Customer will delete all the rental records for this customer. Do you still want to proceed?";
                    string warning_title = "Warning!!";

                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult warning_result = MessageBox.Show(warning_message, warning_title, buttons1);

                    if (warning_result == DialogResult.Yes)
                    {
                        if (can_delete_transaction("Customer"))
                        {
                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("Customer deleted.");

                        }
                        else
                        {
                            MessageBox.Show("Can not delete Customer. Pending Rental Transaction is found.");
                        }


                    }

                }

                else { return; }


            }
        }

        private Boolean can_delete_transaction(String mode)
        {
            string query = "SELECT ReturnDate from Rentals ";
            switch (mode)
            {
                case "Customer":
                    query += $"WHERE CID = {CID.Text}";
                    break;

                case "Car":
                    query += $"WHERE VIN = '{VIN.Text}'";
                    break;

                case "Branch":
                    query += $"WHERE PickupBID = {BID.Text} OR ReturnBID = {BID.Text}";
                    break;

                case "CarType":
                    query += $"R, Car C, CarType CT WHERE R.VIN = C.VIN and C.CarTypeID = CT.CarTypeID and C.CarTypeID = {CTCarTypeID.Text}";
                    break;
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1.GetDateTime(0) > DateTime.Now)
                {
                    return false;
                }
            }

            dr1.Close();
            return true;
        }

        private void NextCustomer_Click(object sender, EventArgs e)
        {
            if (CID.Text == "")
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            string sqlQuery = $"Select TOP 1 * From Customer c where c.CID > {CID.Text} Order by c.CID";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on last customer.");
                return;
            }

            myCommand.CommandText = sqlQuery;

            //if (FName.Text != "")
            //myCommand.CommandText += " where Fname = '" + FName.Text + "'";
            //else if (CID.Text != null)
            //myCommand.CommandText += " where CID = " + CID.Text;

            try
            {

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //student.Rows.Add(myReader["id"].ToString(), myReader["name"].ToString(), myReader["grade"].ToString());
                    CID.Text = myReader["CID"].ToString();
                    FName.Text = myReader["FirstName"].ToString();
                    MName.Text = myReader["MiddleName"].ToString();
                    LName.Text = myReader["LastName"].ToString();
                    PhoneNumber.Text = myReader["Phonenumber"].ToString();
                    Insurance.Text = myReader["Insurance"].ToString();
                    PostalCode.Text = myReader["PostalCode"].ToString();
                    StreetAddress1.Text = myReader["Street_address1"].ToString();
                    StreetAddress2.Text = myReader["Street_address2"].ToString();
                    City.Text = myReader["City"].ToString();
                    Province.Text = myReader["Province"].ToString();
                    DriverLicense.Text = myReader["DriverLicense"].ToString();
                    DOB.Text = myReader["DateofBirth"].ToString();

                    //check which membership is checked, add to database
                    string membershipText = myReader["Membership"].ToString();

                    if (membershipText == "Standard")
                    {
                        MembershipS.Checked = true;
                        MembershipG.Checked = false;
                    }
                    else if (membershipText == "Gold")
                    {
                        MembershipS.Checked = false;
                        MembershipG.Checked = true;
                    }
                    MessageBox.Show("Customer " + FName.Text + " " + LName.Text + " found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void branchBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBranch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BID From Branch where BID = '" + BID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (BID.Text == "")
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            else if (dt.Rows.Count > 0)
            {

                myCommand.CommandText = $"update Branch set " +
                  $"Description = '{ BDescription.Text}'," +
                  $"Phonenumber = '{BCity.Text}'," +
                  $"Street_address1 = '{BStreet_Address1.Text}'," +
                  $"Street_address2 = '{BStreet_Address2.Text}'," +
                  $"City = '{BPhoneNumber.Text}'," +
                  $"Province = '{BProvince.Text}'," +
                  $"PostalCode = '{BPostalCode.Text}' " +
                  $"where BID = '{BID.Text}'";


                myCommand.ExecuteNonQuery();
                MessageBox.Show("Branch updated");
                clear_branch();
            }
            else
            {
                MessageBox.Show("Branch with given BID does not exist.");
            }
        }

        private void PrevCustomer_Click(object sender, EventArgs e)
        {
            if (CID.Text == "")
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            string sqlQuery = $"Select TOP 1 * From Customer c where c.CID < {CID.Text} Order by c.CID desc";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on first customer.");
                return;
            }

            myCommand.CommandText = sqlQuery;

            //if (FName.Text != "")
            //myCommand.CommandText += " where Fname = '" + FName.Text + "'";
            //else if (CID.Text != null)
            //myCommand.CommandText += " where CID = " + CID.Text;

            try
            {

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //student.Rows.Add(myReader["id"].ToString(), myReader["name"].ToString(), myReader["grade"].ToString());
                    CID.Text = myReader["CID"].ToString();
                    FName.Text = myReader["FirstName"].ToString();
                    MName.Text = myReader["MiddleName"].ToString();
                    LName.Text = myReader["LastName"].ToString();
                    PhoneNumber.Text = myReader["Phonenumber"].ToString();
                    Insurance.Text = myReader["Insurance"].ToString();
                    PostalCode.Text = myReader["PostalCode"].ToString();
                    StreetAddress1.Text = myReader["Street_address1"].ToString();
                    StreetAddress2.Text = myReader["Street_address2"].ToString();
                    City.Text = myReader["City"].ToString();
                    Province.Text = myReader["Province"].ToString();
                    DriverLicense.Text = myReader["DriverLicense"].ToString();
                    DOB.Text = myReader["DateofBirth"].ToString();

                    //check which membership is checked, add to database
                    string membershipText = myReader["Membership"].ToString();

                    if (membershipText == "Standard")
                    {
                        MembershipS.Checked = true;
                        MembershipG.Checked = false;
                    }
                    else if (membershipText == "Gold")
                    {
                        MembershipS.Checked = false;
                        MembershipG.Checked = true;
                    }
                    MessageBox.Show("Customer " + FName.Text + " " + LName.Text + " found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void DeleteBranch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BID From Branch where BID = '" + BID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (BID.Text == "")
            {
                MessageBox.Show("Invalid Branch ID");
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Branch not found");
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataAdapter da2 = new SqlDataAdapter($"Select VIN from car WHERE BID = {BID.Text}", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count != 0)
                {
                    MessageBox.Show("Cannot Delete Branch. Clear the Cars from this Branch First.");
                }
                else if (dt2.Rows.Count == 0)
                {
                    //add a pop up box with "are you sure you want to delete branch?"

                    //confirmation message
                    string mess = "Are you sure you want to delete Branch?";
                    string title = "Confirmation";

                    //condition
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(mess, title, buttons);

                    //answer condition
                    if (result == DialogResult.Yes)
                    {
                        string warning_message = "Deleting the Branch will delete all the rental records for this Branch. Do you still want to proceed?";
                        string warning_title = "Warning!!";

                        MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                        DialogResult warning_result = MessageBox.Show(warning_message, warning_title, buttons1);

                        if (warning_result == DialogResult.Yes)
                        {
                            if (can_delete_transaction("Branch"))
                            {

                                myCommand.CommandText = $"Delete from Rentals where PickupBID = {BID.Text} OR ReturnBID = {BID.Text}";
                                myCommand.ExecuteNonQuery();

                                myCommand.CommandText = "delete from Branch where BID = '" + BID.Text + "'";
                                myCommand.ExecuteNonQuery();

                                MessageBox.Show("Branch deleted.");
                                clear_branch();

                            }
                            else
                            {
                                MessageBox.Show("Can not delete Branch. Pending Rental Transaction is found.");
                            }

                        }
                    }

                    else { return; }

                }

            }
        }

        private void GetBranch_Click(object sender, EventArgs e)
        {
            //if all textboxes are empty, display message
            if (BID.Text == "" & BDescription.Text == "")
            {
                MessageBox.Show("Please enter Branch ID or Description.");
                return;
            }


            if (BID.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select BID From Branch where BID = '" + BID.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Branch with entered ID not found");
                    return;
                }

                myCommand.CommandText = "select * from Branch where BID = " + BID.Text;

                try
                {

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        BID.Text = myReader["BID"].ToString();
                        BDescription.Text = myReader["Description"].ToString();
                        BCity.Text = myReader["PhoneNumber"].ToString();
                        BPostalCode.Text = myReader["PostalCode"].ToString();
                        BStreet_Address1.Text = myReader["Street_address1"].ToString();
                        BStreet_Address2.Text = myReader["Street_address2"].ToString();
                        BPhoneNumber.Text = myReader["City"].ToString();
                        BProvince.Text = myReader["Province"].ToString();


                        MessageBox.Show("Branch " + BDescription.Text + " found.");
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (BID.Text == "" & BDescription.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter($"Select BID From Branch where Description = '{BDescription.Text}'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Branch with entered Description not found");
                    return;
                }
                myCommand.CommandText = $"Select * From Branch where Description = '{BDescription.Text}'";

                try
                {

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        BID.Text = myReader["BID"].ToString();
                        BDescription.Text = myReader["Description"].ToString();
                        BCity.Text = myReader["PhoneNumber"].ToString();
                        BPostalCode.Text = myReader["PostalCode"].ToString();
                        BStreet_Address1.Text = myReader["Street_address1"].ToString();
                        BStreet_Address2.Text = myReader["Street_address2"].ToString();
                        BPhoneNumber.Text = myReader["City"].ToString();
                        BProvince.Text = myReader["Province"].ToString();


                        MessageBox.Show("Branch " + BDescription.Text + " found.");
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

            }
            else
            {
                MessageBox.Show("Please enter BranchID or Description.");
                return;
            }
        }

        private void PrevBranch_Click(object sender, EventArgs e)
        {
            if (BID.Text == "")
            {
                MessageBox.Show("Please enter a valid Branch ID.");
                return;
            }

            string sqlQuery = $"Select TOP 1 * From Branch b where b.BID < {BID.Text} Order by b.BID desc";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on first Branch.");
                return;
            }

            myCommand.CommandText = sqlQuery;


            try
            {

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    BID.Text = myReader["BID"].ToString();
                    BDescription.Text = myReader["Description"].ToString();
                    BCity.Text = myReader["PhoneNumber"].ToString();
                    BPostalCode.Text = myReader["PostalCode"].ToString();
                    BStreet_Address1.Text = myReader["Street_address1"].ToString();
                    BStreet_Address2.Text = myReader["Street_address2"].ToString();
                    BPhoneNumber.Text = myReader["City"].ToString();
                    BProvince.Text = myReader["Province"].ToString();


                    MessageBox.Show("Branch " + BDescription.Text + " found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void NextBranch_Click(object sender, EventArgs e)
        {
            if (BID.Text == "")
            {
                MessageBox.Show("Please enter a valid Branch ID.");
                return;
            }
            string sqlQuery = $"Select TOP 1 * From Branch b where b.BID > {BID.Text} Order by b.BID";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on last Branch.");
                return;
            }

            myCommand.CommandText = sqlQuery;

            try
            {

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    BID.Text = myReader["BID"].ToString();
                    BDescription.Text = myReader["Description"].ToString();
                    BCity.Text = myReader["PhoneNumber"].ToString();
                    BPostalCode.Text = myReader["PostalCode"].ToString();
                    BStreet_Address1.Text = myReader["Street_address1"].ToString();
                    BStreet_Address2.Text = myReader["Street_address2"].ToString();
                    BPhoneNumber.Text = myReader["City"].ToString();
                    BProvince.Text = myReader["Province"].ToString();


                    MessageBox.Show("Branch " + BDescription.Text + " found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //-----Add CarType button-----------------------------------
            myCommand.CommandText = "insert into CarType (CarTypeID, Description, DailyRate, WeeklyRate, MonthlyRate) values " +
                    "('" + CTCarTypeID.Text + "'" +
                    ",'" + CTCarDesc.Text + "'" +
                    ",'" + DailyRate.Text + "'" +
                    ",'" + WeeklyRate.Text + "'" +
                    ",'" + MonthlyRate.Text + "'" +
                    ")";

            MessageBox.Show(myCommand.CommandText);

            myCommand.ExecuteNonQuery();
            clear_carType();
            //----------------------------------------------------------
        }

        private void CTsearch_Click(object sender, EventArgs e)
        {
            //--------Search CarType button----------------------------
            String selected_CarDesc = "placeholder";

            if (CTCarDesc.SelectedItem != null)
                selected_CarDesc = CTCarDesc.SelectedItem.ToString();

            myCommand.CommandText = "select * from CarType";
            if (CTCarTypeID.Text != "")
                myCommand.CommandText += " where CarTypeID = '" + CTCarTypeID.Text + "'";
            else
                myCommand.CommandText += " where Description = '" + selected_CarDesc + "'";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    CTCarTypeID.Text = myReader["CarTypeID"].ToString();
                    CTCarDesc.SelectedItem = myReader["Description"].ToString();
                    DailyRate.Text = myReader["DailyRate"].ToString();
                    WeeklyRate.Text = myReader["WeeklyRate"].ToString();
                    MonthlyRate.Text = myReader["MonthlyRate"].ToString();

                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            //--------------------------------------------------------
        }

        private void RentalSearch_Click(object sender, EventArgs e)
        {
            /*
            //--------------Rental Search------------------------
            myCommand.CommandText = "select * from Rentals as R, Branch as B, Car as C, CarType as CT where R.PickupBID = B.BID and R.VIN = C.VIN and C.CarTypeID = CT.CarTypeID" +
                                    " and TID = '" + TransactionID.Text + "'";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    pickupbranchBox.SelectedValue = myReader["PickupBID"];
                    dropoffbranchBox.SelectedValue = myReader["ReturnBID"];
                    pickupDate.Text = myReader["PickupDate"].ToString();
                    dropoffDate.Text = myReader["ReturnDate"].ToString();
                    CarTypeBox.SelectedValue = myReader["CarTypeID"];
                    available_car.SelectedValue = myReader["VIN"];
                    Daily_rate.Text = myReader["DailyRate"].ToString();
                    weekly_rate.Text = myReader["WeeklyRate"].ToString();
                    monthly_rate.Text = myReader["MonthlyRate"].ToString();
                    //dropoffbranchBox.SelectedItem = myReader["select Description from Rentals as R, Branch as B where R.dropoffBID = B.BID"].ToString();                 

                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            //--------------------------------------------------
            */

        }

        private void button3_Click_2(object sender, EventArgs e)
        {//Add Car Button
            SqlDataAdapter da = new SqlDataAdapter("Select VIN From Car where VIN = '" + VIN.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (VIN.Text == "")
            {
                MessageBox.Show("Invalid VIN");
                return;
            }

            else if (CBID.Text == "0")
            {
                MessageBox.Show("Select a valid Branch ID");
                return;
            }

            else if (CCarType.Text == "0")
            {
                MessageBox.Show("Select a valid Car Type ID");
                return;
            }

            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("VIN already exists. Click Update Car to update car info.");
                return;
            }

            else if (dt.Rows.Count == 0)
            {

                myCommand.CommandText = $"insert into Car (VIN, Make, Model, Year, NumberofSeats, Color, InsuranceNumber, OdometerNumber, BID, CarTypeID) values " +
                    $"( '{VIN.Text}', '{Make.Text}', '{Model.Text}', '{Year.Text}', '{Seats.Text}', '{Color.Text}', '{CInsurance.Text}', '{Odometer.Text}', '{CBID.Text}', '{CCarType.SelectedValue.ToString()}')";

                MessageBox.Show($"VIN: {VIN.Text} created in Car Table!");
                myCommand.ExecuteNonQuery();
                clear_car();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//Update Car Button
            SqlDataAdapter da = new SqlDataAdapter("Select VIN From Car where VIN = '" + VIN.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (VIN.Text == "")
            {
                MessageBox.Show("Invalid VIN");
                return;
            }

            else if (CBID.Text == "0")
            {
                MessageBox.Show("Select a valid Branch ID");
                return;
            }

            else if (CCarType.Text == "0")
            {
                MessageBox.Show("Select a valid Car Type ID");
                return;
            }

            else if (dt.Rows.Count > 0)
            {
                myCommand.CommandText = $"update Car set " +
                    $"Make = '{Make.Text}' ," +
                    $"Model = '{Model.Text}' , " +
                    $"Year = '{Year.Text}' ," +
                    $"NumberofSeats = '{Seats.Text}' ," +
                    $"OdometerNumber = '{Odometer.Text}' ," +
                    $"BID = '{CBID.Text}' , " +
                    $"Color = '{Color.Text}' ," +
                    $"CarTypeID = '{CCarType.Text}' ," +
                    $"InsuranceNumber = '{CInsurance.Text}'" +
                    $"where VIN = '{VIN.Text}'";

                myCommand.ExecuteNonQuery();
                MessageBox.Show($"{VIN.Text} updated");
                clear_car();
            }
            else
            {
                MessageBox.Show("Car with given VIN does not exist.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//Delete Car Button
            SqlDataAdapter da = new SqlDataAdapter("Select VIN From Car where VIN = '" + VIN.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (VIN.Text == "")
            {
                MessageBox.Show("Invalid VIN");
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("VIN not found");
            }

            else if (VIN.Text != "")
            {
                myCommand.CommandText = "delete from Car where VIN = '" + VIN.Text + "'";

                //confirmation message
                string mess = $"Are you sure you want to delete VIN {VIN.Text}?";
                string title = "Confirmation";

                //condition
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mess, title, buttons);

                //answer condition
                if (result == DialogResult.Yes)
                {
                    string warning_message = "Deleting the Car will delete all the rental records for this Car. Do you still want to proceed?";
                    string warning_title = "Warning!!";

                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult warning_result = MessageBox.Show(warning_message, warning_title, buttons1);

                    if (warning_result == DialogResult.Yes)
                    {
                        if (can_delete_transaction("Car"))
                        {
                            myCommand.ExecuteNonQuery();
                            MessageBox.Show($"VIN {VIN.Text} deleted.");
                            clear_car();

                        }
                        else
                        {
                            MessageBox.Show("Cannot delete Car. Pending Rental Transaction is found.");
                        }

                    }

                }
                else { return; }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//Get  Car Button
            //if all textboxes are empty, display message
            if (VIN.Text == "")
            {
                MessageBox.Show("Please enter VIN");
                return;
            }

            if (VIN.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select VIN From Car where VIN = '" + VIN.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("VIN not found.");
                    return;
                }

                myCommand.CommandText = "select * from Car where VIN = '" + VIN.Text + "'";

                try
                {
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        VIN.Text = myReader["VIN"].ToString();
                        Make.Text = myReader["Make"].ToString();
                        Model.Text = myReader["Model"].ToString();
                        Year.Text = myReader["Year"].ToString();
                        Seats.Text = myReader["NumberofSeats"].ToString();
                        Odometer.Text = myReader["OdometerNumber"].ToString();
                        CBID.Text = myReader["BID"].ToString();
                        Color.Text = myReader["Color"].ToString();
                        CCarType.Text = myReader["CarTypeID"].ToString();
                        CInsurance.Text = myReader["InsuranceNumber"].ToString();

                        MessageBox.Show($"VIN {VIN.Text} found.");
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {//Previous Car Button
            if (VIN.Text == "")
            {
                MessageBox.Show("Please enter a valid VIN.");
                return;
            }

            int VIN_Length = VIN.Text.Length;

            string sqlQuery = $"select Top 1 * from Car c where SUBSTRING(c.VIN, 1, LEN(c.VIN)) < SUBSTRING('{VIN.Text}', 1, {VIN_Length}) order by c.VIN desc";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on first car.");
                return;
            }

            myCommand.CommandText = sqlQuery;

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    VIN.Text = myReader["VIN"].ToString();
                    Make.Text = myReader["Make"].ToString();
                    Model.Text = myReader["Model"].ToString();
                    Year.Text = myReader["Year"].ToString();
                    Seats.Text = myReader["NumberofSeats"].ToString();
                    Odometer.Text = myReader["OdometerNumber"].ToString();
                    CBID.Text = myReader["BID"].ToString();
                    Color.Text = myReader["Color"].ToString();
                    CCarType.Text = myReader["CarTypeID"].ToString();
                    CInsurance.Text = myReader["InsuranceNumber"].ToString();

                    MessageBox.Show($"VIN {VIN.Text} found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {//Next Car Button
            if (VIN.Text == "")
            {
                MessageBox.Show("Please enter a valid VIN.");
                return;
            }

            int VIN_Length = VIN.Text.Length;

            string sqlQuery = $"select Top 1 * from Car c where SUBSTRING(c.VIN, 1, LEN(c.VIN)) > SUBSTRING('{VIN.Text}', 1, {VIN_Length}) order by c.VIN";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Currently on last car.");
                return;
            }

            myCommand.CommandText = sqlQuery;

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    VIN.Text = myReader["VIN"].ToString();
                    Make.Text = myReader["Make"].ToString();
                    Model.Text = myReader["Model"].ToString();
                    Year.Text = myReader["Year"].ToString();
                    Seats.Text = myReader["NumberofSeats"].ToString();
                    Odometer.Text = myReader["OdometerNumber"].ToString();
                    CBID.Text = myReader["BID"].ToString();
                    Color.Text = myReader["Color"].ToString();
                    CCarType.Text = myReader["CarTypeID"].ToString();
                    CInsurance.Text = myReader["InsuranceNumber"].ToString();

                    MessageBox.Show($"VIN {VIN.Text} found.");
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customer.SelectedTab == Customer.TabPages["rentals_tab"])
            {
                TransactionID.Text = "1";
                string q = "Select MAX(TID) AS max_id From Rentals";
                myCommand.CommandText = q;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TransactionID.Text = (int.Parse(myReader["max_id"].ToString()) + 1).ToString();
                }
                myReader.Close();


                pickupDate.MinDate = DateTime.Today;
                dropoffDate.MinDate = DateTime.Today;

                //----rentals pickup branch box--------------
                SqlDataAdapter pickup_branch_adapter = new SqlDataAdapter("Select BID, (Description + ', ' + City) AS Location FROM Branch", con);
                DataTable dt = new DataTable();
                pickup_branch_adapter.Fill(dt);

                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                pickupbranchBox.DataSource = dt;
                pickupbranchBox.DisplayMember = "Location";
                pickupbranchBox.ValueMember = "BID";
                //--------------------------------------------


                //----rentals dropoff branch box--------------
                SqlDataAdapter dropoff_branch_adapter = new SqlDataAdapter("Select BID, (Description + ', ' + City) AS Location FROM Branch", con);
                DataTable dt1 = new DataTable();
                dropoff_branch_adapter.Fill(dt1);

                DataRow row1 = dt1.NewRow();
                row1[0] = 0;
                row1[1] = "Please select";
                dt1.Rows.InsertAt(row1, 0);

                dropoffbranchBox.DataSource = dt1;
                dropoffbranchBox.DisplayMember = "Location";
                dropoffbranchBox.ValueMember = "BID";
                //--------------------------------------------

                //----------rentals customer box-----------------
                SqlDataAdapter rental_customer_adapter = new SqlDataAdapter("Select CID, (CAST(CID AS varchar) + '. ' + FirstName + ' ' + LastName) AS Customer_info FROM Customer", con);
                DataTable dt2 = new DataTable();
                rental_customer_adapter.Fill(dt2);

                DataRow row2 = dt2.NewRow();
                row2[0] = 0;
                row2[1] = "Please select";

                dt2.Rows.InsertAt(row2, 0);
                Rental_customerID.DataSource = dt2;
                Rental_customerID.DisplayMember = "Customer_info";
                Rental_customerID.ValueMember = "CID";
            }

            else if (Customer.SelectedTab == Customer.TabPages["Customers"])
            {
                CID.Text = "1";
                string q = "Select MAX(CID) AS max_id From Customer";
                myCommand.CommandText = q;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    CID.Text = (int.Parse(myReader["max_id"].ToString()) + 1).ToString();
                }
                myReader.Close();
            }

            else if (Customer.SelectedTab == Customer.TabPages["Branch"])
            {
                BID.Text = "1";
                string q = "Select MAX(BID) AS max_id From Branch";
                myCommand.CommandText = q;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    BID.Text = (int.Parse(myReader["max_id"].ToString()) + 1).ToString();
                }
                myReader.Close();
            }

            else if (Customer.SelectedTab == Customer.TabPages["car_tab"])
            {
                //-----------CarType dropdown box---------------------------------
                SqlDataAdapter carType_adapter = new SqlDataAdapter("SELECT CarTypeID, Description from CarType", con);


                DataTable car_type_table = new DataTable();
                carType_adapter.Fill(car_type_table);

                DataRow car_type_defalut = car_type_table.NewRow();

                car_type_defalut[0] = 0;
                car_type_defalut[1] = "Please Select";
                car_type_table.Rows.InsertAt(car_type_defalut, 0);

                CCarType.DataSource = car_type_table;
                CCarType.DisplayMember = "Description";
                CCarType.ValueMember = "CarTypeID";
                //-------------------------------------------------------------
                //-------------Car BID dropdown box----------------------------
                SqlDataAdapter CBID_adapter = new SqlDataAdapter("Select BID from Branch", con);

                DataTable CBID_table = new DataTable();
                CBID_adapter.Fill(CBID_table);

                DataRow CBID_default = CBID_table.NewRow();

                CBID_default[0] = 0;
                CBID_table.Rows.InsertAt(CBID_default, 0);

                CBID.DataSource = CBID_table;
                CBID.DisplayMember = "BID";
                CBID.ValueMember = "BID";
                //--------------------------------------------------------------
            }
            else if (Customer.SelectedTab == Customer.TabPages["car_type_tab"])
            {
                CTCarTypeID.Text = "1";
                string q = "Select MAX(CarTypeID) AS max_id From CarType";
                myCommand.CommandText = q;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    CTCarTypeID.Text = (int.Parse(myReader["max_id"].ToString()) + 1).ToString();
                }
                myReader.Close();
            }
            else if (Customer.SelectedTab == Customer.TabPages["stats_tab"])
            {
               
            }
        }

        private void CarTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected_CarType, selected_BID;
            selected_CarType = CarTypeBox.SelectedValue.ToString();
            selected_BID = pickupbranchBox.SelectedValue.ToString();

            int testing;

            if (int.TryParse(selected_CarType, out testing))
            {

                SqlDataAdapter car_adapter = new SqlDataAdapter("SELECT VIN, (Make + ' ' + Model) as car_info from Car WHERE CarTypeID = " + selected_CarType + " and BID = " + selected_BID, con);

                DataTable car_table = new DataTable();
                car_adapter.Fill(car_table);

                foreach (DataRow r in car_table.Select())
                {
                    String q = $"Select VIN, PickupDate, ReturnDate from Rentals WHERE VIN = '{r[0]}'";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd1 = new SqlCommand(q, con);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        if (pickupDate.Value <= dr1.GetDateTime(2) && pickupDate.Value >= dr1.GetDateTime(1))
                        {
                            r.Delete();
                        }
                        else if (dropoffDate.Value <= dr1.GetDateTime(2) && dropoffDate.Value >= dr1.GetDateTime(1))
                        {
                            r.Delete();
                        }
                    }
                    dr1.Close();
                }

                DataRow car_defalut = car_table.NewRow();

                car_defalut[0] = 0;
                car_defalut[1] = "Please select";
                car_table.Rows.InsertAt(car_defalut, 0);

                available_car.DataSource = car_table;
                available_car.DisplayMember = "car_info";
                available_car.ValueMember = "VIN";

                //--------display rates of selected car type-----------
                string query = "SELECT DailyRate, WeeklyRate, MonthlyRate FROM CarType WHERE CarTypeID = " + selected_CarType;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Daily_rate.Text = "$" + dr.GetDecimal(0).ToString();
                    weekly_rate.Text = "$" + dr.GetDecimal(1).ToString();
                    monthly_rate.Text = "$" + dr.GetDecimal(2).ToString();
                }
                dr.Close();
            }
            show_rate();

        }

        private void Set_membership()
        {
            string year = pickupDate.Value.ToString("yyyy");
            string CID = Rental_customerID.SelectedValue.ToString();
            int rental_count = 0;


            string query = $"SELECT count(*) AS Rental_count FROM (select CID, YEAR(pickupDate) AS Year FROM Rentals WHERE CID = {CID}) R WHERE R.Year = {pickupDate.Value.ToString("yyyy")}";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rental_count = dr.GetInt32(0);
            }

            dr.Close();



            if (rental_count >= 3)
            {
                myCommand.CommandText = "UPDATE Customer Set Membership = 'Gold' WHERE CID =" + CID;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Congratulations! You have been awared Gold Memebership");
            }
        }

        private void Rent_button_Click(object sender, EventArgs e)
        {
            if (TransactionID.Text.ToString().Length > 0 && int.TryParse(TransactionID.Text.ToString(), out int r) && int.Parse(Rental_customerID.SelectedValue.ToString()) != 0 && int.Parse(pickupbranchBox.SelectedValue.ToString()) != 0 && int.Parse(dropoffbranchBox.SelectedValue.ToString()) != 0 && int.Parse(CarTypeBox.SelectedValue.ToString()) != 0 && !(available_car.SelectedValue.ToString().Equals("0")))
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter($"Select TID From Rentals where TID = {TransactionID.Text}", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Transaction ID already Exist");
                    return;
                }
                else
                {
                    show_rate();

                    myCommand.CommandText = "insert into Rentals (TID, PickupDate, ReturnDate, CID, VIN, PickupBID, ReturnBID, RentValueTotal) values " +
                        "(" + TransactionID.Text + "" +
                        ",'" + pickupDate.Value.ToShortDateString() + "'" +
                        ",'" + dropoffDate.Value.ToShortDateString() +
                        "'," + Rental_customerID.SelectedValue.ToString() +
                        ",'" + available_car.SelectedValue.ToString() +
                        "'," + pickupbranchBox.SelectedValue.ToString() +
                        "," + dropoffbranchBox.SelectedValue.ToString() +
                        "," + Convert.ToDecimal(total_charge.Text.Replace("$", "")) +
                        ")";

                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);

                    if (!(pickupbranchBox.SelectedValue.ToString().Equals(dropoffbranchBox.SelectedValue.ToString())))
                    {
                        myCommand.CommandText = "UPDATE Car Set BID = " + dropoffbranchBox.SelectedValue.ToString() + " WHERE VIN = '" + available_car.SelectedValue.ToString() + "'";
                        myCommand.ExecuteNonQuery();
                    }
                    string membership = "Standard";

                    string query = "SELECT Membership FROM Customer WHERE CID = " + Rental_customerID.SelectedValue.ToString();
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        membership = dr.GetString(0);
                    }
                    dr.Close();


                    if (membership.Equals("Standard"))
                    {
                        Set_membership();
                    }
                    clear_rentals();

                }
            }
            else if (!(int.TryParse(TransactionID.Text.ToString(), out int r1)))
            {
                MessageBox.Show("Invalid Transaction ID");
            }

            else
            {
                MessageBox.Show("Please fill the required Information");
            }

        }

        private void dropoffDate_ValueChanged(object sender, EventArgs e)
        {
            CarTypeBox.SelectedValue = 0;
        }

        private void available_car_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test_int;
            if (int.TryParse(available_car.SelectedValue.ToString(), out test_int) && !(available_car.SelectedValue.ToString().Equals("0")))
            {
                String query = "Select * from Car Where VIN = '" + available_car.SelectedValue.ToString() + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                rental_vin.Visible = true;
                rental_make.Visible = true;
                rental_model.Visible = true;
                rental_year.Visible = true;
                rental_seats.Visible = true;
                rental_color.Visible = true;
                rental_insurance.Visible = true;
                rental_odometer.Visible = true;

                while (dr.Read())
                {
                    rental_vin.Text = dr.GetString(0);
                    rental_make.Text = dr.GetString(1);
                    rental_model.Text = dr.GetString(2);
                    rental_year.Text = dr.GetDecimal(3).ToString();
                    rental_seats.Text = dr.GetDecimal(4).ToString();
                    rental_color.Text = dr.GetString(5);
                    rental_insurance.Text = dr.GetString(6);
                    rental_odometer.Text = dr.GetDecimal(7).ToString();
                }
                dr.Close();
            }
            else
            {
                rental_vin.Visible = false;
                rental_make.Visible = false;
                rental_model.Visible = false;
                rental_year.Visible = false;
                rental_seats.Visible = false;
                rental_color.Visible = false;
                rental_insurance.Visible = false;
                rental_odometer.Visible = false;
            }
        }

        private void dropoffbranchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test_int;
            string selected_BID = dropoffbranchBox.SelectedValue.ToString();

            if (int.TryParse(selected_BID, out test_int) && !(selected_BID.Equals("0")))
            {
                string query = "select Street_address1, Street_address2, (City + ', ' + Province + ', ' + PostalCode) as address_line3 from Branch where BID = " + selected_BID;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                d_address_line1.Visible = true;
                d_address_line2.Visible = true;
                d_address_line3.Visible = true;

                while (dr.Read())
                {
                    d_address_line1.Text = dr.GetString(0);

                    if (dr.GetString(1).Length > 0)
                    {
                        d_address_line2.Text = dr.GetString(1);
                        d_address_line3.Text = dr.GetString(2);
                    }
                    else
                    {
                        d_address_line3.Visible = false;
                        d_address_line2.Text = dr.GetString(2);
                    }

                }
                dr.Close();
            }
            else
            {
                d_address_line1.Visible = false;
                d_address_line2.Visible = false;
                d_address_line3.Visible = false;
            }

            show_rate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CarTypeID From CarType where CarTypeID = '" + CTCarTypeID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (CTCarTypeID.Text == "")
            {
                MessageBox.Show("Invalid CarType ID");
                return;
            }

            else if (dt.Rows.Count > 0)
            {

                myCommand.CommandText = $"UPDATE CarType SET " +
                  $"Description = '{CTCarDesc.SelectedItem.ToString()}', " +
                  $"DailyRate = '{DailyRate.Text}', " +
                  $"WeeklyRate = '{WeeklyRate.Text}', " +
                  $"MonthlyRate = '{MonthlyRate.Text}' " +
                  $"WHERE CarTypeID = '{CTCarTypeID.Text}'";


                myCommand.ExecuteNonQuery();
                MessageBox.Show("CarType updated");
            }
            else
            {
                MessageBox.Show("CarType with given ID does not exist.");
            }

        }

        private void CTdelete_Click(object sender, EventArgs e)
        {



            //----------CarType Delete------------------------------------
            SqlDataAdapter da = new SqlDataAdapter("Select CarTypeID From CarType where CarTypeID = '" + CTCarTypeID.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (CTCarTypeID.Text == "")
            {
                MessageBox.Show("Invalid CarType ID");
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CarTypeID not found");
            }
            else
            {
                myCommand.CommandText = "delete from CarType where CarTypeID = '" + CTCarTypeID.Text + "'";

                //confirmation message
                string mess = "Are you sure you want to delete CarType?";
                string title = "Confirmation";

                //condition
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mess, title, buttons);

                //answer condition
                if (result == DialogResult.Yes)
                {
                    string warning_message = "Deleting the CarType will delete all the Cars Under this Car Type including the rental Transactions. Do you still want to proceed?";
                    string warning_title = "Warning!!";

                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult warning_result = MessageBox.Show(warning_message, warning_title, buttons1);

                    if (warning_result == DialogResult.Yes)
                    {
                        if (can_delete_transaction("CarType"))
                        {
                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("CarType deleted.");
                            clear_carType();

                        }
                        else
                        {
                            MessageBox.Show("Cannot delete CarType. Pending Rental Transaction is found.");
                        }

                    }
                }

                else { return; }
            }
            //--------------------------------------------------------
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adress empty search textbox and transaction not in DB
            if (RStransID.Text == "")
            {
                MessageBox.Show("Please enter a Transaction ID.");
                return;
            }

            SqlDataAdapter TSearch = new SqlDataAdapter("Select TID From Rentals where TID = '" + RStransID.Text + "'", con);
            DataTable dt = new DataTable();
            TSearch.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Transaction with entered ID not found");
                return;
            }


            //--------------Rental Search------------------------
            myCommand.CommandText = "select * from Rentals as R, Branch as B, Car as C, CarType as CT, Customer as CU where R.PickupBID = B.BID and R.VIN = C.VIN and C.CarTypeID = CT.CarTypeID and R.CID = CU.CID" +
                                    " and TID = '" + RStransID.Text + "'";

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    RSpickupBranchD.Text = myReader["PickupBID"].ToString();
                    RSdropoffBranchD.Text = myReader["ReturnBID"].ToString();
                    RSpickupDateD.Text = myReader["PickupDate"].ToString();
                    renatl_search_dropoffdate.Text = myReader["ReturnDate"].ToString();
                    RScustomerIDD.Text = myReader["CID"].ToString();
                    RSvinD.Text = myReader["VIN"].ToString();
                    RSmakeD.Text = myReader["Make"].ToString();
                    RSmodelD.Text = myReader["Model"].ToString();
                    RScustomerNameD.Text = myReader["FirstName"].ToString() + " " + myReader["LastName"].ToString();
                    RStotalRentValueD.Text = "$" + myReader["RentValueTotal"].ToString();

                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            RSpickupBranchD.Visible = true;
            RSdropoffBranchD.Visible = true;
            RSpickupDateD.Visible = true;
            renatl_search_dropoffdate.Visible = true;
            RScustomerIDD.Visible = true;
            RSvinD.Visible = true;
            RScustomerIDD.Visible = true;
            RSmakeD.Visible = true;
            RSmodelD.Visible = true;
            RScustomerNameD.Visible = true;
            RStotalRentValueD.Visible = true;
            //--------------------------------------------------

        }

        private void RSfinalize_Click(object sender, EventArgs e)
        {
            //---------Rental Search Update Dropoff Date----------------------
            myCommand.CommandText = $"UPDATE Rentals SET " +
                  $"ReturnDate = '{RSdReturnDatePicker.Value.ToShortDateString()}' " +
                  $"WHERE TID = '{RStransID.Text}'";


            myCommand.ExecuteNonQuery();
            MessageBox.Show("Dropoff date updated");
            clear_transaction();
            //-------------------------------------------------------------------
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (selectStat.Text == "1")
            {
                statLabel.Text = "     Display customers name over between 25 and 35 years old, \n who rented a 'non white', 'Full - size SUV' car outside Edmonton,  \n                               and returned it in Edmonton. ";
                statLabel.Visible = true;
                range_from.Visible = false;
                range_to.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label51.Visible = false;
            }
            //string q = "Display customers name between 25 and 30 years old, who rented a 'non white', 'Full - size SUV' car outside Edmonton,  and returned it in Edmonton. ";
            else if (selectStat.Text == "2")
            {
                statLabel.Text = "     Display Total No. of days for which each car from\n        each car Type has been rented for including\n          the Total revenue generated by each car.";
                statLabel.Visible = true;
                range_from.Visible = false;
                range_to.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label51.Visible = false;
            }
            //-----Total spending ordered by age ascending---------------------------------------------------
            else if (selectStat.Text == "3")
            {
                statLabel.Text = "     Display total spending of each customer \n       from oldest to youngest.";
                statLabel.Visible = true;
                range_from.Visible = false;
                range_to.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label51.Visible = false;
            }
            //-----Most popular car type rented by people in month X---------------------------------------------------
            else if (selectStat.Text == "4")
            {
                statLabel.Text = "     Display most popular car type rented \n       by people in month X.";
                range_from.Visible = true;
                range_to.Visible = true;
                label49.Visible = true;
                label50.Visible = true;
                label51.Visible = true;
                statLabel.Visible = true;
            }
            //-----name of all branches from where every car has been reted at least once---------------------------------------------------
            else if (selectStat.Text == "5")
            {
                statLabel.Text = "     Display the name of all branches from where every car \n       has been rented at least once.";
                statLabel.Visible = true;
                range_from.Visible = false;
                range_to.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label51.Visible = false;
            }

        }


        private void clear_customer()
        {
            CID.Text = "";
            FName.Text = "";
            MName.Text = "";
            LName.Text = "";
            PhoneNumber.Text = "";
            Insurance.Text = "";
            PostalCode.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.Text = "";
            DriverLicense.Text = "";
            DOB.Text = "";
        }

        private void clear_branch()
        {
            BID.Text = "";
            BDescription.Text = "";
            BPhoneNumber.Text = "";
            BPostalCode.Text = "";
            BStreet_Address1.Text = "";
            BStreet_Address2.Text = "";
            BCity.Text = "";
            BProvince.Text = "";
        }

        private void clear_car()
        {
            VIN.Text = "";
            Make.Text = "";
            Model.Text = "";
            Year.Text = "";
            Seats.Text = "";
            Odometer.Text = "";
            CBID.Text = "";
            Color.Text = "";
            CCarType.Text = "";
            CInsurance.Text = "";
        }

        private void clear_carType()
        {
            CTCarTypeID.Text = "";
            CTCarDesc.SelectedItem = "";
            DailyRate.Text = "";
            WeeklyRate.Text = "";
            MonthlyRate.Text = "";
        }

        private void clear_rentals()
        {
            TransactionID.Text = "";
            Rental_customerID.SelectedValue = 0;
            pickupbranchBox.SelectedValue = 0;
            dropoffbranchBox.SelectedValue = 0;
            CarTypeBox.SelectedValue = 0;
            available_car.SelectedValue = 0;
            pickupDate.Text = "";
            dropoffDate.Text = "";
            Daily_rate.Text = "$0.00";
            weekly_rate.Text = "$0.00";
            monthly_rate.Text = "$0.00";
            price.Text = "$0.00";
            gst.Text = "$0.00";
            branch_fee.Text = "$0.00";
            total_charge.Text = "$0.00";

        }

        private void clear_transaction()
        {
            RStransID.Text = "";
            RSpickupBranchD.Text = "";
            RSdropoffBranchD.Text = "";
            RSpickupDateD.Text = "";
            renatl_search_dropoffdate.Text = "";
            RScustomerIDD.Text = "";
            RSvinD.Text = "";
            RSmakeD.Text = "";
            RSmodelD.Text = "";
            RScustomerNameD.Text = "";
            RStotalRentValueD.Text = "";
        } 

        private void RSdropoffDatePicker_ValueChanged(object sender, EventArgs e)
        {
            float late_fee;
            float total_charge;
            float old_charge;
            float daily_rate = 0;

            late_return_fee.Visible = true;
            total_final_charge.Visible = true;


            old_charge = float.Parse(RStotalRentValueD.Text.ToString().Replace("$", ""));

            if (DateTime.Parse(renatl_search_dropoffdate.Text) < RSdReturnDatePicker.Value)
            {
                TimeSpan t_late_days = RSdReturnDatePicker.Value - DateTime.Parse(renatl_search_dropoffdate.Text);
                int late_days = Int32.Parse(t_late_days.Days.ToString());
                myCommand.CommandText = $"Select CarType.DailyRate from CarType, Car WHERE CarType.CarTypeID = Car.CarTypeID and Car.VIN = '{RSvinD.Text}'";
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    daily_rate = float.Parse(myReader["Dailyrate"].ToString());
                }

                myReader.Close();


                late_fee = daily_rate * (float)late_days;
                total_charge = late_fee + old_charge;


                late_return_fee.Text = "$" + late_fee.ToString(".00#");
                total_final_charge.Text = "$" + total_charge.ToString(".00#");

            }
            else
            {
                total_charge = old_charge;
                late_return_fee.Text = "$0.00";
                total_final_charge.Text = "$" + total_charge.ToString(".00#");
            }
        }

        private void Daily_rate_Click(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {
            if (selectStat.Text == "")
            {
                MessageBox.Show("Please select a Stat to display.");
                return;
            }

            if (selectStat.Text == "1")
            {
                //Query1: display customers name over between 25 and 30 years old, who rented a "non white", "Full-size SUV" car outside Edmonton,  and returned it in Edmonton.

                SqlDataAdapter query1 = new SqlDataAdapter("SELECT c.FirstName, c.LastName " +
                                                           "FROM CUSTOMER c " +
                                                           "INNER JOIN Rentals r on r.CID = c.CID " +
                                                           "INNER JOIN Branch b1 on b1.BID = r.PickupBID " +
                                                           "INNER JOIN Branch b2 on b2.BID = r.ReturnBID " +
                                                           "INNER JOIN Car ca on ca.VIN = r.VIN " +
                                                           "INNER JOIN CarType ct on ct.CarTypeID = ca.CarTypeID " +
                                                           "WHERE c.CID in " +
                                                           "        (SELECT c2.CID FROM Customer c2 WHERE CAST(ROUND((DATEDIFF(DAY, c2.DateofBirth, GETDATE()) / 365.0), 0) AS INT)  BETWEEN 25 AND 35) " +
                                                           "AND ca.Color != 'White' " +
                                                           "AND ct.Description = 'Full-size SUV' " +
                                                           "AND b1.City != 'Edmonton' " +
                                                           "AND b2.City = 'Edmonton'", con);

                DataTable dt = new DataTable();
                query1.Fill(dt);

                dataGridView1.DataSource = dt;

                return;
            }

            else if (selectStat.Text == "2")
            {
                //query 2: display the total number of days each car from each car type has been rented and the total revenue generated by that car
                SqlDataAdapter query2 = new SqlDataAdapter("select Description, C.VIN ," +
                                                           "SUM((DATEDIFF (day, PickupDate, ReturnDate))) as 'No. of Days' ," +
                                                           "SUM(RentValueTotal) as 'Total Revenue($)'" +
                                                           "from Rentals R FULL OUTER JOIN Car C ON R.VIN = C.VIN " +
                                                           "FULL OUTER JOIN CarType CT ON C.CarTypeID = CT.CarTypeID " +
                                                           "Group by CT.Description, C.VIN " +
                                                           "ORDER BY [Total Revenue($)] DESC", con);

                DataTable dt2 = new DataTable();
                query2.Fill(dt2);

                foreach (DataRow row in dt2.Rows)
                {
                    if (row["No. of Days"].ToString().Length == 0)
                    {
                        row["No. of Days"] = "0";
                    }
                    if (row["Total Revenue($)"].ToString().Length == 0)
                    {
                        row["Total Revenue($)"] = "0";
                    }

                }

                dataGridView1.DataSource = dt2;

                return;
            }
            else if (selectStat.Text == "3")
            {
                //query 3: display the total amount spent in age by ascending order
                SqlDataAdapter query2 = new SqlDataAdapter("SELECT (C.FirstName + ' ' + C.LastName) as FullName, totalsum  FROM (SELECT CID, SUM(RentValueTotal) as totalsum FROM Rentals" +
                    " GROUP BY CID) as S1, Customer as C WHERE S1.CID = C.CID ORDER BY DateofBirth asc", con);

                DataTable dt2 = new DataTable();
                query2.Fill(dt2);
                               
                dataGridView1.DataSource = dt2;

                return;
            }
            else if (selectStat.Text == "4")
            {
                //query 4: most popular car type rented by people in month X
                SqlDataAdapter query2 = new SqlDataAdapter("select top 1 Description from CarType ct INNER JOIN Car c on C.CarTypeID = ct.CarTypeID" +
                    $" INNER JOIN Rentals R on R.VIN = c.VIN where MONTH(R.PickupDate) = {range_from.Value.Month} and YEAR(R.PickupDate) = {range_from.Value.Year} and MONTH(R.ReturnDate) = {range_to.Value.Month} and YEAR(R.ReturnDate) = {range_to.Value.Year} group by" +
                    " Description order by count(*) desc", con);

                

                DataTable dt2 = new DataTable();
                query2.Fill(dt2);

                dataGridView1.DataSource = dt2;

                return;
            }
            else if (selectStat.Text == "5")
            {
                //query 5: name of all branches from where every car has been reted at least once
                SqlDataAdapter query2 = new SqlDataAdapter("select B.BID, Description from Branch B, (select BID from Car except select BID from Car where VIN NOT in (select" +
                    " VIN from Rentals)) R where B.BID = R.BID", con);

                DataTable dt2 = new DataTable();
                query2.Fill(dt2);

                dataGridView1.DataSource = dt2;

                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stats_label_Click(object sender, EventArgs e)
        {

        }

        private void delete_transaction_Click(object sender, EventArgs e)
        {
            if (RScustomerIDD.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TID From Rentals where TID = '" + RStransID.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                myCommand.CommandText = "delete from Rentals where TID = '" + RStransID.Text + "'";
                //add a pop up box with "are you sure you want to delete Transaction?"

                //confirmation message
                string mess = "Are you sure you want to delete thsi Transaction?";
                string title = "Confirmation";

                //condition
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mess, title, buttons);

                //answer condition
                if (result == DialogResult.Yes)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Transaction deleted.");
                    clear_transaction();
                }

                else { return; }

            }
            else
            {
                MessageBox.Show("Search Transaction to delete.");
            }
        }
    }
}



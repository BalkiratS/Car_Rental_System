﻿using System;
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
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=291_group2;Integrated Security=True");

        
        public Form1()
        {
            InitializeComponent();


            ///////////////////////////////
            /*operation.Items.Clear();
            operation.Items.Add("Show all");
            operation.Items.Add("Show with starting grade: ");*/
            //////////////////////////////////
            ///
            String connectionString = "Server = LAPTOP-KI5F3RA4; Database = 291_group2; Trusted_Connection = yes;";


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displaypbranch.Text = pickupbranchBox.Text;
            displaypbranch.Visible = true;
            displaypdate.Text = pickupDate.Value.ToString();
            displaypdate.Visible = true;
            displayptime.Text = (pickupHour.Value.ToString() + ":" + pickupMinute.Value.ToString() + " " + pickupTimeAMPM.Text);
            displayptime.Visible = true;

            displaydbranch.Text = dropoffbranchBox.Text;
            displaydbranch.Visible = true;
            displayddate.Text = pickupDate.Value.ToString();
            displayddate.Visible = true;
            displaydtime.Text = (dropoffHour.Value.ToString() + ":" + dropoffMinute.Value.ToString() + " " + dropoffTimeAMPM.Text);
            displaydtime.Visible = true;
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
            this.branchTableAdapter.Fill(this._291_group2DataSet.Branch);

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

                if(MembershipS.Checked)
                {
                    membershipText = MembershipS.Text;
                }
                else if (MembershipG.Checked)
                {
                    membershipText = MembershipG.Text;
                }

                myCommand.CommandText = "insert into Customer (CID, Firstname, MiddleName, LastName, Phonenumber, DateofBirth, Street_address1, Street_address2, City, Province, PostalCode, Insurance,Membership, DriverLicense) values " +
                    "('"  + CID.Text + "'" +
                    ",'" + FName.Text + "'" +
                    ",'" + MName.Text + "'" +
                    ",'" + LName.Text + "'" +
                    ",'" + PhoneNumber.Text + "'" +
                    ",'" + DOB.Text +"'"+
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
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void BID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                myCommand.CommandText = "insert into Car (VIN, Make, Model, Year, NumberofSeats, Color, InsuranceNumber, OdometerNumber, BID, CarType) values " +
                    "('" + VIN.Text + "'" +
                    ",'" + Make.Text + "'" +
                    ",'" + Model.Text + "'" +
                    "," + Year.Text +
                    "," + Seats.Text +
                    ",'" + Color.Text + "'" +
                    ",'" + CInsurance.Text + "'" +
                    "," + Odometer.Text +
                    ",'" + CBID.Text + "'" +
                    ",'" + CCarType.Text + "'" +
                    ")";

                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            else { MessageBox.Show("Invalid Customer ID"); }
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
                  "FirstName = "       + "'" + FName.Text          + "'," +
                  "MiddleName = "      + "'" + MName.Text          + "'," +
                  "LastName = "        + "'" + LName.Text          + "'," +
                  "Phonenumber = "     + "'" + PhoneNumber.Text    + "'," +
                  "DateofBirth = "     + "'" + DOB.Text            + "'," +
                  "Street_address1 = " + "'" + StreetAddress1.Text + "'," +
                  "Street_address2 = " + "'" + StreetAddress2.Text + "'," +
                  "City = "            + "'" + City.Text           + "'," +
                  "Province = "        + "'" + Province.Text       + "'," +
                  "PostalCode = "      + "'" + PostalCode.Text     + "'," +
                  "Insurance = "       + "'" + Insurance.Text      + "'," +
                  "Membership = "      + "'" + membershipText      + "'," +
                  "DriverLicense = "   + "'" + DriverLicense.Text  + "'" +
                  "where CID = "       + "'" + CID.Text            + "'";

                myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer updated");
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
                myCommand.CommandText = "delete from Customer where CID = '" + CID.Text +"'";
                //add a pop up box with "are you sure you want to delete customer?"

                //confirmation message
                string mess = "Are you sure you want to delete customer?";
                string title = "Confirmation";

                //condition
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(mess, title, buttons);

                //answer condition
                if (result == DialogResult.Yes)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted.");

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
                
                else { return; }

                
            }
        }

        private void NextCustomer_Click(object sender, EventArgs e)
        {
            if (CID.Text == "")
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            string sqlQuery = $"Select TOP 1 * From Customer c where c.CID > {CID.Text} Order by c.CID"; 

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery,con);
            
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

                myCommand.CommandText = $"update Branch set "     +
                  $"Description = '{ BDescription.Text}',"       +
                  $"Phonenumber = '{BPhoneNumber.Text}',"         +
                  $"Street_address1 = '{BStreet_Address1.Text}'," +
                  $"Street_address2 = '{BStreet_Address2.Text}'," +
                  $"City = '{BCity.Text}',"                       +
                  $"Province = '{BProvince.Text}',"               +
                  $"PostalCode = '{BPostalCode.Text}' "           +
                  $"where BID = '{BID.Text}'";


                myCommand.ExecuteNonQuery();
                MessageBox.Show("Branch updated");
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
                myCommand.CommandText = "delete from Branch where BID = '" + BID.Text + "'";
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
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Branch deleted.");

                    BID.Text = "";
                    BDescription.Text = "";         
                    PhoneNumber.Text = "";            
                    BPostalCode.Text = "";
                    BStreet_Address1.Text = "";
                    BStreet_Address2.Text = "";
                    BCity.Text = "";
                    BProvince.Text = "";
  
                }

                else { return; }


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
                        BPhoneNumber.Text = myReader["PhoneNumber"].ToString();                        
                        BPostalCode.Text = myReader["PostalCode"].ToString();
                        BStreet_Address1.Text = myReader["Street_address1"].ToString();
                        BStreet_Address2.Text = myReader["Street_address2"].ToString();
                        BCity.Text = myReader["City"].ToString();
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
                        BPhoneNumber.Text = myReader["PhoneNumber"].ToString();
                        BPostalCode.Text = myReader["PostalCode"].ToString();
                        BStreet_Address1.Text = myReader["Street_address1"].ToString();
                        BStreet_Address2.Text = myReader["Street_address2"].ToString();
                        BCity.Text = myReader["City"].ToString();
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
                    BPhoneNumber.Text = myReader["PhoneNumber"].ToString();
                    BPostalCode.Text = myReader["PostalCode"].ToString();
                    BStreet_Address1.Text = myReader["Street_address1"].ToString();
                    BStreet_Address2.Text = myReader["Street_address2"].ToString();
                    BCity.Text = myReader["City"].ToString();
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
                    BPhoneNumber.Text = myReader["PhoneNumber"].ToString();
                    BPostalCode.Text = myReader["PostalCode"].ToString();
                    BStreet_Address1.Text = myReader["Street_address1"].ToString();
                    BStreet_Address2.Text = myReader["Street_address2"].ToString();
                    BCity.Text = myReader["City"].ToString();
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
    }
    
}
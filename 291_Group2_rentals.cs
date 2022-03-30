using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
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



           
            //----rentals pickup branch box--------------
            SqlDataAdapter pickup_branch_adapter = new SqlDataAdapter("Select BID, (Street_address1 + ', ' + City) AS Location FROM Branch", myConnection);
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
            DataTable dt1 = new DataTable();
            pickup_branch_adapter.Fill(dt1);

            DataRow row1 = dt1.NewRow();
            row1[0] = 0;
            row1[1] = "Please select";
            dt1.Rows.InsertAt(row1, 0);

            dropoffbranchBox.DataSource = dt1;
            dropoffbranchBox.DisplayMember = "Location";
            dropoffbranchBox.ValueMember = "BID";
            //--------------------------------------------

            //----rentals car Type box----------------
            SqlDataAdapter carType_adapter = new SqlDataAdapter("Select CarTypeID, Description FROM CarType", myConnection);
            DataTable car_type_table = new DataTable();
            carType_adapter.Fill(car_type_table);

            DataRow car_type_defalut = car_type_table.NewRow();
            car_type_defalut[0] = 0;
            car_type_defalut[1] = "Please Select";
            car_type_table.Rows.InsertAt(car_type_defalut, 0);

            CarTypeBox.DataSource = car_type_table;
            CarTypeBox.DisplayMember = "Description";
            CarTypeBox.ValueMember = "CarTypeID";
            //--------------------------------------
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

            MessageBox.Show(myCommand.CommandText);

            myCommand.ExecuteNonQuery();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Customers_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {   
                //calculate age
                DateTime dob = DateTime.Parse(DOB.Text);
                int age = DateTime.Now.Subtract(dob).Days / 365;

                //

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

                myCommand.CommandText = "insert into Customer (CID, Firstname, MiddleName, LastName, Phonenumber, DateofBirth, Street_address1, Street_address2, City, Province, PostalCode, Insurance,Membership) values " +
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
                    ")";

                MessageBox.Show(myCommand.CommandText);

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
            myCommand.CommandText = "insert into Car (VIN, Make, Model, Year, NumberofSeats, Color, InsuranceNumber, OdometerNumber, BID, CarType) values " +
                    "('" + VIN.Text + "'" +
                    ",'" + Make.Text + "'" +
                    ",'" + Model.Text + "'" +
                    "," + Year.Text +
                    "," + Seats.Text  +
                    ",'" + Color.Text + "'" +
                    ",'" + CInsurance.Text + "'" +
                    "," + Odometer.Text +
                    ",'" + CBID.Text + "'" +
                    ",'" + CCarType.Text + "'" +
                    ")";

            MessageBox.Show(myCommand.CommandText);

            myCommand.ExecuteNonQuery();
        }

        private void dropoffbranchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

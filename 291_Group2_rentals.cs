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

        private void pickupbranchBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //----rentals car Type box----------------
            using (SqlConnection sqlConnection = new SqlConnection("Server = BALKIRATS-SURFA; Database = 291_group2; Trusted_Connection = yes;"))
            {

                String selected_BID;
                selected_BID = pickupbranchBox.SelectedValue.ToString();
                int testing;

                if(int.TryParse(selected_BID, out testing))
                {
                    SqlDataAdapter carType_adapter = new SqlDataAdapter("SELECT T.CarTypeID, T.Description from CarType T, Car C WHERE C.CarType = T.CarTypeID and C.BID = " + selected_BID, sqlConnection);
                   
                
                    DataTable car_type_table = new DataTable();
                    carType_adapter.Fill(car_type_table);

                    DataRow car_type_defalut = car_type_table.NewRow();

                    car_type_defalut[0] = 0;
                    car_type_defalut[1] = "Please select";
                    car_type_table.Rows.InsertAt(car_type_defalut, 0);

                    CarTypeBox.DataSource = car_type_table;
                    CarTypeBox.DisplayMember = "Description";
                    CarTypeBox.ValueMember = "CarTypeID";

                    
                }
                
                
                //--------------------------------------
                
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
            displayddate.Text = dropoffDate.Value.ToString();
            displayddate.Visible = true;
            displaydtime.Text = (dropoffHour.Value.ToString() + ":" + dropoffMinute.Value.ToString() + " " + dropoffTimeAMPM.Text);
            displaydtime.Visible = true;

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

            float selected_daiy_rate = float.Parse(Daily_rate.Text.Replace("$",""));
            float selected_weekly_rate = float.Parse(weekly_rate.Text.Replace("$", ""));
            float selected_monthly_rate = float.Parse(monthly_rate.Text.Replace("$", ""));

            float f_price = ((float)months * selected_monthly_rate + (float)weeks * selected_weekly_rate + (float)days * selected_daiy_rate);
            float f_gst = (float)(f_price * 0.05);
            float f_total = (float)(f_price + f_gst);

            price.Text = "$" + (f_price).ToString(".00#");
            gst.Text = "$" + (f_gst).ToString(".00#");
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
            //----rentals car box----------------
            using (SqlConnection sqlConnection = new SqlConnection("Server = BALKIRATS-SURFA; Database = 291_group2; Trusted_Connection = yes;"))
            {

                String selected_CarType;
                selected_CarType = CarTypeBox.SelectedValue.ToString();
                
                int testing;

                if (int.TryParse(selected_CarType, out testing))
                {
                    SqlDataAdapter car_adapter = new SqlDataAdapter("SELECT VIN, (Make + ' ' + Model) as car_info from Car WHERE CarType = " + selected_CarType, sqlConnection);


                    DataTable car_table = new DataTable();
                    car_adapter.Fill(car_table);

                    DataRow car_defalut = car_table.NewRow();

                    car_defalut[0] = 0;
                    car_defalut[1] = "Please select";
                    car_table.Rows.InsertAt(car_defalut, 0);

                    available_car.DataSource = car_table;
                    available_car.DisplayMember = "car_info";
                    available_car.ValueMember = "VIN";

                    //--------display rates of selected car type-----------
                    string query = "SELECT DailyRate, WeeklyRate, MonthlyRate FROM CarType WHERE CarTypeID = " + selected_CarType;
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Daily_rate.Text = "$" + dr.GetString(0);
                        weekly_rate.Text = "$" + dr.GetString(1);
                        monthly_rate.Text = "$" + dr.GetString(2);
                    }
                }

            }
        }

        private void available_car_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

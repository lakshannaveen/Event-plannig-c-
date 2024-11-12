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

namespace Event_plannig
{
    public partial class CreateEvent : Form
    {
        private Guid eventID;

        public CreateEvent()
        {
            InitializeComponent();
            txtname.Text = "";
            startdatepicker.Value = DateTime.Now;
            enddatepicker.Value = DateTime.Now;
            txtstarttime.Text = "";
            txtendtime.Text = "";
            txtlocations.Text = "";
            txtdescription.Text = "";
            txtprice.Text = "";

            eventID = Guid.NewGuid();

        }


        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\techn\OneDrive\Desktop\Event plannig\Event plannig\Database1.mdf'; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            //alert box for createeventbutton when user input data



            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(startdatepicker.Text) || string.IsNullOrEmpty(enddatepicker.Text) || string.IsNullOrEmpty(txtstarttime.Text)
               || string.IsNullOrEmpty(txtendtime.Text) || string.IsNullOrEmpty(txtlocations.Text) || string.IsNullOrEmpty(txtdescription.Text) || string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Please Enter All Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();



                    string insertQuery = "INSERT INTO Events (EventID, Name, StartDate, EndDate, StartTime, EndTime, Location, Description, Price) VALUES (@EventID, @Name, @StartDate, @EndDate, @StartTime, @EndTime, @Location, @Description, @Price)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);


                    Guid eventID = Guid.NewGuid();
                    command.Parameters.AddWithValue("@EventID", eventID);
                    command.Parameters.AddWithValue("@Name", txtname.Text);
                    command.Parameters.AddWithValue("@StartDate", startdatepicker.Value);
                    command.Parameters.AddWithValue("@EndDate", enddatepicker.Value);
                    command.Parameters.AddWithValue("@StartTime", txtstarttime.Text);
                    command.Parameters.AddWithValue("@EndTime", txtendtime.Text);
                    command.Parameters.AddWithValue("@Location", txtlocations.Text);
                    command.Parameters.AddWithValue("@Description", txtdescription.Text);
                    command.Parameters.AddWithValue("@Price", txtprice.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                // store current data as previous data 
                string data1 = txtname.Text;
                DateTime datetime1 = startdatepicker.Value;
                DateTime datetime2 = enddatepicker.Value;
                string data2 = txtstarttime.Text;
                string data3 = txtendtime.Text;
                string data4 = txtlocations.Text;
                string data5 = txtdescription.Text;
                string data6 = txtprice.Text;

                
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resetbutton reset textboxes and datetimepickers
            txtname.Text = "";
            startdatepicker.Value = DateTime.Now;
            enddatepicker.Value = DateTime.Now;
            txtstarttime.Text = "";
            txtendtime.Text = "";
            txtlocations.Text = "";
            txtdescription.Text = "";
            txtprice.Text = "";
        }

       

        private void butdeletupdate_Click(object sender, EventArgs e)
        {
            //autofill data to details
            string data1=txtname.Text;
            DateTime datetime1 = startdatepicker.Value;
            DateTime datetime2 = enddatepicker.Value;
            string data2 = txtstarttime.Text;
            string data3 = txtendtime.Text;
            string data4 = txtlocations.Text;
            string data5 = txtdescription.Text;
            string data6 = txtprice.Text;

      


            //clear  textboxes data when entered all data 
            txtname.Text = "";
            startdatepicker.Value = DateTime.Now;
            enddatepicker.Value = DateTime.Now;
            txtstarttime.Text = "";
            txtendtime.Text = "";
            txtlocations.Text = "";
            txtdescription.Text = "";
            txtprice.Text = "";

            // details form instantiate

            details Ddetails = new details(data1,datetime1,datetime2,data2,data3,data4,data5,data6,eventID);

            //show the detail form 
            Ddetails.Show();
           
           



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}

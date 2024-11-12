using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_plannig
{
    
    public partial class details : Form


    {
        public event EventHandler DataModified;
        private Guid eventID;
       





        public details(Guid eventID)
        {
            InitializeComponent();
            
           
            this.eventID = eventID;
           



        }
        public void PopulateEventData()
        {
            // Fetch the event details from the database using eventID
            // Open SQL connection
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\techn\OneDrive\Desktop\Event plannig\Event plannig\Database1.mdf"";Integrated Security=True"))
            {
                string selectQuery = "SELECT * FROM Events WHERE EventID = @EventID";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@EventID", eventID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the textboxes with event details
                        txtname.Text = reader["Name"].ToString();
                        startdatepicker.Value = Convert.ToDateTime(reader["StartDate"]);
                        enddatepicker.Value = Convert.ToDateTime(reader["EndDate"]);
                        txtstarttime.Text = reader["StartTime"].ToString();
                        txtendtime.Text = reader["EndTime"].ToString();
                        txtlocations.Text = reader["Location"].ToString();
                        txtdescription.Text = reader["Description"].ToString();
                        txtprice.Text = reader["Price"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\techn\OneDrive\Desktop\Event plannig\Event plannig\Database1.mdf"";Integrated Security=True");
        private void butupdate_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(startdatepicker.Text) || string.IsNullOrEmpty(enddatepicker.Text) || string.IsNullOrEmpty(txtstarttime.Text)
              || string.IsNullOrEmpty(txtendtime.Text) || string.IsNullOrEmpty(txtlocations.Text) || string.IsNullOrEmpty(txtdescription.Text) || string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Please Enter All Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the update action
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Events SET Name = @Name, StartDate = @StartDate, EndDate = @EndDate, StartTime = @StartTime, EndTime = @EndTime, Location = @Location, Description = @Description, Price = @Price WHERE EventID = @EventID";
                        SqlCommand command = new SqlCommand(updateQuery, connection);
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

                        MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnDataModified();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Close();
                    }
                    







                }

                   
            }
          
           


        }

        private void butdelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(startdatepicker.Text) || string.IsNullOrEmpty(enddatepicker.Text) || string.IsNullOrEmpty(txtstarttime.Text)
              || string.IsNullOrEmpty(txtendtime.Text) || string.IsNullOrEmpty(txtlocations.Text) || string.IsNullOrEmpty(txtdescription.Text) || string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Please Enter All Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the delete action
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Events WHERE EventID = @EventID";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@EventID", eventID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnDataModified();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Close();
                    }


                    //delete data on textboxes
                    txtname.Text = "";
                    startdatepicker.Value = DateTime.Now;
                    enddatepicker.Value = DateTime.Now;
                    txtstarttime.Text = "";
                    txtendtime.Text = "";
                    txtlocations.Text = "";
                    txtdescription.Text = "";
                    txtprice.Text = "";

                }
               
                
            }
    
            


        }
        protected virtual void OnDataModified()
        {
            DataModified?.Invoke(this, EventArgs.Empty); // Raise the DataModified event
        }

        private void butback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close without saving changes?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {  

                 
                this.Close();

                Status Dstatus = new Status();
                Dstatus.Show();
              



            }
        }
    }
}

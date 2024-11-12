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
        private Guid eventID;



        public details(string data1, DateTime datetime1, DateTime datetime2,string data2,string data3, string data4, string data5,string data6,Guid eventID)
        {
            InitializeComponent();
            txtname.Text = data1;
            startdatepicker.Value = datetime1;
            enddatepicker.Value = datetime2;
            txtstarttime.Text = data2;
            txtendtime.Text = data3;
            txtlocations.Text = data4;
            txtdescription.Text = data5;
            txtprice.Text = data6;
            this.eventID = eventID;

        }
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\techn\OneDrive\Desktop\Event plannig\Event plannig\Database1.mdf'; Integrated Security = True");


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
                        this.Close();





                    }
                    
                      catch (Exception ex)
                    {
                      MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                           connection.Close();
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
                        command.Parameters.AddWithValue("@EventID", eventID); // Assuming you have eventID available here

                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
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
                this.Close();
                
            }
            
           
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

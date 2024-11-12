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
    public partial class Status : Form
    {
        private Guid eventID;
        public Status()
        {
            InitializeComponent();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        { // Load data into the DataGridView
            this.eventsTableAdapter.Fill(this.database1DataSet.Events);

            // Add a button column for Update/Delete actions
            DataGridViewButtonColumn updateDeleteButtonColumn = new DataGridViewButtonColumn();
            updateDeleteButtonColumn.HeaderText = "Action";
            updateDeleteButtonColumn.Text = "Update/Delete";
            updateDeleteButtonColumn.UseColumnTextForButtonValue = true;
            datagrideviewevents.Columns.Add(updateDeleteButtonColumn);
            

        }


        private void butback_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }


        private void datagrideviewevents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && datagrideviewevents.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Get the selected event ID
                Guid eventID = (Guid)datagrideviewevents.Rows[e.RowIndex].Cells["EventID"].Value;

                // Open the details form with the selected event ID
                details detailsForm = new details(eventID);
                this.Close();

                // Populate the textboxes with event details
                detailsForm.PopulateEventData();

                detailsForm.DataModified += detailsForm_DataModified; // Subscribe to the DataModified event
                detailsForm.ShowDialog();
            }
        }
        private void UpdateDataGridView(Guid eventID)
        {
            // Reload data into the DataGridView
            this.eventsTableAdapter.Fill(this.database1DataSet.Events);

            // Select the row with the specified eventID
            foreach (DataGridViewRow row in datagrideviewevents.Rows)
            {
                if (row.Cells["EventID"].Value != null && (Guid)row.Cells["EventID"].Value == eventID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void detailsForm_DataModified(object sender, EventArgs e)
        {
                // When the DataModified event is raised by the details form,
                // update the DataGridView in the Status form
                UpdateDataGridView(eventID);
            }
    }
}

    

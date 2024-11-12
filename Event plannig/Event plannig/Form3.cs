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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.database1DataSet.Events);

        }
    }
}

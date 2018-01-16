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

namespace WindowsAppGridView
{
    public partial class EmployeeManagerForm : Form
    {
        public EmployeeManagerForm()
        {
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //read the values from the UI
            string personId = textBoxPersonId.Text;
            string title = textBoxTitle.Text;
            //update the personId and Tilte in database
            //Database connect
            string AdventureDatabaseConnectionstring = "Data Source=.;Initial Catalog=AdventureWorks2016CTP3;Integrated Security=True";
            //ado.net
            SqlConnection _adventureSqlConnection = new SqlConnection
            {
                ConnectionString = AdventureDatabaseConnectionstring
            };
            //Connection Open
            _adventureSqlConnection.Open();

            //build the command
            SqlCommand _adventureSqlCommand = new SqlCommand
            {
                Connection = _adventureSqlConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = @"[dbo].[Usp_UpdatePersonDetails]"
            };

            _adventureSqlCommand.Parameters.AddWithValue("@PersonId", personId);
            _adventureSqlCommand.Parameters.AddWithValue("@Title", title);

            int rowsaffected = _adventureSqlCommand.ExecuteNonQuery();

            if (rowsaffected > 0)
                MessageBox.Show("Record Updated Successfully");
            else
                MessageBox.Show("Record not Updated: ");

        }

        private void ButtonView_Click(object sender, EventArgs e)
        {

        }
    }
}

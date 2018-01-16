using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsAppGridView
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonView_Click(object sender, System.EventArgs e)
        {
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
                CommandType=System.Data.CommandType.StoredProcedure,
                CommandText = @"[dbo].[Usp_GetSalesPersonDetails]"
            };

            //excute
            SqlDataReader results= _adventureSqlCommand.ExecuteReader();

            List<SalesData> salesResults = new List<SalesData>();
            while(results.Read())
            {
                SalesData salesdata = new SalesData
                {
                    BusinessEntityID = results.IsDBNull(0) ? "Null Data" : results["BusinessEntityID"].ToString(),
                    TerritoryID = results.IsDBNull(1) ? "Null Data" : results["TerritoryID"].ToString(),
                    SalesQuota = results.IsDBNull(2) ? "Null Data" : results["SalesQuota"].ToString(),
                    Bonus = results.IsDBNull(3) ? "Null Data" : results["Bonus"].ToString(),
                    CommissionPct = results.IsDBNull(4) ? "Null Data" : results["CommissionPct"].ToString(),
                    SalesYTD = results.IsDBNull(5) ? "Null Data" : results["SalesYTD"].ToString()
                };
                salesResults.Add(salesdata);
            }
            employeedataGridView.DataSource = salesResults;
        }

        private void ButtonUpdatePerson_Click(object sender, System.EventArgs e)
        {
            EmployeeManagerForm instance = new EmployeeManagerForm();
            instance.Show();
        }
    }
}

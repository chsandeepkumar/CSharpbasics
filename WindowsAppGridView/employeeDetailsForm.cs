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
            SqlConnection _adventureSqlConnection = new SqlConnection();
            _adventureSqlConnection.ConnectionString = AdventureDatabaseConnectionstring;
            //Connection Open
            _adventureSqlConnection.Open();
          
            //build the command
            SqlCommand _adventureSqlCommand = new SqlCommand();
            _adventureSqlCommand.Connection = _adventureSqlConnection;
            _adventureSqlCommand.CommandText= @"SELECT * FROM Sales.SalesPerson";

            //excute
           SqlDataReader results= _adventureSqlCommand.ExecuteReader();
            List<SalesData> salesResults = new List<SalesData>();
            while(results.Read())
            {
                SalesData salesdata = new SalesData();
                salesdata.BusinessEntityID = results.IsDBNull(0) ? "Null Data" : results["BusinessEntityID"].ToString();
                salesdata.TerritoryID = results.IsDBNull(1) ? "Null Data" : results["TerritoryID"].ToString();
                salesdata.SalesQuota = results.IsDBNull(2) ? "Null Data" : results["SalesQuota"].ToString();
                salesdata.Bonus = results.IsDBNull(3) ? "Null Data" : results["Bonus"].ToString();
                salesdata.CommissionPct = results.IsDBNull(4) ? "Null Data" : results["CommissionPct"].ToString();
                salesdata.SalesYTD = results.IsDBNull(5) ? "Null Data" : results["SalesYTD"].ToString();
                salesResults.Add(salesdata);
            }
            employeedataGridView.DataSource = salesResults;
            
        }
    }
}

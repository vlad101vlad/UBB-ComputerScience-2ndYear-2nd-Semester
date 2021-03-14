using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab1.Repository
{
    public class CityRepository
    {
        public string ConnectionString = "Data Source = VLADPC-S; Initial Catalog = JobTree; Integrated Security=True";
        SqlConnection databaseConnection = new SqlConnection();
     

        //private DataTable cities;
        private DataSet cities;

        public CityRepository()
        {
            cities = new DataSet();
        }

        private void openDatabaseConnection()
        {
            databaseConnection.ConnectionString = ConnectionString;
            if (ConnectionState.Closed == databaseConnection.State)
                databaseConnection.Open();
        }

        private void readData(int countyID)
        {
            openDatabaseConnection();

            String queryString = "SELECT * FROM City WHERE CountyID = @CountyID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection);
            selectCommand.Parameters.AddWithValue("@CountyID", countyID);

            //SqlDataAdapter adapter = new SqlDataAdapter(queryString, ConnectionString);
            adapter.SelectCommand = selectCommand;

            adapter.Fill(cities, "City");
        }

        public DataTable getCitiesDataTable(int countyID)
        {
            cities = new DataSet();
            readData(countyID);

            return cities.Tables["City"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Lab1.Domain;

namespace Lab1.Repository
{
    public class CityRepository
    {
        public string ConnectionString = "Data Source = VLADPC-S; Initial Catalog = JobTree; Integrated Security=True";
        SqlConnection databaseConnection = new SqlConnection();
        SqlDataAdapter adapter;


        //private DataTable cities;
        private DataSet cities;

        public CityRepository()
        {
            databaseConnection.ConnectionString = ConnectionString;
            cities = new DataSet();
            adapter = new SqlDataAdapter();
            setAdapterInsertCommand();
        }

        private void openDatabaseConnection()
        {
            if (ConnectionState.Closed == databaseConnection.State)
                databaseConnection.Open();
        }

        private void setAdapterInsertCommand()
        {
            adapter.InsertCommand = new SqlCommand("procedure_InsertCity", databaseConnection);
            SqlCommand insertCommand = adapter.InsertCommand;
            insertCommand.CommandType = CommandType.StoredProcedure;

            insertCommand.Parameters.Add(new SqlParameter("@CityID", SqlDbType.Int));
            insertCommand.Parameters["@CityID"].Direction = ParameterDirection.Output;
            insertCommand.Parameters["@CityID"].SourceColumn = "ID";

            insertCommand.Parameters.Add(new SqlParameter("@CityName",
                                         SqlDbType.VarChar, 50, "Name"));

            insertCommand.Parameters.Add(new SqlParameter("@CountyID",
                                         SqlDbType.Int,10, "CountyID"));
        }

        public void addNewCity(City newCity)
        {
            openDatabaseConnection();

            var newCityRow = cities.Tables["City"].NewRow();
            newCityRow["Name"] = newCity.getName();
            newCityRow["CountyID"] = newCity.getCountryID();
            cities.Tables["City"].Rows.Add(newCityRow);

            adapter.Update(cities, "City");
        }

        private void readData(int countyID)
        {
            openDatabaseConnection();

            String queryString = "SELECT * FROM City WHERE CountyID = @CountyID";            

            SqlCommand selectCommand = new SqlCommand(queryString, databaseConnection);
            selectCommand.Parameters.AddWithValue("@CountyID", countyID);

            adapter.SelectCommand = selectCommand;

            adapter.Fill(cities, "City");
        }

        public DataTable getCitiesDataTable(int countyID)
        {
            readData(countyID);

            return cities.Tables["City"];
        }
    }
}

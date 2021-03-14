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

        private void setAdapterDeleteCommand(int cityID)
        {
            String deleteString = "DELETE FROM City WHERE ID = @CityID";            
            adapter.DeleteCommand = new SqlCommand(deleteString, databaseConnection);

            SqlCommand deleteCommand = adapter.DeleteCommand;
            deleteCommand.Parameters.AddWithValue("@CityID", cityID);
            //deleteCommand.Parameters.Add(new SqlParameter("@CityID", SqlDbType.Int));
            
        }

        private void setAdapterUpdateCommand(City toBeUpdated)
        {
            String updateString = "UPDATE City SET Name = @CityName WHERE ID = @CityID";
            adapter.UpdateCommand = new SqlCommand(updateString, databaseConnection);

            SqlCommand updateCommand = adapter.UpdateCommand;
            updateCommand.Parameters.AddWithValue("@CityID", toBeUpdated.getID());
            updateCommand.Parameters.AddWithValue("@CityName", toBeUpdated.getName());
        }

        public void addNewCity(City newCity)
        {
            openDatabaseConnection();

            var newCityRow = cities.Tables["City"].NewRow();
            newCityRow["ID"] = newCity.getID();
            newCityRow["Name"] = newCity.getName();
            newCityRow["CountyID"] = newCity.getCountryID();
            cities.Tables["City"].Rows.Add(newCityRow);

            adapter.Update(cities, "City");
        }

        public void updateCity(City updatedCity)
        {
            openDatabaseConnection();

            setAdapterUpdateCommand(updatedCity);
            DataRow updatedRow = cities.Tables["City"].Rows.Find(updatedCity.getID());
            updatedRow["Name"] = updatedCity.getName();

            adapter.Update(cities, "City");
        }

        private void setCityDatasetPrimaryKey()
        {
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = cities.Tables["City"].Columns["ID"];
            cities.Tables["City"].PrimaryKey = keyColumns;
        }

        public void deleteCity(int cityID)
        {
            openDatabaseConnection();

            setAdapterDeleteCommand(cityID);
            cities.Tables["City"].Rows.Find(cityID).Delete();

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
            setCityDatasetPrimaryKey();
            return cities.Tables["City"];
        }
    }
}

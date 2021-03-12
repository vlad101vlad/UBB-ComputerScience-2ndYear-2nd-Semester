using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab1.Repository
{
    public class CountyRepository
    {
        public string ConnectionString = "Data Source = VLADPC-S; Initial Catalog = JobTree; Integrated Security=True";
        SqlConnection databaseConnection = new SqlConnection();

        private DataTable counties;

        private void openDatabaseConnection()
        {
            databaseConnection.ConnectionString = ConnectionString;
            if (ConnectionState.Closed == databaseConnection.State)
                databaseConnection.Open();
        }

        public CountyRepository()
        {
            counties = new DataTable();
            readCounties();
        }

        public DataTable getCounties()
        {
            return counties;
        }

        void readCounties()
        {
            openDatabaseConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM County", databaseConnection);

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                counties.Load(reader);
                Console.WriteLine("Succesfully loaded counties");
            }
            catch
            {
                throw;
            }
            
        }
    }
}

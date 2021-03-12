﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab1.Repository
{
    class CityRepository
    {
        public string ConnectionString = "Data Source = VLADPC-S; Initial Catalog = JobTree; Integrated Security=True";
        SqlConnection databaseConnection = new SqlConnection();
     

        private DataTable cities;

        public CityRepository()
        {
        }

        private void openDatabaseConnection()
        {
            databaseConnection.ConnectionString = ConnectionString;
            if (ConnectionState.Closed == databaseConnection.State)
                databaseConnection.Open();
        }

        private void readData()
        {
            openDatabaseConnection();
        }
    }
}

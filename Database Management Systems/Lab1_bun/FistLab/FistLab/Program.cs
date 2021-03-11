using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//Connection, Command, DataReader, DataAdapter



namespace FistLab
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConnection = new SqlConnection();
            dbConnection.ConnectionString = "Data Source = VLADPC-S;" + "Initial Catalog = JobTree; Integrated Security = true;";

            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM City", dbConnection);
            dataAdapter.Fill(dataSet, "City");

            


            DataRow newRow = dataSet.Tables["City"].NewRow();
            newRow["ID"] = 69;
            newRow["Name"] = "vlad";
            newRow["CountyID"] = 1;
            dataSet.Tables["City"].Rows.Add(newRow);


            Console.WriteLine("Before deleting");
            foreach (DataRow dataRow in dataSet.Tables["City"].Rows)
                Console.WriteLine("{0}, {1}", dataRow["ID"], dataRow["Name"]);



            dbConnection.Open();
            SqlCommand deleteTheNewRow = new SqlCommand("DELETE FROM City WHERE ID = '69'", dbConnection);
            deleteTheNewRow.ExecuteNonQuery();

            


            Console.WriteLine("After deleting");
            foreach (DataRow dataRow in dataSet.Tables["City"].Rows)
                Console.WriteLine("{0}, {1}", dataRow["ID"], dataRow["Name"]);

            //dbConnection.Open();
            //Console.WriteLine("it's okay");
            //dbConnection.Close();
            Console.ReadLine();
        }
    }
}

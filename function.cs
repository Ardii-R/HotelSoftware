using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelSoftware
{
    internal class function
    {
        private string connectionString = "data source=.;database=test;integrated security =True";
        private static bool databaseConnection = false;

        private bool result = false;


        public SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source=.;database=test;integrated security =True; Timeout=2";
          
            //MessageBox.Show("TimeOut: " + sqlConnection.ConnectionTimeout.ToString());

            try
            {
                
                sqlConnection.Open();
                databaseConnection = true;
                return sqlConnection;
            }
            catch (Exception ex) 
            {
                databaseConnection = false;
            }
            return sqlConnection;
        }


        public DataSet getData(string query) 
        {
    

            if (databaseConnection)
            {
                SqlConnection sqlConnection = getConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = query;
                //sqlCommand.CommandTimeout = 4;

                //sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
            else
            {
                return null;
            }
        }


        public void setData(string query, string message)
        {
            if (databaseConnection)
            {
                SqlConnection sqlConnection = getConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();


                MessageBox.Show(message);

            }
        }


        

        public SqlDataReader getDataReader(string query)
        {
            if (databaseConnection)
            {
                SqlConnection connection = getConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                //sqlCommand.CommandTimeout = 4;
                //connection.Open();
                sqlCommand = new SqlCommand(query, connection);
                SqlDataReader sdr = sqlCommand.ExecuteReader();

                return sdr;
            }
            else
            {
                return null;
            }
  
        }
        



        public bool getDatabaseConnection()
        {
            return databaseConnection;
        }



    }
}

 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS.DataAccessObject
{
    internal class CustomerDatabaseManager : ICustomerDatabase
    {
        private static CustomerDatabaseManager customerCustomer;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        private readonly OracleConnection databaseConnection;

        private CustomerDatabaseManager() 
        {
            databaseConnection = new OracleConnection(connectionString);
        }

        public static CustomerDatabaseManager CustomerDatabaseInstance()
        {
            

            if (customerCustomer == null)
            {
                customerCustomer = new CustomerDatabaseManager();
            }
            return customerCustomer;
   
        }
        public int GetNextCustomerID()
        {
            int customerNextID;

            string sqlQuery = "SELECT MAX(CustomerID) FROM Customers";


            OracleCommand cmd = new OracleCommand(sqlQuery, databaseConnection);

            OpenConnection();

            OracleDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();

            if (dataReader.IsDBNull(0))
            { 
                customerNextID = 1;
            }
            else
            {
                customerNextID = dataReader.GetInt32(0) + 1;
            }

            CloseConnection();

            return customerNextID;
        }
        
        public void CreateCustomerAccount(string sqlQuery)
        {
            
            OracleCommand cmd = new OracleCommand(sqlQuery, databaseConnection);

            cmd.ExecuteNonQuery();

            CloseConnection();

        }

        public bool VerifyManagerID(int managerID)
        {
            string sqlQuery = "SELECT ManagerID FROM Managers WHERE ManagerID = " + managerID;

            OracleCommand cmd = new OracleCommand(sqlQuery, databaseConnection);

            OpenConnection();

            OracleDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataSet FindCustomerAccount(int custID)
        {
            string sqlQuery = "SELECT CustomerID, Name, Address, Town, Country, Zipcode, Email, Telno FROM Customers" +
                " WHERE CustomerID = " + custID + " AND Status = 'O' ";

            OracleCommand cmd = new OracleCommand(sqlQuery, databaseConnection);

            OpenConnection();

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "Customers");

            CloseConnection();

            return dataSet;
        }

        //Verify the the existance of customer account in closing.
        public Boolean  IsValidCustomerID(int custID)
        {
            string sqlQuery = "SELECT CustomerID FROM Customers WHERE CustomerID = " + custID + " AND Status = 'O' ";

            OracleCommand cmd = new OracleCommand( sqlQuery, databaseConnection);

            OpenConnection();

            OracleDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean CloseCustomerAccount(int custID)
        {
            string sqlQuery = "UPDATE Customers SET Status = 'C' WHERE CustomerId = " + custID;

            OracleCommand cmd = new OracleCommand(sqlQuery, databaseConnection);

            OpenConnection();

            OracleDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenConnection()
        {
            databaseConnection.Open();
        }
        public void CloseConnection()
        {
             databaseConnection.Close();
        }
    }
}

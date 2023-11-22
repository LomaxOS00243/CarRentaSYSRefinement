 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS.DataAccessObject
{
    internal class CustomerRepository
    {
        private static CustomerRepository _clientRepository;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        private readonly OracleConnection _databaseConnection;

        private CustomerRepository() 
        {
            _databaseConnection = new OracleConnection(_connectionString);
        }

        public static CustomerRepository ClientRepositoryInstance()
        {
            

            if (_clientRepository == null)
            {
                 _clientRepository = new CustomerRepository();
            }
            return _clientRepository;
   
        }
        public int NextClientId()
        {
            int customerNextID;

            String sqlQuery = "SELECT MAX(clientId) FROM Clients";


            OracleCommand cmd = new OracleCommand(sqlQuery, _databaseConnection);

            OpenConnection();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                customerNextID = 1;
            }
            else
            {
                customerNextID = dr.GetInt32(0) + 1;
            }

            CloseConnection();

            return customerNextID;
        }

        public void OpenConnection()
        {
            _databaseConnection.Open();
        }
        public void CloseConnection()
        {
            _databaseConnection.Close();
        }
    }
}

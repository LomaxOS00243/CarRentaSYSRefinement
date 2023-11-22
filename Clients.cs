using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS
{
    class Clients
    {

        private int clientId;
        private String name;
        private String address;
        private String town;
        private String country;
        private String zipCode;
        private String email;
        private String telNo;
        private char status;

        public Clients()
        {
            this.clientId =0;
            this.name = " ";
            this.address = " ";
            this.town = " ";
            this.country = " ";
            this.zipCode = " ";
            this.email = " ";
            this.telNo = " ";
            this.status = ' ';
        }
            

        public Clients(int clientId, string name, string address, string town, string country, string zipCode, string email, String telNo, char status)
        {
            this.clientId = clientId;
            this.name = name;
            this.address = address;
            this.town = town;
            this.country = country;
            this.zipCode = zipCode;
            this.email = email;
            this.telNo = telNo;
            this.status = status;
        }
        public void setClientId(int clientID)
        {
            clientId = clientID;
        }
        public int getClientId()
        {
            return clientId;
        }
        public void setName(String names)
        {
            name = names;
        }
        public String getName()
        {
            return name;
        }
        public void setAddress(String addr)
        {
            address = addr;
        }
        public String getAddress()
        {
            return address;
        }
        public void setTown(String towns)
        {
            town = towns;
        }
        public String getTown()
        {
            return town;
        }
        public void setZipCode(String zipcode)
        {
            zipCode= zipcode;
        }
        public String getZipCode()
        {
            return zipCode;
        }
        public void setEmail(String emails)
        {
            email = emails;
        }
        public String getEmail()
        {
            return email;
        }
        public void setTelNo(String telno)
        {
            telNo= telno;
        }
        public String getTelNo()
        {
            return telNo;
        }
        public void setStatus(char clientStatus)
        {
            status = clientStatus;
        }
        public char getStatus()
        {
            return status;
        }
        public static int getNextClientId()
        {
            int clientNextId;

            //Connect to DB;

            OracleConnection con= new OracleConnection(DBConnect.oradb);

            //Define SQL query (MAX() func);
            String sqlQuery = "SELECT MAX(clientId) FROM Clients";


            //Execute SQL query (OracleCommand);
            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Check if Max value is null or not;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                clientNextId = 1;
            }
            else
            {
                clientNextId = dr.GetInt32(0) + 1;
            }
          
            //close connection;
            con.Close();

            //return a value to C# app;
            return clientNextId;
        }
        public void addClient()
        {
            //Open Connection;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Clients VALUES(" +
                this.clientId + ",'" +
                this.name + "','" +
                this.address + "','" +
                this.town+ "','" +
                this.country + "','" +
                this.zipCode + "','" +
                this.email + "','"+
                this.telNo + "','"+
                this.status+ "')";

            //Execute the SQL query  (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();

        }
        public static DataSet findClient(int clientID)
        {
          
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define the SQL query to be executed
            String sqlQuery = "SELECT ClientId, Name, Address, Town, Country, Zipcode, Email, Telno FROM CLients" +
                " WHERE ClientId = " + clientID + " AND Status = 'O' ";

            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Client");

            //Close connection
            conn.Close();

            return ds;
        }
        public static Boolean isValidCliendID(int clientId)
        {
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT ClientId FROM Clients WHERE ClientId = " + clientId+ " AND Status = 'O' ";


            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if clientId exist in the database
            OracleDataReader dr = cmd.ExecuteReader();

            

            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }
        public static Boolean closeClient(int clientId)
        {
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "UPDATE Clients SET Status = 'C' WHERE ClientId = " + clientId;


            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if clientId exist in the database
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}

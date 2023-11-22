using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS
{
    class Type
    {
        String typeCode;
        String meaning;
        double cost;

        public Type(string typeCode, string meaning, double cost)
        {
            this.typeCode = typeCode;
            this.meaning = meaning;
            this.cost = cost;
        }
        public void setTypeCode(String types)
        {
            typeCode = types;
        }
        public String getTypeCode()
        {
            return typeCode;
        }
        public void setMeaning(String meanings)
        {
            meaning = meanings;
        }
        public String getMeaning()
        {
            return meaning;
        }
        public void setCost(double rate)
        {
            cost = rate;
        }
        public double getCost()
        {
            return cost;
        }


        public static DataSet getTypes()
        {
            //Open DB Connection;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL query to be executed;

            String sqlQuery = "SELECT * FROM CarTypes ORDER BY typeCode";


            //execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            odr.Fill(ds, "types");


            //Close connection;
            conn.Close();

            return ds;


        }
        public static double getCost(String carType)
        {
            double cost=0.00;

            //Connect to DB;

            OracleConnection con = new OracleConnection(DBConnect.oradb);


            //Define SQL query (MAX() func);

            String sqlQuery = "SELECT cost FROM carTypes WHERE typeCode = '"+carType+"'";


            //Execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Check if Max value is null or not;
            

            if (dr.Read())
            {
                cost = dr.GetDouble(0);
            }
            

            //close connection;
            con.Close();

            //return a value to C# app;
            return cost;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS
{
    class Invoices
    {
        private int invoiceNo;
        private int clientId;
        private String invoiceDate;
        private double total;

        public Invoices()
        {
            this.invoiceNo = 0;
            this.clientId = 0;
            this.invoiceDate = " ";
            this.total = 0.00;
        }
        public Invoices(int invoiceNo, int clientId,string invoiceDate, double total)
        {
            this.invoiceNo = invoiceNo;
            this.clientId = clientId;
            this.invoiceDate = invoiceDate;
            this.total = total;
        }
        public void setInvoiceNo(int invoiceId)
        {
            invoiceNo = invoiceId;
        }
        public int getInvoiceNo()
        {
            return invoiceNo;
        }

        public void setClientId(int clientid)
        {
            clientId = clientid;
        }
        public int getClientId()
        {
            return clientId;
        }
        
        public void setInvoiceDate(String invoiceD)
        {
            invoiceDate = invoiceD;
        }
        public String getInvoiceDate()
        {
            return invoiceDate;
        }
        public void setTotal(double totaldue)
        {
            total = totaldue;
        }
        public double getTotal()
        {
            return total;
        }
        public static int getNextInvoiceNo()
        {
            int nextInvoiceNo;

            //Connect to DB;

            OracleConnection con = new OracleConnection(DBConnect.oradb);


            //Define SQL query (MAX() func);

            String sqlQuery = "SELECT MAX(InvoiceNo) FROM Invoices";


            //Execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Check if Max value is null or not;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextInvoiceNo = 1;
            }
            else
            {
                nextInvoiceNo = dr.GetInt32(0) + 1;
            }

            //close connection;

            con.Close();
            //return a value to C# app;
            return nextInvoiceNo;
        }
        public void addInvoices()
        {
            //Open Connection;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Invoices VALUES(" +
                this.invoiceNo + "," +
                this.clientId + ",'" +
                this.invoiceDate + "'," +
                this.total + ")";

            //Execute the SQL query  (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();

        }
        //Check if it's the face day of the month
        public static Boolean runInvoiceForm()
        {
            DateTime day = DateTime.Now;

            if(day.Day != 19)
            {
                return false;
            }
            return true;
        }
        public static string getClientEmails(int clientId)
        {
            string email;
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT DISTINCT Email FROM Clients WHERE ClientId =" + clientId;


            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if RegistrationNo exists in the database
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.HasRows)
            {
                email = dr.GetString(0);
            }
            else
            {
                email = null;
            }


            //close connection;
            conn.Close();

            return email;


        }
        public static DataSet getInvoicesDetails(int clientId)
        {

            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT InvoiceNo, ClientId, InvoiceDate, Total " +
                "FROM Invoices " +
                "WHERE ClientId = "+clientId;


            //execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            odr.Fill(ds, "invDetails");


            //Close connection;
            conn.Close();

            return ds;

        }
        public static DataTable getYearlyRevenue(String year)
        {

            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            
            // //Define the SQL query to be executed
            String sqlQuery = "SELECT to_Char(InvoiceDate, 'MM') AS MONTH, SUM(Total) AS TOTAL " +
                "FROM Invoices " +
                "WHERE InvoiceDate LIKE '%"+year+"' " +
                "GROUP BY to_Char(InvoiceDate, 'MM') " +
                "ORDER BY MONTH";


            //execute SQL query (OracleCommand);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odA = new OracleDataAdapter(cmd);

            
            DataTable dt = new DataTable();

            odA.Fill(dt);


            //Close connection;
            conn.Close();

            return dt;

        }
        //return the month as string
        public static String getMonthAsString(int month)
        {
            switch (month)
            {
                
                case 01:
                    {
                        return "JANUARY";
                    }

                case 02:
                    {
                        return "FEBRUARY";
                    }
                case 03:
                    {
                        return "MARCH";
                    }
                case 04:
                    {
                        return "APRIL";
                    }
                case 05:
                    {
                        return "MAY";
                    }
                case 06:
                    {
                        return "JUNE";
                    }
                case 07:
                    {
                        return "JULY";
                    }
                case 08:
                    {
                        return "AUGUST";
                    }
                case 09:
                    {
                        return "SEPTEMBER";
                    }
                case 10:
                    {
                        return "OCTOBER";
                    }
                case 11:
                    {
                        return "NOVEMBER";
                    }
                case 12:
                    {
                        return "DECEMBER";
                    }
                default: return "Not Month Selected";

            }
            

        }

    }
}

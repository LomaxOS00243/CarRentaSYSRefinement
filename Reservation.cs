using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace CarRentaSYS
{
    class Reservation
    {
        private int reservationNo;
        private int clientId;
        private String registrationNo;
        private String collectDate;
        private String returnDate;
        private double cost;
        private double fine;
        private char status;

        public Reservation()
        {
            this.reservationNo = 0;
            this.clientId = 0;
            this.registrationNo = "";
            this.collectDate = "";
            this.returnDate = "";
            this.cost = 0.00;
            this.fine = 0.00;
            this.status = ' ';
        }
        public Reservation(int reservationNo, string collectDate, string returnDate, double cost, double fine, char status, String registrationNo, int clientId)
        {
            this.reservationNo = reservationNo;
            this.collectDate = collectDate;
            this.returnDate = returnDate;
            this.cost = cost;
            this.fine = fine;
            this.status = status;
            this.registrationNo = registrationNo;
            this.clientId = clientId;
        }
        public void setReservationNo(int reservationId)
        {
            reservationNo = reservationId;
        }
        public int getReservationNo()
        {
            return reservationNo;
        }
        
        public void setCollectDate(String collect)
        {
            collectDate = collect;
        }
        public String getCollectDate()
        {
            return collectDate;
        }
        public void setReturnDate(String returnDates)
        {
            returnDate = returnDates;
        }
        public String getReturnDate()
        {
            return returnDate;
        }
        public void setCost(double rate)
        {
            cost = rate;
        }
        public double getCost()
        {
            return cost;
        }
        public void setFine(double fines)
        {
            fine = fines;
        }
        public double getFine()
        {
            return fine;
        }
        public void setStatus(char clientStatus)
        {
            status = clientStatus;
        }
        public char getStatus()
        {
            return status;
        }
        
        public void setRegistrationNo(String registrationId)
        {
            registrationNo = registrationId;
        }
        public String getRegistrationNo()
        {
            return registrationNo;
        }
        public void setClientId(int clientID)
        {
            clientId = clientID;
        }
        public int getClientId()
        {
            return clientId;
        }
        public static DataSet GetClientID()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String sqlQuery = "SELECT Name FROM Clients WHERE Status = 'O' ORDER BY Name";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            odr.Fill(ds, "clients");

            conn.Close();

            return ds;


        }
        public void addReservation()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Reservations VALUES(" +
                this.reservationNo + ",'" +
                this.collectDate + "','" +
                this.returnDate + "'," +
                this.cost + "," +
                this.fine + ",'" +
                this.status + "','" +
                this.registrationNo + "',"+
                this.clientId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        }
        public static DataSet findAvailableCar(String carType, String collectDate, String returnDate)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            String sqlQuery = "SELECT RegistrationNo, Name, Model, typeCode FROM Cars " +
                "WHERE TypeCode = '" + carType + "' AND RegistrationNo NOT IN " +
                        "(SELECT RegistrationNo FROM Reservations " +
                        "WHERE (CollectDate >= '"+ collectDate+"' AND ReturnDate >= '"+returnDate+"') OR " +
                        "(CollectDate <= '"+collectDate +"' AND ReturnDate <= '"+returnDate+"')  OR " +
                        "(CollectDate >= '" + collectDate + "' AND ReturnDate <= '" + returnDate + "') OR " +
                        "(CollectDate <= '" + collectDate + "' AND ReturnDate >= '" + returnDate + "'))";

            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Reserve");

            //Close connection
            conn.Close();

            return ds;
        }
        public static int getNextReservationNo()
        {
            int nextReservationNo;

            OracleConnection con = new OracleConnection(DBConnect.oradb);


            String sqlQuery = "SELECT MAX(ReservationNo) FROM Reservations";


            OracleCommand cmd = new OracleCommand(sqlQuery, con);

            con.Open();

            OracleDataReader dr = cmd.ExecuteReader();

         
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextReservationNo = 1;
            }
            else
            {
                nextReservationNo = dr.GetInt32(0) + 1;
            }


            con.Close();
            return nextReservationNo;
        }
        public static int getClientID(String clientName)
        {
            int clientID;
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT clientId FROM Clients WHERE Name = '" + clientName+ "'";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            clientID = dr.GetInt32(0);
           

            conn.Close();

            return clientID;


        }
        public static Boolean isValidReservationNo(int reservationNo)
        {
       
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT ReservationNo FROM Reservations WHERE ReservationNo = " + reservationNo;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


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

        public static DataSet getReservationDetails(int reservationNo)
        {
       
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

          
            String sqlQuery = "SELECT Clients.Name, Cars.RegistrationNo, Cars.Name, Cars.Model, Reservations.collectdate, Reservations.Returndate , Reservations.Cost " +
                "FROM Reservations " +
                "INNER JOIN Cars ON Reservations.RegistrationNo = Cars.RegistrationNo " +
                "INNER JOIN Clients ON Reservations.ClientId = Clients.ClientId " +
                "WHERE Reservations.Reservationno = " + reservationNo;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            odr.Fill(ds, "resDetails");


            conn.Close();

            return ds;


        }
        public static void cancelReservation(int reservationno)
        {
          
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

      

            String sqlQuery = "DELETE FROM Reservations WHERE Reservationno ="+reservationno;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            conn.Close();

        }
      

        public static Boolean setStatusToCollect(int resNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            
            String sqlQuery = "UPDATE Reservations SET Status = 'C' WHERE ReservationNo = " + resNo;


            
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


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
        
        public static Boolean isCollectedReservation(int reservationNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT ReservationNo FROM Reservations WHERE ReservationNo = " + reservationNo+ "and Status = 'C'";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


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
        public static Boolean isReturnedReservation(int reservationNo)
        {
           
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            
            String sqlQuery = "SELECT ReservationNo FROM Reservations WHERE ReservationNo = " + reservationNo + "and Status = 'R'";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


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
        public static Boolean setFine(int resNo,double fine)
        {
           
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

          
            String sqlQuery = "UPDATE Reservations SET Fine = "+fine+ " WHERE ReservationNo = " + resNo;

            
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            
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
        public static Boolean setStatusToReturn(int resNo)
        {
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "UPDATE Reservations SET Status = 'R' WHERE ReservationNo = " + resNo;


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
        public static DataSet getReturnCarDetails()
        {

            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT Clients.ClientId, Clients.Name, Cars.RegistrationNo, Cars.Name, Cars.Model " +
                "FROM Reservations " +
                "INNER JOIN Cars ON Reservations.RegistrationNo = Cars.RegistrationNo " +
                "INNER JOIN Clients ON Reservations.ClientId = Clients.ClientId " +
                "WHERE Reservations.Status = 'R' ";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter odr = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            odr.Fill(ds, "retCarDetails");


           
            conn.Close();

            return ds;


        }
        public static int getEachClientId(int clientId)
        {
            int clientID;
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT DISTINCT ClientId FROM Reservations WHERE ClientId = '" + clientId + "'";


            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if RegistrationNo exists in the database
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.HasRows)
            {
                clientID = dr.GetInt32(0);
            }
            else
            {
                clientID = 0;
            }


            conn.Close();

            return clientID;


        }
        // Retrieve the sum of cost of a client
        public static double getTotalCost(int clientId)
        {
            double total;
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // //Define the SQL query to be executed
            String sqlQuery = "SELECT SUM(Cost) FROM Reservations WHERE ClientId = '" + clientId + "'";


            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if RegistrationNo exists in the database
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                total = 0;
            }
            else
            {
                total = dr.GetInt32(0);
            }

            

            conn.Close();

            return total;


        }

        public static void deleteReservation(int clientId)
        {
            //Open connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed

            String sqlQuery = "DELETE FROM Reservations WHERE ClientId =" + clientId;

            //Execute the SQL querry (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();


            //Check if clientId exist in the database
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            conn.Close();

        }

    }
}

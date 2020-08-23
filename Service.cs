using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SalonSYS
{
    class Service
    {
        private int serviceID;
        private String servDesc;
        private int duration;
        private decimal cost;
        private char status;

        //Constructor
        public Service()
        {
            serviceID = 000;
            servDesc = "";
            duration = 000;
            cost = 0;
            status = '\x0000';

        }
        //getters

        public int getServID()
        {
            return serviceID;
        }

        public void setServID(int serviceID)
        {
            this.serviceID = serviceID;
        }
        public String getDesc()
        {
            return servDesc;
        }
        public void setDesc(String DESC)
        {
            servDesc = DESC;
        }

        public int getDuration()
        {
            return duration;
        }
        public void setDuration(int duration)
        {
            this.duration = duration;
        }
      
        public decimal getCost()
        {
            return cost;
        }

        public void setCost(decimal cost)
        {
            this.cost = cost;
        }

        public char getStatus()
        {
            return status;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        //An OracleDataAdapter object represents a data provider object that 
        //populates the DataSet and updates changes in the DataSet to the
        //Oracle database.




        public static int getNextID()
        {


            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(serviceID) FROM Services";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0] == DBNull.Value) // if(dr.IsDBNull(0)…
                last = 1;
            else
                last = Convert.ToInt32(dr[0]) + 1;
            conn.Close();
            
            return last;




        }
        public void addService()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Services VALUES (" + this.serviceID + ", '" + this.servDesc + "' , '" + this.duration + "', " + this.cost + ", '" + this.status + "')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();



        }
       
        public static DataSet getServices()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Services ORDER BY serviceID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Services");

            //Close database connection
            conn.Close();

            return ds;
        }

        //this method retrieves a summary of a service (not everything!)
        public static DataSet getSummaryServices()
        {
            //define Sql Query
            String strSQL = "SELECT serviceID, ServDescription AS Description FROM Services WHERE servStatus = 'A' ORDER BY serviceID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Services");

            //Close database connection
            conn.Close();

            return ds;
        }
        public void getAService(int ServiceID)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT * FROM Services WHERE serviceID = " + ServiceID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()

            //Instantiate object variables
            this.serviceID = dr.GetInt32(0);
            this.servDesc = dr.GetString(1);
            this.duration = dr.GetInt32(2);
            this.cost = dr.GetDecimal(3);

            //close DB
            conn.Close();
        }
        public static DataSet checkDesc(String desc)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Services WHERE ServDescription = '" + desc +"'";

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Desc");

            //Close database connection
            conn.Close();

            return ds;


        }

        //this method retrieves times
        public static DataSet getTimes()
        {
            //define Sql Query
            String strSQL = "SELECT * from TimeSlots";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Time");

            //Close database connection
            conn.Close();

            return ds;
        }
        public void updateService()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Services SET ServDescription = '" + this.servDesc +
                            "', DurationID = " + this.duration + ", cost = " + this.cost + 
                            " WHERE serviceID =" + this.serviceID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }

        public void deleteService()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Services SET Servstatus = 'D' WHERE serviceID =" + this.serviceID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }

        public static DataSet checkIfBooked(int ServId)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Appointments WHERE ServiceID = " + ServId;
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "active");

            //Close database connection
            conn.Close();

            return ds;


        }

    }
}
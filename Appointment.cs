using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SalonSYS
{
    class Appointment
    {
        private int appID;
        private DateTime appDate;
        private int appTimeID;
        private int serviceID;
        private int employeeID;
        private decimal appCost;
        private String client;
        private int phone;
        private String endtime;

        public Appointment()
        {
            appID = 000;
            appDate = DateTime.MinValue;
            appTimeID = 000;
            serviceID = 000;
            employeeID = 000;
            appCost = 00;
            client = "";
            phone = 000;
            endtime = "";


        }

        public int getID()
        {
            return appID;

        }
        public void setID(int AppID)
        {
            appID = AppID;
        }

        public DateTime getDate()
        {
            return appDate;
        }

        public void setDate(DateTime date)
        {
            appDate = date;
        }

        public int getTime()
        {
            return appTimeID;
        }
        public void setTime(int Time)
        {
            appTimeID = Time;
        }

        public int getEmpID()
        {
            return employeeID;
        }
        public void setEmpID(int EmpID)
        {
            employeeID = EmpID;
        }
        public int getServID()
        {
            return serviceID;
        }
        public void setServID(int servID)
        {
            serviceID = servID;
        }

        public decimal getCost()
        {
            return appCost;
        }
        public void setCost(decimal cost)
        {
            appCost = cost;
        }
        public String getClient()
        {
            return client;
        }
        public void setClient(String Client)
        {
            client = Client;
        }
        public int getPhone()
        {
            return phone;
        }
        public void setPhone(int Phone)
        {
            phone = Phone;
        }

        public String getEndtime()
        {
            return endtime;
        }
        public void setEndtime(String Endtime)
        {
            endtime = Endtime;
        }
        public static DataSet getSummaryAppointments()
        {
            //define Sql Query
            String strSQL = "SELECT AppID, AppDate, AppTimeID, EmployeeID, ServiceID, Client FROM " +
                "Appointments WHERE AppDate >= date '" + DateTime.Now.ToString("yyyy-MM-dd") +"' ORDER BY AppID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Apps");

            //Close database connection
            conn.Close();

            return ds;
        }
        public static DataSet getTimes()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM AppTimes ORDER BY AppTimeID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "AppTimes");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static int getNextID()
        {


            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(appID) FROM Appointments";
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
        public static int getACost(int app)
        {

            int cost;
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT Cost FROM Services WHERE serviceID = " + app;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()
            cost = Convert.ToInt32(dr[0]);
            //close DB
            conn.Close();
            return cost;

        }
      public static String calcEndTime(String time, int duration) 
          {
              String endtime;

            TimeSpan timespa = TimeSpan.Parse(time);
             
              String timeslots = "0:14";
            TimeSpan ctime = TimeSpan.Parse(timeslots);
            
            ctime = TimeSpan.FromTicks(ctime.Ticks * duration);

            String extra = "0:01";
            TimeSpan leftovertime= TimeSpan.Parse(extra);
            leftovertime = TimeSpan.FromTicks(leftovertime.Ticks * duration);

            if ((timespa + ctime) > TimeSpan.Parse("17:59"))
            {
                endtime = null;
                return endtime;
            }
            else
            {
                endtime = (timespa + ctime).ToString();


                return endtime;

            }
          }
        public void getAnAppointment(int appID)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT * FROM Appointments WHERE appID = " + appID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()

            //Instantiate object variables
            this.appID = dr.GetInt32(0);
            this.appDate = dr.GetDateTime(1);
            this.appTimeID = dr.GetInt32(2);
            this.endtime = dr.GetString(3);
            this.serviceID = dr.GetInt32(4);
            this.employeeID = dr.GetInt32(5);
            this.appCost = dr.GetDecimal(6);
            this.client = dr.GetString(7);
            this.phone = dr.GetInt32(8);
            

            //close DB
            conn.Close();
        }


        public static DataSet checkAvail(int emp, String date,String starttime, String endtime, int start, int duration)
        {

      
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Appointments WHERE EmployeeID = " + emp + " AND " +
                "appdate = date'" + date + "' AND ((AppTimeID >= " + start + " AND AppTimeID <= " + (start + duration) + ") " +
                "OR (Endtime >= '" + starttime + "' AND Endtime <= '" + endtime + "')) ORDER BY AppTimeID";

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Appointments");

            //Close database connection
            conn.Close();

            return ds;


        }

        public static int getADuration(int service){
            int duration;
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT DurationID FROM Services WHERE serviceID = " + service;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()
            duration = Convert.ToInt32(dr[0]);
            //close DB
            conn.Close();
            return duration;
        }

        public static DataSet getAnEmp(int app)
        {

        
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            //define Sql Query
            String strSQL = "SELECT Employees.EmployeeID,Employees.EmpName FROM EmployeeServices " +
                "INNER JOIN Employees ON Employees.EmployeeID = EmployeeServices.EmployeeID WHERE ServiceID=" + app;

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "EmpName");

            //Close database connection
            conn.Close();

            return ds;



        }

        public void makeApp()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Appointments VALUES (" + this.appID + ", date '" + String.Format("{0:yyyy-MM-dd}", this.appDate) +
                "', " + this.appTimeID + ", '" + this.endtime + "' , " + this.serviceID + " , " + this.employeeID + " ," + this.appCost + ", '" 
                + this.client + "', " + this.phone + " )";

           // INSERT INTO appointments VALUES(002, date '2020-05-04', 1, '002', 2, 35, 'Hazel', 0871234567);

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();

            
        }
        public void cancelAppointment()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "DELETE FROM Appointments WHERE AppID =" + this.appID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }

        public static double getRevenueAnalysis(String date)
        {
            double result = 0.0;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT Month, NVL(SUM(AppCost),0) AS Service_Revenue FROM All_Months M LEFT JOIN Appointments " +
                "A on M.Month = TO_CHAR(AppDate,'MM') WHERE TO_CHAR(AppDate,'yyyy-MM') LIKE '" + date + "%' GROUP BY Month ORDER BY Month;";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0)) // if(dr.IsDBNull(0)…
                result = 0.0;
            else
                result = dr.GetDouble(0);
                
            conn.Close();

            return result;
          
        }
        

    }
}

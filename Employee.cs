using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SalonSYS
{
    class Employee
    {
        private int employeeID;
        private String name;
        private String surname;
        private String email;
        private char empStatus;

        public Employee()
        {
            employeeID = 000;
            name = "";
            surname = "";
            email = "";
            empStatus = '\x0000';
        }
        //getters
        public int getEmpID()
        {
            return employeeID;
        }
        public void setEmpID(int EmployeeID)
        {
            employeeID = EmployeeID;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getSurname()
        {
            return surname;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public char getEmpStatus()
        {
            return empStatus;
        }
        public void setEmpStatus(char status)
        {
            empStatus = status;
        }

        public static int getNextID()
        {


            int last;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(employeeID) FROM Employees";
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
        public void addEmployee()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Employees VALUES (" + this.employeeID + ", '" + this.name + "' , '" + this.surname + 
                "', '" + this.email + "', '" + this.empStatus + "')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();



        }
        public static DataSet getEmployees()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Employees ORDER BY employeeID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Employees");

            //Close database connection
            conn.Close();

            return ds;
        }
        //this method retrieves a summary of an employee(not everything!)
        public static DataSet getSummaryEmployees()
        {
            //define Sql Query
            String strSQL = "SELECT employeeID, empName AS Name FROM Employees WHERE EmpStatus" +
                " = 'A' ORDER BY employeeID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Employees");

            //Close database connection
            conn.Close();

            return ds;
        }
        public void getAnEmployee(int EmployeeID)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT * FROM Employees WHERE employeeID = " + EmployeeID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); //Consider if dr.Read()

            //Instantiate object variables
            this.employeeID = dr.GetInt32(0);
            this.name = dr.GetString(1);
            this.surname = dr.GetString(2);
            this.email = dr.GetString(3);

            //close DB
            conn.Close();
        }
        public void deleteEmp()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Employees SET empStatus = 'D' WHERE employeeID =" + this.employeeID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }
        public void providesService(int ServiceID)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO EmployeeServices VALUES(" + ServiceID + ", " + this.employeeID + ")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();

        }

        //stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address

        public static bool ValidateEmail(string email)
        {

            string emailpattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";



            return (string.IsNullOrEmpty(email) == false && System.Text.RegularExpressions.Regex.IsMatch(email, emailpattern))
                ? true
                : false;
        }
        public static DataSet getAvailability(int emp, String date)
        {
            //define Sql Query
            String strSQL = "SELECT AppID, AppDate, ServiceID, EmployeeID, Apptime FROM Apptimes A LEFT JOIN Appointments B on A.ApptimeID = B.ApptimeID WHERE EmployeeID =" + emp + " AND AppDate = date '" + date + "'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Availability");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet checkEmail(String email)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Employees WHERE Email = '" + email + "'";

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "emails");

            //Close database connection
            conn.Close();

            return ds;


        }


    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalonSYS
{
    public partial class frmRevAnalysis : Form
    {
        frmMainMenu parent;
      
        public frmRevAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuHome_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblRevAnalysis.Visible = false;
            pnlRevAnalysis.Visible = false;

        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //Dispose this form
            this.Close();
            //Display main menu
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void cmbRevYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRevAnalysis.BringToFront();
            lblRevAnalysis.Visible = true;
            pnlRevAnalysis.Visible = true;
            

            if (cmbRevenueYear.SelectedItem.ToString().Equals("2018"))
            {
                String date = cmbRevenueYear.SelectedItem.ToString();
                String strSQL = "SELECT NVL(SUM(AppCost),0) AS Service_Revenue, Month FROM All_Months M LEFT JOIN Appointments A on M.Month = TO_CHAR(AppDate,'MM') WHERE TO_CHAR(AppDate,'yyyy-MM') LIKE '"+date+"%' GROUP BY Month ORDER BY Month";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                decimal[] revenue = new decimal[dt.Rows.Count];
                string[] month = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    revenue[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    month[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                }


                cht18.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                cht18.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                cht18.Series[0].Points.DataBindXY(month, revenue);



                cht18.Visible = true;
                cht17.Visible = false;
                cht16.Visible = false;
                cht19.Visible = false;


            }
            else if (cmbRevenueYear.SelectedItem.ToString().Equals("2017"))
            {
                String date = cmbRevenueYear.SelectedItem.ToString();
                String strSQL = "SELECT NVL(SUM(AppCost),0) AS Service_Revenue, Month FROM All_Months M LEFT JOIN Appointments A on M.Month = TO_CHAR(AppDate,'MM') WHERE TO_CHAR(AppDate,'yyyy-MM') LIKE '" + date + "%' GROUP BY Month ORDER BY Month";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                decimal[] revenue = new decimal[dt.Rows.Count];
                string[] month = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    revenue[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    month[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                }


                cht17.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                cht17.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                cht17.Series[0].Points.DataBindXY(month, revenue);



                cht18.Visible = false;
                cht17.Visible = true;
                cht16.Visible = false;
                cht19.Visible = false;


            }
            else if (cmbRevenueYear.SelectedItem.ToString().Equals("2016"))
            {
                String date = cmbRevenueYear.SelectedItem.ToString();
                String strSQL = "SELECT NVL(SUM(AppCost),0) AS Service_Revenue, Month FROM All_Months M LEFT JOIN Appointments A on M.Month = TO_CHAR(AppDate,'MM') WHERE TO_CHAR(AppDate,'yyyy-MM') LIKE '" + date + "%' GROUP BY Month ORDER BY Month";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                decimal[] revenue = new decimal[dt.Rows.Count];
                string[] month = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    revenue[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    month[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                }


                cht16.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                cht16.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                cht16.Series[0].Points.DataBindXY(month, revenue);



                cht18.Visible = false;
                cht17.Visible = false;
                cht16.Visible = true;
                cht19.Visible = false;



            }
            else if (cmbRevenueYear.SelectedItem.ToString().Equals("2019"))
            {
                String date = cmbRevenueYear.SelectedItem.ToString();
                String strSQL = "SELECT NVL(SUM(AppCost),0) AS Service_Revenue, Month FROM All_Months M LEFT JOIN Appointments A on M.Month = TO_CHAR(AppDate,'MM') WHERE TO_CHAR(AppDate,'yyyy-MM') LIKE '" + date + "%' GROUP BY Month ORDER BY Month";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                decimal[] revenue = new decimal[dt.Rows.Count];
                string[] month = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    revenue[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    month[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                }


                cht19.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                cht19.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                cht19.Series[0].Points.DataBindXY(month, revenue);



                cht18.Visible = false;
                cht17.Visible = false;
                cht16.Visible = false;
                cht19.Visible = true;



            }


        }
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }

                default: return "OTH";
            }
        }

        private void pnlRevenueAnalysis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}

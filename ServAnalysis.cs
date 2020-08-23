using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SalonSYS
{
    public partial class frmServAnalysis : Form
    {
        frmMainMenu parent;


        public frmServAnalysis(frmMainMenu Parent)
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
            pnlServAnalysis.Visible = false;
            lblServAnalysis.Visible = false;
            
           
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

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblServAnalysis.BringToFront();
            lblServAnalysis.Visible = true;
            pnlServAnalysis.Visible = true;

            




            if (cmbServiceYear.SelectedItem.ToString().Equals("2018"))
            {
              
                String date = cmbServiceYear.SelectedItem.ToString();
                String strSQL = "SELECT ServDescription , NVL(SUM(AppCost),0) AS Service_Revenue FROM Services S LEFT JOIN Appointments A on S.ServiceID = A.ServiceID WHERE TO_CHAR(A.AppDate,'yyyy') = '" + date + "' GROUP BY ServDescription ORDER BY ServDescription";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                string[] service = new string[dt.Rows.Count];
                decimal[] M = new decimal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    service[i] = Convert.ToString(dt.Rows[i][0]);
                    M[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }
           
               
                cht18.Series[0].Points.DataBindXY(service, M);
                cht18.Series[0].Points[0].Label = Convert.ToString(M[0]);
                cht18.Series[0].Points[0].LegendText = service[0];
                cht18.Series[0].Points[1].Label = Convert.ToString(M[1]);
                cht18.Series[0].Points[1].LegendText = service[1];
                cht18.Series[0].Points[2].Label = Convert.ToString(M[2]);
                cht18.Series[0].Points[2].LegendText = service[2];
                cht18.Series[0].Points[3].Label = Convert.ToString(M[3]);
                cht18.Series[0].Points[3].LegendText = service[3];
                cht18.Series[0].Points[4].Label = Convert.ToString(M[4]);
                cht18.Series[0].Points[4].LegendText = service[4];



                cht18.Visible = true;
                cht17.Visible = false;
                cht16.Visible = false;
                cht19.Visible = false;

            }





            else if (cmbServiceYear.SelectedItem.ToString().Equals("2017"))
            {

                String date = cmbServiceYear.SelectedItem.ToString();
                String strSQL = "SELECT ServDescription , NVL(SUM(AppCost),0) AS Service_Revenue FROM Services S LEFT JOIN Appointments A on S.ServiceID = A.ServiceID WHERE TO_CHAR(A.AppDate,'yyyy') = '" + date + "' GROUP BY ServDescription ORDER BY ServDescription";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                string[] service = new string[dt.Rows.Count];
                decimal[] M = new decimal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    service[i] = Convert.ToString(dt.Rows[i][0]);
                    M[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }


                cht17.Series[0].Points.DataBindXY(service, M);
                cht17.Series[0].Points[0].Label = Convert.ToString(M[0]);
                cht17.Series[0].Points[0].LegendText = service[0];
                cht17.Series[0].Points[1].Label = Convert.ToString(M[1]);
                cht17.Series[0].Points[1].LegendText = service[1];
                cht17.Series[0].Points[2].Label = Convert.ToString(M[2]);
                cht17.Series[0].Points[2].LegendText = service[2];
                cht17.Series[0].Points[3].Label = Convert.ToString(M[3]);
                cht17.Series[0].Points[3].LegendText = service[3];
                cht17.Series[0].Points[4].Label = Convert.ToString(M[4]);
                cht17.Series[0].Points[4].LegendText = service[4];
                cht17.Series[0].Points[5].Label = Convert.ToString(M[5]);
                cht17.Series[0].Points[5].LegendText = service[5];







                cht17.Visible = true;
                cht18.Visible = false;
                cht19.Visible = false;
                cht16.Visible = false;
            }
            else if (cmbServiceYear.SelectedItem.ToString().Equals("2016"))
            {
                String date = cmbServiceYear.SelectedItem.ToString();
                String strSQL = "SELECT ServDescription , NVL(SUM(AppCost),0) AS Service_Revenue FROM Services S LEFT JOIN Appointments A on S.ServiceID = A.ServiceID WHERE TO_CHAR(A.AppDate,'yyyy') = '" + date + "' GROUP BY ServDescription ORDER BY ServDescription";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                string[] service = new string[dt.Rows.Count];
                decimal[] M = new decimal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    service[i] = Convert.ToString(dt.Rows[i][0]);
                    M[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }


                cht16.Series[0].Points.DataBindXY(service, M);
                cht16.Series[0].Points[0].Label = Convert.ToString(M[0]);
                cht16.Series[0].Points[0].LegendText = service[0];
                cht16.Series[0].Points[1].Label = Convert.ToString(M[1]);
                cht16.Series[0].Points[1].LegendText = service[1];
                cht16.Series[0].Points[2].Label = Convert.ToString(M[2]);
                cht16.Series[0].Points[2].LegendText = service[2];
                cht16.Series[0].Points[3].Label = Convert.ToString(M[3]);
                cht16.Series[0].Points[3].LegendText = service[3];
                cht16.Series[0].Points[4].Label = Convert.ToString(M[4]);
                cht16.Series[0].Points[4].LegendText = service[4];
              


                cht16.Visible = true;
                cht17.Visible = false;
                cht18.Visible = false;
                cht19.Visible = false;
               
              
            }
            else if (cmbServiceYear.SelectedItem.ToString().Equals("2019"))
            {

                String date = cmbServiceYear.SelectedItem.ToString();
                String strSQL = "SELECT ServDescription , NVL(SUM(AppCost),0) AS Service_Revenue FROM Services S LEFT JOIN Appointments A on S.ServiceID = A.ServiceID WHERE TO_CHAR(A.AppDate,'yyyy') = '" + date + "' GROUP BY ServDescription ORDER BY ServDescription";
                DataTable dt = new DataTable();
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);

                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                myConn.Close();
                string[] service = new string[dt.Rows.Count];
                decimal[] M = new decimal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    service[i] = Convert.ToString(dt.Rows[i][0]);
                    M[i] = Convert.ToDecimal(dt.Rows[i][1]);
                }


                cht19.Series[0].Points.DataBindXY(service, M);
                cht19.Series[0].Points[0].Label = Convert.ToString(M[0]);
                cht19.Series[0].Points[0].LegendText = service[0];
                cht19.Series[0].Points[1].Label = Convert.ToString(M[1]);
                cht19.Series[0].Points[1].LegendText = service[1];
                cht19.Series[0].Points[2].Label = Convert.ToString(M[2]);
                cht19.Series[0].Points[2].LegendText = service[2];
                cht19.Series[0].Points[3].Label = Convert.ToString(M[3]);
                cht19.Series[0].Points[3].LegendText = service[3];
                cht19.Series[0].Points[4].Label = Convert.ToString(M[4]);
                cht19.Series[0].Points[4].LegendText = service[4];
                cht19.Series[0].Points[5].Label = Convert.ToString(M[5]);
                cht19.Series[0].Points[5].LegendText = service[5];




                cht19.Visible = true;
                cht16.Visible = false;
                cht17.Visible = false;
                cht18.Visible = false;
                

            }
          
        }
        


        }

    }


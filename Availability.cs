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
    public partial class frmAvailability : Form
    {
        frmMainMenu parent;
        public frmAvailability(frmMainMenu Parent)
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
            dgAvailability.Visible = false;
            btnBack.Visible = false;
            dtAvailability.MinDate = DateTime.Today.AddDays(1);
            //load combo with employeeIDs
            DataSet ds = new DataSet();
            ds = Employee.getSummaryEmployees();
            for (int i = 0; i < ds.Tables["Employees"].Rows.Count; i++)
                cmbEmployee.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                " " + ds.Tables[0].Rows[i][1].ToString());

        }

        private void mnuServices_Click(object sender, EventArgs e)
        {

        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //Dispose this form
            this.Close();
            //Display Main Menu
            parent.Visible = true;
        }

        private void lblTimeSlots_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (dtAvailability.Checked == true && cmbEmployee.SelectedIndex > -1)
            {

                
                btnCheckAvailability.Visible = false;

                String date = String.Format("{0:yyyy-MM-dd}", dtAvailability.Value);

                int empID = Int32.Parse(cmbEmployee.SelectedItem.ToString().Substring(0, 3));

                DataSet ds2 = new DataSet();
                ds2 = Employee.getAvailability(empID, date);

                int i = ds2.Tables["Availability"].Rows.Count;
                if (i > 0)
                {

                    dgAvailability.DataSource = Employee.getAvailability(empID, date).Tables["Availability"];
                    dgAvailability.Visible = true;
                    btnBack.Visible = true;

                }
                else
                {
                    MessageBox.Show("All appointments available!", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnCheckAvailability.Visible = true;


                }
            }

            else
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnCheckAvailability.Visible = true;
                return;
            }


        }

        private void dtAvailability_ValueChanged(object sender, EventArgs e)
        {
            DayOfWeek i = dtAvailability.Value.DayOfWeek;
            
            if (i == DayOfWeek.Sunday)
            {
                
                MessageBox.Show("Opening Hours: Mon - Sat, 09:00 - 18:00");
                
                dtAvailability.Refresh();
                

            }
            else return;

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
       
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgAvailability.Visible = false;
            btnBack.Visible = false;
            btnCheckAvailability.Visible = true;
        }
    }
    } 
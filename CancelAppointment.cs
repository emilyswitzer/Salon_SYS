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
    public partial class frmCancelAppointment : Form
    {
        frmMainMenu parent;
        public frmCancelAppointment(frmMainMenu Parent)
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

            lblCancelAppt.Visible = false;
            pnlCancelAppt.Visible = false;

            
            //load combo with Appointments
            DataSet ds = new DataSet();
            ds = Appointment.getSummaryAppointments();
            for (int i = 0; i < ds.Tables["Apps"].Rows.Count; i++)
                cmbAppID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));

        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //Dispose of this form
            this.Close();
            //Display main menu
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            //Check to see if there is an appointment selected. If there is it will delete it
            if (cmbAppID.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //update the database
                    Appointment myApp = new Appointment();
                    myApp.setID(Int32.Parse(this.cmbAppID.SelectedItem.ToString().Substring(0, 3)));
                    myApp.cancelAppointment();
                    MessageBox.Show("Appointment cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    parent.Visible = true;
                   
                }
            }
            else
                MessageBox.Show("No appointment has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pnlCancelAppt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCancelAppt.BringToFront();
            lblCancelAppt.Visible = true;
            pnlCancelAppt.Visible = true;


            Appointment app = new Appointment();
            app.getAnAppointment(Int32.Parse(this.cmbAppID.SelectedItem.ToString().Substring(0, 3)));
            //load Employee details onto form
            txtTime.Text = app.getTime().ToString();
            txtService.Text = app.getServID().ToString();
            txtEmp.Text = app.getEmpID().ToString();
            txtDate.Text = app.getDate().ToString().Substring(0,8);
            txtClientPhone.Text = app.getPhone().ToString();
            txtCost.Text = app.getCost().ToString();
            txtClient.Text = app.getClient().ToString();



        }
    }
}

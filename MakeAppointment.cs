using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace SalonSYS
{
    public partial class frmMakeAppointment : Form
    {
        frmMainMenu parent;
        public frmMakeAppointment(frmMainMenu Parent)
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
            grdApps.DataSource = Appointment.getSummaryAppointments().Tables["Apps"];
            //Load in Service IDs
            txtApptID.Text = String.Format("{0:000}", Appointment.getNextID());
 

            DateAppBox.MinDate = DateTime.Today;

            //load available services
            DataSet ds1 = new DataSet();
            ds1 = Service.getSummaryServices();
            for (int i = 0; i < ds1.Tables["Services"].Rows.Count; i++)
                cmbServiceID.Items.Add(ds1.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                "    " + ds1.Tables[0].Rows[i][1].ToString());




        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //Dispose of this form
            this.Close();
            //Display the Main Menu
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            System.DayOfWeek i = DateAppBox.Value.DayOfWeek;
            if (i == System.DayOfWeek.Sunday)
            {
                MessageBox.Show("Opening Hours: Mon - Sat, 09:00 - 18:00", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                DateAppBox.ResetText();
                return;
            }
            else return;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbEmployeeID.Items.Clear();
            cmbEmployeeID.ResetText();
            {
                int serviceID = Int32.Parse(cmbServiceID.SelectedItem.ToString().Substring(0, 3));

                txtCost.Text = String.Format("{00:00}", Appointment.getACost(serviceID));

                DataSet ds = new DataSet();
                ds = Appointment.getTimes();
                for (int i = 0; i < ds.Tables["AppTimes"].Rows.Count; i++)
                    cmbTime.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                     " " + ds.Tables[0].Rows[i][1].ToString());

                //load available employees
                DataSet ds2 = new DataSet();
                ds2 = Appointment.getAnEmp(serviceID);
                for (int i = 0; i < ds2.Tables["EmpName"].Rows.Count; i++)
                    cmbEmployeeID.Items.Add(ds2.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                  "    " + ds2.Tables[0].Rows[i][1].ToString());



            }
        }

           

            private void btnClearAppt_Click(object sender, EventArgs e)
        {
            //Clear all fields
            txtCustomerName.Clear();
            cmbEmployeeID.ResetText();
            cmbServiceID.ResetText();
            DateAppBox.ResetText();
            cmbTime.ResetText();
        }

        private void timeApptBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmAppt_Click(object sender, EventArgs e)
        {
            //All fields must be entered before you can add a service
            if (txtApptID.Text.Trim() == string.Empty || txtCustomerName.Text.Trim() == string.Empty || cmbEmployeeID.SelectedIndex < 0
                || cmbServiceID.SelectedIndex < 0 || cmbTime.SelectedIndex < 0 )
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // return because we don't want to run normal code of button click
            }
            else if

                 (txtCPhone.Text.Length < 10)
                {
                    MessageBox.Show("Please enter a valid mobile number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // return because we don't want to run normal code of button click
                }
            else
            {
                int employeeID = Int32.Parse(cmbEmployeeID.SelectedItem.ToString().Substring(0, 3));
                int serviceID = Int32.Parse(cmbServiceID.SelectedItem.ToString().Substring(0, 3));
                int durationid = Appointment.getADuration(serviceID);
                DateTime s = DateAppBox.Value;
                String s1 = String.Format("{0:yyyy-MM-dd}", DateAppBox.Value);


                String timeStartString = cmbTime.SelectedItem.ToString().Substring(4, 5);

                int timeID = Int32.Parse(cmbTime.SelectedItem.ToString().Substring(0, 3));

                String endtime = String.Format("{0:hh:mm}", Appointment.calcEndTime(timeStartString, durationid)).Substring(0, 5);
                



                    
                    DataSet ds2 = new DataSet();
                    ds2 = Appointment.checkAvail(employeeID, s1, timeStartString, endtime, timeID, durationid);
                    int i = ds2.Tables["Appointments"].Rows.Count;
                    if (i > 0)
                    {

                        MessageBox.Show("Appointment Unavailable please choose another time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbTime.ResetText();
                    }
                    else
                    {





                        //All validation has passed the appointment can be added
                        //instantiate the Appointment
                        Appointment a = new Appointment();
                        a.setID(Convert.ToInt32(txtApptID.Text));
                        a.setTime(Int32.Parse(this.cmbTime.SelectedItem.ToString().Substring(0, 3)));
                        a.setEmpID(Int32.Parse(this.cmbEmployeeID.SelectedItem.ToString().Substring(0, 3)));
                        a.setServID(Int32.Parse(this.cmbServiceID.SelectedItem.ToString().Substring(0, 3)));
                        a.setPhone(Convert.ToInt32(txtCPhone.Text));
                        a.setCost(Convert.ToDecimal(txtCost.Text));
                        a.setDate(Convert.ToDateTime(this.DateAppBox.Value));
                        a.setClient(txtCustomerName.Text);
                        a.setEndtime(endtime);




                        //add Appointment to the database
                        a.makeApp();




                    //All validation has passed the appointment can be added

                    MessageBox.Show("Appointment added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                        parent.Visible = true;
                    
                }
            }
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtApptID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int serviceID = Int32.Parse(cmbServiceID.SelectedItem.ToString().Substring(0, 3));
            int durationid = Appointment.getADuration(serviceID);
            String timeStartString = cmbTime.SelectedItem.ToString().Substring(4, 5);
            try
            {
                String endtime = String.Format("{0:hh:mm}", Appointment.calcEndTime(timeStartString, durationid)).Substring(0, 5);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                
                
                   MessageBox.Show("Appointment Not Available - Closed at 18:00!");
                    cmbTime.ResetText();
                    return;
               
                


            }


        }


        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCustomerName.Text)) 
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtCustomerName.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.ResetText();
                    txtCustomerName.Clear();
                    txtCustomerName.Focus();
                }
            }

        }

        private void txtCPhone_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCPhone.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtCPhone.Text, "^[0-9 ]+$"))
                {
                    MessageBox.Show("Enter Valid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPhone.ResetText();
                    txtCPhone.Clear();
                    txtCPhone.Focus();
                }
            }
        }

    }
    }


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
    public partial class frmChangeService : Form
    {

        frmMainMenu parent;
       

        public frmChangeService(frmMainMenu Parent)
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
            lblChangeService.BringToFront();
            lblChangeService.Visible = false;
            pnlChangeService.Visible = false;

            //load combo with services
            DataSet ds = new DataSet();
            ds = Service.getSummaryServices();
            for (int i = 0; i < ds.Tables["Services"].Rows.Count; i++)
            cmbServiceID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
            " " + ds.Tables[0].Rows[i][1].ToString());

            //load combo with times for services
            DataSet ds1 = new DataSet();
            ds1 = Service.getTimes();
            for (int i = 0; i < ds1.Tables["Time"].Rows.Count; i++)
                cmbServDuration.Items.Add(ds1.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
            " " + ds1.Tables[0].Rows[i][1].ToString());
            
        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //dispose of this form
            this.Close();

            //show the Hidden main menu

            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {

        }

        private void lblChangeService_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            // validate the data entered
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDesc.Text, "^[a-zA-Z -]+$"))
            {
                MessageBox.Show("Enter valid description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.ResetText();
                txtDesc.Clear();
                txtDesc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtServCost.Text))
            {
                MessageBox.Show("Cost is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServCost.ResetText();
                txtServCost.Clear();
                txtServCost.Focus();
                return;
            }
            else if ((Convert.ToInt32(txtServCost.Text)) < 1)
            {
                MessageBox.Show("Cost is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServCost.ResetText();
                txtServCost.Clear();
                txtServCost.Focus();
                return;
            }
                else
                {

                    //instantiate the Service variables
                    Service myService = new Service();
                    myService.setServID(Int32.Parse(this.cmbServiceID.SelectedItem.ToString().Substring(0, 3)));
                    myService.setDesc(txtDesc.Text);
                    myService.setDuration(Int32.Parse(this.cmbServDuration.SelectedItem.ToString().Substring(0, 3)));
                    myService.setCost(Convert.ToDecimal(txtServCost.Text));

                    //update the database
                    myService.updateService();



                    //All validation has passed the service can be changed
                    MessageBox.Show("The service has been modified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                    parent.Visible = true;
                
            }

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service myService = new Service();
           
          

            myService.getAService(Int32.Parse(this.cmbServiceID.SelectedItem.ToString().Substring(0,3)));
            //load service details onto form
            txtDesc.Text = myService.getDesc().ToString();
            cmbServDuration.SelectedIndex = myService.getDuration()-1;
            txtServCost.Text = myService.getCost().ToString();

            pnlChangeService.Visible = true;
            lblChangeService.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDesc.ResetText();
            txtServCost.ResetText();
            cmbServDuration.ResetText();

        }
    }
    }


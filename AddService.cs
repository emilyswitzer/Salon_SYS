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
    public partial class frmAddService : Form
    {
        frmMainMenu parent;

        

        public frmAddService(frmMainMenu Parent)
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

        public void frmMainMenu_Load(object sender, EventArgs e)
        {

            grdServices.DataSource = Service.getServices().Tables["Services"];
            //Load in Service IDs
            txtServiceID.Text = String.Format("{0:000}", Service.getNextID());

            //load combo with times for services
              DataSet ds = new DataSet();
               ds = Service.getTimes();
               for (int i = 0; i < ds.Tables["Time"].Rows.Count; i++)
                cmbServDuration.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                 " " + ds.Tables[0].Rows[i][1].ToString());


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearService_Click(object sender, EventArgs e)
        {
            //Clears all fields with values entered
            txtCost.Clear();
            txtServiceDesc.Clear();
            cmbServDuration.ResetText();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            //All fields must be entered before you can add a service
            if (txtCost.Text.Trim() == string.Empty || txtServiceDesc.Text.Trim() == string.Empty || txtServiceID.Text.Trim() == string.Empty
                 || cmbServDuration.SelectedIndex < 0)
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtServiceDesc.Text, "^[a-zA-Z-. ]*$"))
                {
                    MessageBox.Show("Enter valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtServiceDesc.ResetText();
                    txtServiceDesc.Clear();
                    txtServiceDesc.Focus();
                    return;
                }
                else
                {

                    if ((Convert.ToInt32(txtCost.Text)) < 1)
                    {
                        MessageBox.Show("Cost is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCost.ResetText();
                        txtCost.Clear();
                        txtCost.Focus();
                        return;
                    }
                    else {
                        String desc = txtServiceDesc.Text.ToString();
                        DataSet ds2 = new DataSet();
                        ds2 = Service.checkDesc(desc);
                        int i = ds2.Tables["desc"].Rows.Count;
                        if (i > 0)
                        {

                            MessageBox.Show("Service description already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtServiceDesc.ResetText();
                        }
                        else
                        {





                            //instantiate the service
                            Service s = new Service();
                            s.setServID(Convert.ToInt32(txtServiceID.Text));
                            s.setDesc(txtServiceDesc.Text);
                            s.setDuration(Int32.Parse(this.cmbServDuration.SelectedItem.ToString().Substring(0, 3)));
                            s.setCost(Convert.ToDecimal(txtCost.Text));
                            s.setStatus('A');

                            //add Service to the database
                            s.addService();




                            //All validation has passed the service can be added
                            MessageBox.Show("New service added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            parent.Visible = true;
                        }
                }

                }
            }  
        }

        private void txtServiceID_TextChanged(object sender, EventArgs e)
        {

        }

        public void cmbServDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
                  

        }

     

        private void txtServiceDesc_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }
    }
}

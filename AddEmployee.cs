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
    public partial class frmAddEmployee : Form
    {
        frmMainMenu parent;
        public frmAddEmployee(frmMainMenu Parent)
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
            grdEmployees.DataSource = Employee.getEmployees().Tables["Employees"];
            txtEmpID.Text = String.Format("{0:000}", Employee.getNextID());
            //load available services
            DataSet ds = new DataSet();
            ds = Service.getSummaryServices();
            for (int i = 0; i < ds.Tables["Services"].Rows.Count; i++)
                cmbEmpServices.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                " " + ds.Tables[0].Rows[i][1].ToString());
           
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

        private void btnClearEmpDetails_Click(object sender, EventArgs e)
        {
            //Clear all fields 
            txtEmpName.Clear();
            txtEmpSurname.Clear();
            txtEmpEmail.Clear();
            cmbEmpServices.ResetText();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
                Boolean t = Employee.ValidateEmail(txtEmpEmail.Text);
            if (!t)
            {
                MessageBox.Show("Enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmpEmail.ResetText();
                return;




            }
            else
            {
                //All fields must be entered before you can add a service
                if (txtEmpName.Text.Trim() == string.Empty || txtEmpID.Text.Trim() == string.Empty || txtEmpName.Text.Trim() == string.Empty
                    || txtEmpEmail.Text.Trim() == string.Empty || cmbEmpServices.SelectedIndex < 0)
                {
                    MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // return because we don't want to run normal code of button click
                }
                else
                {
                    String email = txtEmpEmail.Text.ToString();
                    DataSet dataset1 = new DataSet();
                    dataset1 = Employee.checkEmail(email);
                    int i = dataset1.Tables["emails"].Rows.Count;
                    if (i > 0)
                    {

                        MessageBox.Show("Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmpEmail.ResetText();
                        return;
                    }
                    //All validation has passed the employee can be added
                    //instantiate the Employee
                    Employee s = new Employee();
                    s.setEmpID(Convert.ToInt32(txtEmpID.Text));
                    s.setName(txtEmpName.Text);
                    s.setSurname(txtEmpSurname.Text);
                    s.setEmail(txtEmpEmail.Text);
                    s.setEmpStatus('A');

                    //add Service to the database
                    s.addEmployee();

                    s.providesService(Int32.Parse(this.cmbEmpServices.SelectedItem.ToString().Substring(0, 3)));


                    MessageBox.Show("Employee added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    parent.Visible = true;

                }
            } 
            
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtEmpName.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmpName.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpName.ResetText();
                    txtEmpName.Clear();
                    txtEmpName.Focus();
                }
            }
        }

        private void txtEmpSurname_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtEmpSurname.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmpSurname.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Enter Valid Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpSurname.ResetText();
                    txtEmpSurname.Clear();
                    txtEmpSurname.Focus();
                }
            }
        }

        private void txtEmpEmail_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbEmpServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

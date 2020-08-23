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
    public partial class frmDeleteEmployee : Form
    {
        frmMainMenu parent;
        public frmDeleteEmployee(frmMainMenu Parent)
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
            
            lblDeleteEmp.Visible = false;
            pnlDeleteEmployee.Visible = false;

            //load combo with employeeIDs
            DataSet ds = new DataSet();
            ds = Employee.getSummaryEmployees();
            for (int i = 0; i < ds.Tables["Employees"].Rows.Count; i++)
                cmbEmpID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                " " + ds.Tables[0].Rows[i][1].ToString());

        }

      

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //Dispose of this form
            this.Close();
            //Show the main menu
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnConfirmDeleteEmp_Click(object sender, EventArgs e)
        {
            
                //Check to see if there is an Employee selected. If there is it will delete them
                if (cmbEmpID.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Are you sure you want to remove Employee?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    //update the database
                    Employee myEmp = new Employee();
                    myEmp.setEmpID(Int32.Parse(this.cmbEmpID.SelectedItem.ToString().Substring(0, 3)));
                    myEmp.deleteEmp();
                    MessageBox.Show("Employee is no longer active", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    parent.Visible = true;
                    }
                }
                else
                MessageBox.Show("EmployeeID must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeleteEmp.BringToFront();
            lblDeleteEmp.Visible = true;
            pnlDeleteEmployee.Visible = true;


            Employee myEmp = new Employee();
            myEmp.getAnEmployee(Int32.Parse(this.cmbEmpID.SelectedItem.ToString().Substring(0, 3)));
            //load Employee details onto form
            txtEmpName.Text = myEmp.getName().ToString();
            txtEmpSurname.Text = myEmp.getSurname().ToString();
            txtEmpEmail.Text = myEmp.getEmail().ToString();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlDeleteEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


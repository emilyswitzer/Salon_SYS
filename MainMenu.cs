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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
         
            InitializeComponent();
          
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuHome_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            





        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide
          

            this.Hide();

            //Display frmService
            frmAddService nextForm = new frmAddService(this);
            nextForm.Show();
        }

        private void mnuChangeService_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();
           

            //Display frmService
            frmChangeService nextForm = new frmChangeService(this);
            nextForm.Show();
        }

        private void mnuDeleteService_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmDeleteService nextForm = new frmDeleteService(this);
            nextForm.Show();
        }

        private void mnuMakeAppt_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmMakeAppointment nextForm = new frmMakeAppointment(this);
            nextForm.Show();
        }

        private void mnuCancelAppt_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmCancelAppointment nextForm = new frmCancelAppointment(this);
            nextForm.Show();
        }

        private void mnuAddEmployee_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmAddEmployee nextForm = new frmAddEmployee(this);
            nextForm.Show();
        }

        private void mnuDeleteEmployee_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmDeleteEmployee nextForm = new frmDeleteEmployee(this);
            nextForm.Show();
        }

        private void mnuChkAvail_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmAvailability nextForm = new frmAvailability(this);
            nextForm.Show();
        }

        private void mnuRevAnalysis_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmService
            frmRevAnalysis nextForm = new frmRevAnalysis(this);
            nextForm.Show();
        }

        private void mnuGenSerAnalysis_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY window that you can use hide

            this.Hide();

            //Display frmServAnalysis
            frmServAnalysis nextForm = new frmServAnalysis(this);
            nextForm.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grdServicesMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

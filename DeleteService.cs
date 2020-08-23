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
    public partial class frmDeleteService : Form
    {
        frmMainMenu parent;
        public frmDeleteService(frmMainMenu Parent)
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
            lblDeleteServlbl.BringToFront();
            lblDeleteServlbl.Visible = false;
            pnlDeleteServ.Visible = false;

            //load combo with services
            DataSet ds = new DataSet();
            ds = Service.getSummaryServices();
            for (int i = 0; i < ds.Tables["Services"].Rows.Count; i++)
                cmbServices.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                " " + ds.Tables[0].Rows[i][1].ToString());

        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {

        }

        private void mnuDeleteService_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Check to see if there is an Employee selected. If there is it will delete them
            if (cmbServices.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to remove Service?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Int32.Parse(this.cmbServices.SelectedItem.ToString().Substring(0, 3));
                    DataSet ds1 = new DataSet();
                    ds1 = Service.checkIfBooked(id);
                    int i = ds1.Tables["active"].Rows.Count;
                    if (i > 0)
                    {

                        MessageBox.Show("Service is booked! Cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }




                    else
                    {
                        //update the database
                        Service s = new Service();
                        s.setServID(Int32.Parse(this.cmbServices.SelectedItem.ToString().Substring(0, 3)));
                        s.deleteService();
                        MessageBox.Show("Service is no longer active", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        parent.Visible = true;
                    }
                }
                else
                    MessageBox.Show("ServiceID must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeleteServlbl.BringToFront();
            pnlDeleteServ.Visible = true;
            lblDeleteServlbl.Visible = true;

            Service myService = new Service();
            myService.getAService(Int32.Parse(this.cmbServices.SelectedItem.ToString().Substring(0, 3)));
            //load service details onto form
            txtDesc.Text = myService.getDesc().ToString();
            txtServDuration.Text = myService.getDuration().ToString();
            txtServCost.Text = myService.getCost().ToString();
        }
        private void pnlDeleteServ_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

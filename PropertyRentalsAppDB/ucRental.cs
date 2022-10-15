using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;


namespace PropertyRentalsAppDB
{
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
      
        private void ucRental_Load(object sender, EventArgs e)
        {
            cmbPropertyTenant.DataSource = bll.GetPropertyAgentDate();
            cmbPropertyTenant.DisplayMember = "Date";
            cmbPropertyTenant.ValueMember = "PropertyAgentID";

            cmbTenant.DataSource = bll.GetTenantByName();
            cmbTenant.DisplayMember = "Tenant";
            cmbTenant.ValueMember = "TenantID";
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();

            rental.PropertyAgentID = int.Parse(cmbPropertyTenant.SelectedValue.ToString());
            rental.TenantID = int.Parse(cmbTenant.SelectedValue.ToString());
            rental.StartDate = dtpStartDate.Text;
            rental.EndDate = dtpEndDate.Text;

            int x = bll.InsertRental(rental);
            if (x > 0)
            {
                MessageBox.Show(x + " Rental Added!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();

            rental.RentalID = int.Parse(txtRentalID.Text);
            rental.StartDate = dtpStartDate.Text;
            rental.EndDate = dtpEndDate.Text;

            int x = bll.UpdateRental(rental);
            if (x > 0)
            {
                MessageBox.Show(x + " Rental Updated!");
            }
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropertyTenant.SelectedText = dgvRental.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbTenant.SelectedText = dgvRental.SelectedRows[0].Cells["Tenant"].Value.ToString();
                dtpStartDate.Text = dgvRental.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtpEndDate.Text = dgvRental.SelectedRows[0].Cells["EndDate"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.GetRental();
        }
    }
}

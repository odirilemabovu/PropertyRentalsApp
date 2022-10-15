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
using System.Text.RegularExpressions;

namespace PropertyRentalsAppDB
{
    public partial class ucAgency : UserControl
    {
        public ucAgency()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucAgency_Load(object sender, EventArgs e)
        {
            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtAgencyName.Text))
            {
                errSurbub.SetError(txtAgencyName, "Please enter name");
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();

            if (Validation() == true)
            {
                agency.AgencyName = txtAgencyName.Text;
                agency.SurbubID = int.Parse(cmbSurbub.SelectedValue.ToString());

                int x = bll.InsertAgency(agency);
                if (x > 0)
                {
                    MessageBox.Show(x + " Agency Added!");

                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.DisplayAgency();
        }

        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgency.SelectedRows.Count > 0)
            {
                txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSurbub.Text = dgvAgency.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();

            agency.AgencyID = int.Parse(txtAgencyID.Text);

            int x = bll.DeleteAgency(agency);
            if (x > 0)
            {
                MessageBox.Show(x + " Agency deleted!");
            }
        }

        private void txtAgencyID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PropertyRentalsAppDB
{
    public partial class ucSurbub : UserControl
    {
        public ucSurbub()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
      
        private void ucSurbub_Load(object sender, EventArgs e)
        {
            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "CityDescription";
            cmbCity.ValueMember = "CityID";
        }
        
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtSurbubDesc.Text))
            {
                errSurbub.SetError(txtSurbubDesc, "Please enter a valid description");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                errSurbub.SetError(txtPostalCode, "Please enter a valid postal code");
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
            Surbub surbub = new Surbub();

            if (Validation() == true)
            {
                surbub.SurbubDescription = txtSurbubDesc.Text;
                surbub.PostalCode = txtPostalCode.Text;
                surbub.CityID = int.Parse(cmbCity.SelectedValue.ToString());

                int x = bll.InsertSurbub(surbub);
                if (x > 0)
                {
                    MessageBox.Show(x + " Surbub Added!");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSurbub.DataSource = bll.GetSurbub();
        }

        private void dgvSurbub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSurbub.SelectedRows.Count > 0)
            {
                txtSurbubID.Text = dgvSurbub.SelectedRows[0].Cells["SurbubID"].Value.ToString();
                txtSurbubDesc.SelectedText = dgvSurbub.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                txtPostalCode.Text = dgvSurbub.SelectedRows[0].Cells["PostalCode"].Value.ToString();
                cmbCity.SelectedText = dgvSurbub.SelectedRows[0].Cells["CityDescription"].Value.ToString();

            }
        }
    }
}

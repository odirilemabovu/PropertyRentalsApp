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
    public partial class ucTenant : UserControl
    {
        public ucTenant()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucTenant_Load(object sender, EventArgs e)
        {
            cmbTenant.Items.Add("Available");
            cmbTenant.Items.Add("Unavailable");
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errTenant.SetError(txtName, "Please enter Name");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errTenant.SetError(txtSurname, "Please enter Surname");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errTenant.SetError(txtEmail, "Please enter a valid email");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errTenant.SetError(txtPassword, "Please enter a valid password");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errTenant.SetError(txtPhone, "Please enter a phone number");
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
            Tenant tenant = new Tenant();

            if (Validation() == true)
            {
                tenant.Name = txtName.Text;
                tenant.Surname = txtSurname.Text;
                tenant.Email = txtEmail.Text;
                tenant.Password = txtEmail.Text;
                tenant.Phone = txtPhone.Text;
                tenant.Status = cmbTenant.SelectedItem.ToString();

                int x = bll.InsertTenant(tenant);
                if (x > 0)
                {
                    MessageBox.Show(x + " Tenant added!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            if (Validation() == true)
            {
                tenant.TenantID = int.Parse(txtTenantID.Text);
                tenant.Email = txtEmail.Text;
                tenant.Phone = txtPhone.Text;
                tenant.Status = cmbTenant.SelectedItem.ToString();

                int x = bll.UpdateTenant(tenant);
                if (x > 0)
                {
                    MessageBox.Show(x + " Tenant updated!");
                }
            }
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbTenant.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();

            tenant.TenantID = int.Parse(txtTenantID.Text);

            int x = bll.DeleteTenant(tenant);
            if (x > 0)
            {
                MessageBox.Show(x + " Tenant deleted!");
            }
        }
    }
}

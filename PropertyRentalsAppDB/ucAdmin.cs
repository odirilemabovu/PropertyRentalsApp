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
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucAdmin_Load(object sender, EventArgs e)
        {
            cmbAdmin.Items.Add("Available");
            cmbAdmin.Items.Add("Unavailable");
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAdmin.SetError(txtName, "Please enter Name");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errAdmin.SetError(txtSurname, "Please enter Surname");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errAdmin.SetError(txtEmail, "Please enter a valid email");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errAdmin.SetError(txtPassword, "Please enter a valid password");
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;

        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            if (Validation() == true)
            {
                admin.Name = txtName.Text;
                admin.Surname = txtSurname.Text;
                admin.Email = txtEmail.Text;
                admin.Password = txtEmail.Text;
                admin.Status = cmbAdmin.SelectedItem.ToString();

                int x = bll.InsertAdmin(admin);
                if (x > 0)
                {
                    MessageBox.Show(x + " Admin added!");
                }
            }

        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                txtAdminID.Text = dgvAdmin.SelectedRows[0].Cells["AdminID"].Value.ToString();
                txtName.Text = dgvAdmin.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAdmin.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAdmin.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAdmin.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbAdmin.Text = dgvAdmin.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = bll.GetAdmin();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            if (Validation() == true)
            {
                admin.AdminID = int.Parse(txtAdminID.Text);
                admin.Email = txtEmail.Text;
                admin.Password = txtPassword.Text;
                admin.Status = cmbAdmin.SelectedItem.ToString();

                int x = bll.UpdateAdmin(admin);
                if (x > 0)
                {
                    MessageBox.Show(x + " Admin updated!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminID = int.Parse(txtAdminID.Text);

            int x = bll.DeleteAdmin(admin);
            if (x > 0)
            {
                MessageBox.Show(x + " Admin deleted");
            }
        }
    }
}

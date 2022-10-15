using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PropertyRentalsAppDB
{
    public partial class Go_to_Sign_in_Page : Form
    {
        public Go_to_Sign_in_Page()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.SignIn(txtUserName.Text, txtPassword.Text);
            string role = dt.Rows[0]["RoleDescription"].ToString();
            string user = dt.Rows[0]["Email"].ToString();
            string password = dt.Rows[0]["Password"].ToString();


            if (dt.Rows.Count > 0)
            {
                if (role == "Admin" && txtPassword.Text == password && txtUserName.Text == user)
                {
                    frmAdministrator form = new frmAdministrator();
                    form.Show();
                    this.Hide();
                }
                else if (role == "Agent"/* && txtPassword.Text == password && txtUserName.Text == user*/)
                {
                    frmAgent form = new frmAgent();
                    form.Show();
                    this.Hide();
                }
                else if (role == "Tenant"/* && txtPassword.Text == password && txtUserName.Text == user*/)
                {
                    frmTenant form = new frmTenant();
                    form.Show();
                    this.Hide();
                }

            }
            else
            {
                txtPassword.Clear();
                txtUserName.Clear();
                MessageBox.Show("Wrong User Name or Password");
            }




            //User user = new User();
            //DataTable dt = bll.SignIn(txtUserName.Text,txtPassword.Text,cmbRole.Text);
            //string role = dt.Rows[0]["RoleDescription"].ToString();
            ////string userName = dt.Rows[0]["Email"].ToString();
            ////string password = dt.Rows[0]["Password"].ToString();
            ////User user = new User();
            //user.Email = txtUserName.Text;
            //user.Password = txtPassword.Text;
            ////Stop stop stop //Stop stop stop //Stop stop stop
            //if (dt.Rows.Count > 0)
            //{
            //    for(int x =0; x <dt.Rows.Count; x ++)
            //    {
            //        if(dt.Rows[x][role].ToString()== cmbRole.SelectedItem.ToString())
            //        {
            //            frmAdministrator form = new frmAdministrator();
            //            form.Show();
            //            this.Hide();
            //        }
            //    }
            //    //if (dt.Rows.Count > 0 && role == "Admin")
            //    //{
            //    //    frmAdministrator form = new frmAdministrator();
            //    //    form.Show();
            //    //    this.Hide();

            //    //}
            //    //else if (dt.Rows.Count > 0 && role == "Agent")
            //    //{
            //    //    frmAgent form = new frmAgent();
            //    //    form.Show();
            //    //    this.Hide();
            //    //}
            //    //else if (dt.Rows.Count > 0 && role == "Tenant")
            //    //{
            //    //    frmTenant form = new frmTenant();
            //    //    form.Show();
            //    //    this.Hide();
            //    //}
            //}


            //else if (dt.Rows.Count == 0)
            //{
            //    txtPassword.Clear();
            //    txtUserName.Clear();
            //    MessageBox.Show("Wrong User Name or Password");

            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            ptbShow.BringToFront();
        }

        private void ptbShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            ptbHide.BringToFront();
        }
    }
}

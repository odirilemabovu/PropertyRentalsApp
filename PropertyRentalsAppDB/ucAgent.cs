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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PropertyRentalsAppDB
{
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucAgent_Load(object sender, EventArgs e)
        {
            //cmbAgency.DataSource = bll.GetAgencyByName();
            cmbAgency.DataSource = bll.GetAgencyByName();
            cmbAgency.DisplayMember = "Agency";
            cmbAgency.ValueMember = "AgencyID";

            cmbAgentStatus.Items.Add("Available");
            cmbAgentStatus.Items.Add("Unavailable");
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAgent.SetError(txtName, "Please enter Name");
                valid = false;
            }
            else if(string.IsNullOrEmpty(txtSurname.Text))
            {
                errAgent.SetError(txtSurname, "Please enter Surname");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errAgent.SetError(txtEmail, "Please enter a valid email");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errAgent.SetError(txtPassword, "Please enter a valid password");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errAgent.SetError(txtPhone, "Please enter a phone number");
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
            DAL.Agent agent = new DAL.Agent();

            if (Validation() == true)
            {
                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.Email = txtEmail.Text;
                agent.Password = txtPassword.Text;
                agent.Phone = txtPhone.Text;
                agent.Status = cmbAgentStatus.SelectedItem.ToString();
                agent.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());
                agent.RoleID = int.Parse(cmbRoleDescription.SelectedValue.ToString());

                int x = bll.InsertAgent(agent);
                if (x > 0)
                {
                    MessageBox.Show(x + " Agent added!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL.Agent agent = new DAL.Agent();

            if (Validation() == true)
            {
                agent.AgentID = int.Parse(txtAgentID.Text);
                agent.Email = txtEmail.Text;
                agent.Phone = txtPhone.Text;
                agent.Password = txtPassword.Text;
                agent.Status = cmbAgentStatus.SelectedItem.ToString();

                int x = bll.UpdateAgent(agent);
                if (x > 0)
                {
                    MessageBox.Show(x + " Agent updated!");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DAL.Agent agent = new DAL.Agent();

            agent.AgentID = int.Parse(txtAgentID.Text);

            int x = bll.DeleteAgent(agent);
            if (x > 0)
            {
                MessageBox.Show(x + " Agent deleted!");
            }
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            {
                txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbAgentStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgency.Text = dgvAgent.SelectedRows[0].Cells["Agency Name"].Value.ToString();
            }
        }
    }
}

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
using System.Security.Cryptography;

namespace PropertyRentalsAppDB
{
    public partial class ucPropertyAgent : UserControl
    {
        public ucPropertyAgent()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucPropertyAgent_Load(object sender, EventArgs e)
        {
            cmbProperty.DataSource = bll.GetProperties();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";

            cmbAgent.DataSource = bll.GetAgentByName();
            cmbAgent.DisplayMember = "Full Name";
            cmbAgent.ValueMember = "AgentID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyAgent = new PropertyAgent();

            propertyAgent.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            propertyAgent.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            propertyAgent.Date = dtpDate.Text;
            int x = bll.InsertPropertyAgent(propertyAgent);
            if (x > 0)
            {
                MessageBox.Show(x + " Property Agent Added!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyAgent = new PropertyAgent();
            propertyAgent.PropertyAgentID = int.Parse(txtPropertyAgent.Text);
            propertyAgent.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            propertyAgent.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            propertyAgent.Date = dtpDate.Text;
            int x = bll.UpdatePropertyAgent(propertyAgent);
            if (x > 0)
            {
                MessageBox.Show(x + " Property Agent Updated!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.PropertyAgentDisplay();
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyAgent.SelectedRows.Count > 0)
            {
                txtPropertyAgent.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbProperty.Text = dgvPropertyAgent.SelectedRows[0].Cells["Description"].Value.ToString();
                cmbAgent.Text = dgvPropertyAgent.SelectedRows[0].Cells["Full Name"].Value.ToString();
                dtpDate.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();
            }
        }
    }
}

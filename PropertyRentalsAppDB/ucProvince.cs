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
    public partial class ucProvince : UserControl
    {
        public ucProvince()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucProvince_Load(object sender, EventArgs e)
        {
            
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errProvince.SetError(txtDescription, "Please enter a valid description");
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

            Province province = new Province();

            if (Validation() == true)
            {
                province.Description = txtDescription.Text;

                int x = bll.InsertProvince(province);
                if (x > 0)
                {
                    MessageBox.Show(x + " Province Added!");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetProvince();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtProvinceID.Text = dataGridView1.SelectedRows[0].Cells["ProvinceID"].Value.ToString();
                txtDescription.Text = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
            }
        }
    }

    
    
}

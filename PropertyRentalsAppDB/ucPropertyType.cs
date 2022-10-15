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
    public partial class ucPropertyType : UserControl
    {
        public ucPropertyType()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtPropertyTypeDesc.Text))
            {
                errorProprtyType.SetError(txtPropertyTypeDesc, "Please enter a valid description");
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
            PropertyType propertyType = new PropertyType();

            if (Validation() == true)
            {
                propertyType.PropertyTypeDesc = txtPropertyTypeDesc.Text;


                int x = bll.InsertPropertyType(propertyType);
                if (x > 0)
                {
                    MessageBox.Show(x + " Property Type Added!");
                }
            }
        }

        private void dgvPropertyType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyType.SelectedRows.Count > 0)
            {
                txtPropertyTypeID.Text = dgvPropertyType.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                txtPropertyTypeDesc.Text = dgvPropertyType.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.GetPropertyType();
        }
    }
}

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
    public partial class ucCity : UserControl
    {
        public ucCity()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void ucCity_Load(object sender, EventArgs e)
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";
        }
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtCityDesc.Text))
            {
                errCity.SetError(txtCityDesc, "Please enter a valid description");
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;

        }

        private void btbnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();

            if (Validation() == true)
            {
                city.CityDescription = txtCityDesc.Text;
                city.ProvinceID = int.Parse(cmbProvince.SelectedValue.ToString());

                int x = bll.InsertCity(city);
                if (x > 0)
                {
                    MessageBox.Show(x + " City Added!");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.GetCity();
        }

        private void dgvCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCity.SelectedRows.Count > 0)
            {
                txtCityID.Text = dgvCity.SelectedRows[0].Cells["CityID"].Value.ToString();
                txtCityDesc.SelectedText = dgvCity.SelectedRows[0].Cells["CityDescription"].Value.ToString();
                cmbProvince.Text = dgvCity.SelectedRows[0].Cells["Description"].Value.ToString();
            }
        }
    }
}

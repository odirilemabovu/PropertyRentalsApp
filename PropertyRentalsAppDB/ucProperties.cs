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
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace PropertyRentalsAppDB
{
    public partial class ucProperties : UserControl
    {
        public ucProperties()
        {
            InitializeComponent();
        }

        BussinessLogicLayer bll = new BussinessLogicLayer();

        public static byte[] ImageToByte(Image img) //To change Image to binary
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        } 
        public bool Validation()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errorProperty.SetError(txtDesc, "Please enter a valid description");
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPrice.Text) || !Regex.IsMatch(txtPrice.Text, @"(\d+(?:\.\d+)?)\D*$"))
            {
                errorProperty.SetError(txtPrice, "Please enter a valid price");
                valid = false;
            }
            else if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProperty.SetError(cmbStatus, "Please enter a Status");
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;

        }


        private void ucProperties_Load(object sender, EventArgs e)
        {
            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";

            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }
 
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Property property = new Property();

            if (Validation() == true)
            {
                property.Description = txtDesc.Text;
                property.Price = double.Parse(txtPrice.Text);
                // NB!!! Image is still missing
                property.Image = ImageToByte(ptbProperty.Image);
                property.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
                property.SurbubID = int.Parse(cmbSurbub.SelectedValue.ToString());
                property.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.InsertProperties(property);
                if (x > 0)
                {
                    MessageBox.Show(x + " Property Added!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Property property = new Property();

            if (Validation() == true)
            {
                property.PropertyID = int.Parse(txtPropertyID.Text);
               
                property.Price = double.Parse(txtPrice.Text);
                //property.Image = ImageToByte(ptbProperty.Image); //To change Image to binary
                property.Status = cmbStatus.SelectedItem.ToString();
                property.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
                

                int x = bll.UpdateProperties(property);
                if (x > 0)
                {
                    MessageBox.Show(x + " Property Updated!");
                }
            }
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.GetProperties();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Property property = new Property();

            property.PropertyID = int.Parse(txtPropertyID.Text);

            int x = bll.DeleteProperties(property);
            if (x > 0)
            {
                MessageBox.Show(x + " Property Deleted!");
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbProperty.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void dgvProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperty.SelectedRows.Count > 0)
            {
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtDesc.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                //Image still missing
                byte[] bytes = (byte[])dgvProperty.SelectedRows[0].Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                ptbProperty.Image = img;
                cmbPropertyType.SelectedText = dgvProperty.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
                cmbSurbub.Text = dgvProperty.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }
    }
}

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

namespace PropertyRentalsAppDB
{
    public partial class frmAdministrator : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public frmAdministrator()
        {
            InitializeComponent();
            random = new Random();
            //remove border
            this.Text = string.Empty;
            this.ControlBox = false;
            customizedesing();
            //    ucAdmin1.Show();
            //    ucAgency1.Hide();
            //    ucAgent1.Hide();
            //    ucCity1.Hide();
            //    ucProperties1.Hide();
            //    ucPropertyAgent1.Hide();
            //    ucPropertyType1.Hide();
            //    ucProvince1.Hide();
            //    ucRental1.Hide();
            //    ucSurbub1.Hide();
            //    ucTenant1.Hide();
        }
       
        private void customizedesing()
        {
            pnlHome.Visible = false;
        }
        private void hideMenu()
        {
            if(pnlHome.Visible ==true)
            {
                pnlHome.Visible = false;
            }
        }
        private void showMenu(Panel showMune)
        {
            if(showMune.Visible == false)
            {
                hideMenu();
                showMune.Visible = true;
            }
            else
            {
                showMune.Visible = false;

            }
        }
        private Color SelectThemeColor()//for color
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)//To highlight selected button
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisablbleButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);// to increase font size of selected button
                    pnlTitle.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }

        }
        //To deselect button(s)
        private void DisablbleButton()
        {
            foreach (Control previousBtn in pnlSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);// to decrease font size of selected button
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            showMenu(pnlHome);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnAdministratorPage_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnsurbub_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            hideMenu();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
           ;
            mouseDown = true;
            lastLocation = e.Location;
        }
        //To drag form
        private bool mouseDown;
        private Point lastLocation;
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState  == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y + e.Y));
            }
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

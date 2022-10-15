using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRentalsAppDB
{
    public partial class frmAgent : Form
    {
        internal string Surname;

        public frmAgent()
        {
            InitializeComponent();
        }

        public string Email { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form userManagement = new FormUserManagement();
            userManagement.Show();
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormAccountPopup : Form
    {
        private IBusinessTier.IBusinessTier data;
        private string firstName = "";
        private string lastName = "";

        public FormAccountPopup(IBusinessTier.IBusinessTier data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            createOrManageUser("CREATE");
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
           createOrManageUser("MANAGE");
        }

        private void createOrManageUser(string action)
        {
            string userID = textUserID.Text;

            if (userID == "")
            {
                MessageBox.Show("Please Enter User ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.data.SelectUser(Convert.ToUInt32(userID));
                try
                {
                    this.data.GetUserName(out firstName, out lastName);

                    if (action.Equals("CREATE"))
                    {
                        this.data.CreateAccount(Convert.ToUInt32(userID));
                        MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Form manageAccountForm = new FormAccountManagement(this.data, Convert.ToUInt32(userID));
                        manageAccountForm.Show();
                        Close();
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textUserID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

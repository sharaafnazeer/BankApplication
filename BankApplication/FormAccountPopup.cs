using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.BLL;

namespace BankApplication
{
    public partial class FormAccountPopup : Form
    {
        private UserClass user;
        private AccountClass accountClass;
        private string firstName = "";
        private string lastName = "";

        public FormAccountPopup()
        {
            InitializeComponent();
            user = new UserClass();
            accountClass = new AccountClass();
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
                user.SelectUser(Convert.ToUInt32(userID));
                try
                {
                    user.GetUserName(out firstName, out lastName);

                    if (action.Equals("CREATE"))
                    {
                        accountClass.CreateAccount(Convert.ToUInt32(userID));
                        MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Form manageAccountForm = new FormAccountManagement(Convert.ToUInt32(userID));
                        manageAccountForm.Show();
                        Close();
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

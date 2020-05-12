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
    public partial class FormUserManagement : Form
    {
        private UserClass user;

        public FormUserManagement()
        {
            InitializeComponent();
            user = new UserClass();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            uint userID = user.CreateUser();

            MessageBox.Show("User Created Successfully! \nUser ID => " + userID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<uint> userList = user.GetUsers();
            string ids = "";
            foreach (var user in userList)
            {
                ids += user.ToString() +", ";
            }

            MessageBox.Show(ids);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string userID = textUserID.Text;
            string firstName = "";
            string lastName = "";
            if (userID == "")
            {
                MessageBox.Show("Please Enter User ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.SelectUser(Convert.ToUInt32(userID));
                user.GetUserName(out firstName, out lastName);

                textFirstName.Text = firstName;
                textLastName.Text = lastName;
            }

        }

        private void FormUserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;

            if (firstName == "")
            {
                MessageBox.Show("Please Enter First Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lastName == "")
            {
                MessageBox.Show("Please Enter Last Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.SetUserName(firstName, lastName);
                user.GetUserName(out firstName, out lastName);
                MessageBox.Show("Hello! " + firstName + " " + lastName + ". Your User Account is Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

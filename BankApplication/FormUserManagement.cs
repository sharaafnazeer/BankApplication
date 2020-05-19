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
    public partial class FormUserManagement : Form
    {
        private BusinessTier.BusinessTier data;

        public FormUserManagement(BusinessTier.BusinessTier data)
        {
            InitializeComponent();
            this.data = data;

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            uint userID = this.data.CreateUser();

            textUserID.Text = userID.ToString();

            MessageBox.Show("User Created Successfully! \nUser ID => " + userID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.data.SelectUser(Convert.ToUInt32(userID));
                try
                {
                    this.data.GetUserName(out firstName, out lastName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

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

                try
                {
                    this.data.SetUserName(firstName, lastName);
                    this.data.GetUserName(out firstName, out lastName);

                    MessageBox.Show("Hello! " + firstName + " " + lastName + ". Your User Account is Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }

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

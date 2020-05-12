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
    public partial class FormAccountManagement : Form
    {
        private UserClass user;
        private AccountClass accountClass;
        private uint userID;
        private string firstName;
        private string lastName;
        private uint accountID;

        public FormAccountManagement(uint userID)
        {
            InitializeComponent();
            user = new UserClass();
            accountClass = new AccountClass();
            this.userID = userID;
        }

        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            cmbAccountIDs.SelectedIndex = 0;
            lblUserID.Text = userID.ToString();

            user.SelectUser(Convert.ToUInt32(userID));
            user.GetUserName(out firstName, out lastName);


            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;


            feedAccountIDs();

        }
        private void feedAccountIDs()
        {
            List<uint> accountList = accountClass.GetAccountIDsByUser(userID);

            foreach (var account in accountList)
            {
                cmbAccountIDs.Items.Add(account);
            }
        }

        private void cmbAccountIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountIDs.SelectedIndex > 0)
            {
                selectAccount();
                uint accountBalance = accountClass.GetBalance();
                lblAccountBalance.Text = String.Format("{0:0,0.00}", accountBalance);
            }
            else
            {
                lblAccountBalance.Text = "";
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                uint amount = Convert.ToUInt32(textAmount.Text);

                selectAccount();
                accountClass.Deposit(amount);
                lblAccountBalance.Text = String.Format("{0:0,0.00}", accountClass.GetBalance());

                MessageBox.Show("Amount Deposited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void selectAccount()
        {
            accountID = Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString());
            accountClass.SelectAccount(accountID);
        }

        private bool validateInputs()
        {
            if (cmbAccountIDs.SelectedIndex == 0)
            {
                MessageBox.Show("Select a Account ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textAmount.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Amount", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Convert.ToUInt32(textAmount.Text) < 1)
            {
                MessageBox.Show("Please Enter a Valid Amount", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnWidraw_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                uint amount = Convert.ToUInt32(textAmount.Text);

                selectAccount();

                if (accountClass.isBalanceAvailable(amount))
                {
                    try
                    {
                        accountClass.Withdraw(amount);
                        lblAccountBalance.Text = String.Format("{0:0,0.00}", accountClass.GetBalance());
                        MessageBox.Show("Amount Withdrawn Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your Balance Is not Enough to Continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }
    }
}

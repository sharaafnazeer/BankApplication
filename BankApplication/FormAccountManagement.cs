using System;
using System.Collections;
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
    public partial class FormAccountManagement : Form
    {
        private IBusinessTier.IBusinessTier data;
        private uint userID;
        private string firstName;
        private string lastName;
        private uint accountID;

        public FormAccountManagement(IBusinessTier.IBusinessTier data, uint userID)
        {
            InitializeComponent();
            this.data = data;
            this.userID = userID;
        }

        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            cmbAccountIDs.SelectedIndex = 0;
            lblUserID.Text = userID.ToString();

            this.data.SelectUser(Convert.ToUInt32(userID));
            this.data.GetUserName(out firstName, out lastName);


            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;


            feedAccountIDs();

        }
        private async void feedAccountIDs()
        {
            ArrayList accountList =  await data.GetAccountIDsByUser(userID);

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
                uint accountBalance = this.data.GetBalance();
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
                this.data.Deposit(amount);
                lblAccountBalance.Text = String.Format("{0:0,0.00}", this.data.GetBalance());

                MessageBox.Show("Amount Deposited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void selectAccount()
        {
            accountID = Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString());
            this.data.SelectAccount(accountID);
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

                if (this.data.isBalanceAvailable(amount))
                {
                    try
                    {
                        this.data.Withdraw(amount);
                        lblAccountBalance.Text = String.Format("{0:0,0.00}", this.data.GetBalance());
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

        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

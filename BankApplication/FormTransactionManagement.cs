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
    public partial class FormTransactionManagement : Form
    {
        private uint transactionID;
        private uint accountID;
        private uint userID;

        private IBusinessTier.IBusinessTier data;

        public FormTransactionManagement(IBusinessTier.IBusinessTier data, uint userID)
        {
            InitializeComponent();
            this.data = data;
            this.userID = userID;
        }

        private void FormTransactionManagement_Load(object sender, EventArgs e)
        {
            feedAccountIDs();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (textTransactionID.Text == "")
            {
                MessageBox.Show("Please Enter Transaction ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validateInputs())
                {
                    if (this.data.isBalanceAvailable(Convert.ToUInt32(textAmount.Text)))
                    {
                        transactionID = Convert.ToUInt32(textTransactionID.Text);
                        this.data.SelectTransaction(transactionID);
                        this.data.SetSendr(Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString()));
                        this.data.SetRecvr(Convert.ToUInt32(textReceiverAccountID.Text));
                        this.data.SetAmount(Convert.ToUInt32(textAmount.Text));

                        MessageBox.Show("Amount Transferred Successfully \n\nTransaction ID -> " + transactionID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Your Balance Is not Enough to Continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }
            }
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            uint transactionID = this.data.CreateTransaction();
            MessageBox.Show("Transaction Created Successfully \n\nTransaction ID -> " + transactionID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textTransactionID.Text = transactionID.ToString();

        }

        private bool validateInputs()
        {
            if (cmbAccountIDs.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Sender Account ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textReceiverAccountID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Receiver Account ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormTransactionManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
//            transactionClass.ProcessAndSave();
        }

        private async void feedAccountIDs()
        {
            ArrayList accountList = await data.GetAccountIDsByUser(userID);

            cmbAccountIDs.Items.Clear();
            lbSearchResults.Items.Clear();
            foreach (var account in accountList)
            {
                cmbAccountIDs.Items.Add(account);
                cmbSearchAccountIDs.Items.Add(account);
            }
        }

        private void cmbAccountIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectAccount();
            uint accountBalance = this.data.GetBalance();
            lblAccountBalance.Text = String.Format("{0:0,0.00}", accountBalance);
        }

        private void selectAccount()
        {
            accountID = Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString());
            this.data.SelectAccount(accountID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearchTrans_Click(object sender, EventArgs e)
        {
            if (cmbSearchAccountIDs.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Account ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList transactionsByAccount = await data.GetTransactionsByAccount(
                    Convert.ToUInt32(cmbSearchAccountIDs.SelectedItem.ToString()));
                lbSearchResults.Items.Clear();

                foreach (var trans in transactionsByAccount)
                {
                    lbSearchResults.Items.Add(trans);
                }
            }
        }

        private void lbSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint transactionID = Convert.ToUInt32(lbSearchResults.SelectedItem.ToString());

            this.data.SelectTransaction(transactionID);
            lblSenderAccountID.Text = this.data.GetSendrAcct().ToString();
            lblReceiverAccountID.Text = this.data.GetRecvrAcct().ToString();
            lblAmount.Text = String.Format("{0:0,0.00}", this.data.GetAmount());
        }

        private void textReceiverAccountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textTransactionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

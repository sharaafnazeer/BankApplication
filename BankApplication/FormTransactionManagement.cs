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
    public partial class FormTransactionManagement : Form
    {
        private TransactionClass transactionClass;
        private AccountClass accountClass;
        private uint transactionID;
        private uint accountID;
        private uint userID;

        public FormTransactionManagement(TransactionClass transactionClass, uint userID)
        {
            InitializeComponent();
            this.transactionClass = transactionClass;
            this.accountClass = new AccountClass();
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
                    if (accountClass.isBalanceAvailable(Convert.ToUInt32(textAmount.Text)))
                    {
                        transactionID = Convert.ToUInt32(textTransactionID.Text);
                        transactionClass.SelectTransaction(transactionID);
                        transactionClass.SetSendr(Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString()));
                        transactionClass.SetRecvr(Convert.ToUInt32(textReceiverAccountID.Text));
                        transactionClass.SetAmount(Convert.ToUInt32(textAmount.Text));

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
            uint transactionID = transactionClass.CreateTransaction();
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

        private void btnCheckTransaction_Click(object sender, EventArgs e)
        {
            if (textTransactionID.Text == "")
            {
                MessageBox.Show("Please Enter Transaction ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                transactionID = Convert.ToUInt32(textTransactionID.Text);
                transactionClass.SelectTransaction(transactionID);
            }
        }

        private void FormTransactionManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
//            transactionClass.ProcessAndSave();
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
            selectAccount();
            uint accountBalance = accountClass.GetBalance();
            lblAccountBalance.Text = accountBalance.ToString();
        }

        private void selectAccount()
        {
            accountID = Convert.ToUInt32(cmbAccountIDs.SelectedItem.ToString());
            accountClass.SelectAccount(accountID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormTransactionPopup : Form
    {
        private TransactionClass transactionClass;
        private UserClass userClass;

        public FormTransactionPopup(TransactionClass transactionClass)
        {
            InitializeComponent();
            this.transactionClass = transactionClass;
            userClass = new UserClass();
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnManageTransaction_Click(object sender, EventArgs e)
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
                
                try
                {
                    userClass.SelectUser(Convert.ToUInt32(userID));
                    userClass.GetUserName(out firstName, out lastName);
                    Form accountTransaction = new FormTransactionManagement(transactionClass, Convert.ToUInt32(userID));
                    accountTransaction.Show();
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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

        public FormTransactionPopup()
        {
            InitializeComponent();
            transactionClass = new TransactionClass();;
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            uint transactionID = transactionClass.CreateTransaction();
            MessageBox.Show("Transaction Created Successfully \nTransaction ID -> " + transactionID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textTransactionID.Text = transactionID.ToString();

        }

        private void btnManageTransaction_Click(object sender, EventArgs e)
        {
            string transactionID = textTransactionID.Text;

            if (transactionID == "")
            {
                MessageBox.Show("Please Enter Transaction ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                transactionClass.SelectTransaction(Convert.ToUInt32(transactionID));
                transactionClass.SetSendr(516530833);
                transactionClass.SetRecvr(924639982);
                transactionClass.SetAmount(1000);

                transactionClass.ProcessAndSave();


                Form transactionForm = new FormTransactionManagement(Convert.ToUInt32(transactionID));
                transactionForm.Show();
            }
        }
    }
}

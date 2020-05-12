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
    public partial class FormMain : Form
    {
        private TransactionClass transactionClass;

        public FormMain()
        {
            InitializeComponent();
            transactionClass = new TransactionClass();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form userManagement = new FormUserManagement();
            userManagement.Show();
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            Form accountManagement = new FormAccountPopup();
            accountManagement.Show();
        }

        private void btnTransactionManagement_Click(object sender, EventArgs e)
        {
            Form accountTransaction = new FormTransactionPopup(transactionClass);
            accountTransaction.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            transactionClass.ProcessAndSave();
        }
    }
}

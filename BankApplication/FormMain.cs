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
    public partial class FormMain : Form
    {
//        private TransactionClass transactionClass;

        private BusinessTier.BusinessTier data;

        public FormMain()
        {
            InitializeComponent();
            //            transactionClass = new TransactionClass();

            data = new BusinessTier.BusinessTier();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form userManagement = new FormUserManagement(this.data);
            userManagement.Show();
        }

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            Form accountManagement = new FormAccountPopup(this.data);
            accountManagement.Show();
        }

        private void btnTransactionManagement_Click(object sender, EventArgs e)
        {
            Form accountTransaction = new FormTransactionPopup(data);
            accountTransaction.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.ProcessTransaction();
            data.SaveToDb();
        }
    }
}

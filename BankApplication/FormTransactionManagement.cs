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

        public FormTransactionManagement(uint transactionID)
        {
            InitializeComponent();
            transactionClass = new TransactionClass(); ;
        }

        private void FormTransactionManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}

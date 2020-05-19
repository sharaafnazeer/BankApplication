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
    public partial class FormTransactionPopup : Form
    {
        private IBusinessTier.IBusinessTier data;
        public FormTransactionPopup(IBusinessTier.IBusinessTier data)
        {
            InitializeComponent();
            this.data = data;

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
                    this.data.SelectUser(Convert.ToUInt32(userID));
                    this.data.GetUserName(out firstName, out lastName);
                    Form accountTransaction = new FormTransactionManagement(this.data, Convert.ToUInt32(userID));
                    accountTransaction.Show();
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormTransactionPopup_Load(object sender, EventArgs e)
        {

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

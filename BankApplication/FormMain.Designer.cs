namespace BankApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnTransactionManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(237, 31);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(130, 39);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.Location = new System.Drawing.Point(237, 76);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(130, 39);
            this.btnAccountManagement.TabIndex = 1;
            this.btnAccountManagement.Text = "Manage Accounts";
            this.btnAccountManagement.UseVisualStyleBackColor = true;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnTransactionManagement
            // 
            this.btnTransactionManagement.Location = new System.Drawing.Point(237, 121);
            this.btnTransactionManagement.Name = "btnTransactionManagement";
            this.btnTransactionManagement.Size = new System.Drawing.Size(130, 39);
            this.btnTransactionManagement.TabIndex = 2;
            this.btnTransactionManagement.Text = "Manage Transactions";
            this.btnTransactionManagement.UseVisualStyleBackColor = true;
            this.btnTransactionManagement.Click += new System.EventHandler(this.btnTransactionManagement_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 193);
            this.Controls.Add(this.btnTransactionManagement);
            this.Controls.Add(this.btnAccountManagement);
            this.Controls.Add(this.btnManageUsers);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnTransactionManagement;
    }
}


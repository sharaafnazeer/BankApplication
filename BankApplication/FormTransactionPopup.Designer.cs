namespace BankApplication
{
    partial class FormTransactionPopup
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
            this.btnManageTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnManageTransaction
            // 
            this.btnManageTransaction.Location = new System.Drawing.Point(112, 93);
            this.btnManageTransaction.Name = "btnManageTransaction";
            this.btnManageTransaction.Size = new System.Drawing.Size(99, 23);
            this.btnManageTransaction.TabIndex = 19;
            this.btnManageTransaction.Text = "Manage Transaction";
            this.btnManageTransaction.UseVisualStyleBackColor = true;
            this.btnManageTransaction.Click += new System.EventHandler(this.btnManageTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter Your User ID";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(35, 61);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(270, 20);
            this.textUserID.TabIndex = 16;
            // 
            // FormTransactionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 161);
            this.Controls.Add(this.btnManageTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUserID);
            this.MaximizeBox = false;
            this.Name = "FormTransactionPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkpoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserID;
    }
}
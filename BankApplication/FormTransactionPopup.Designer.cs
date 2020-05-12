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
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageTransaction = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTransactionID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "--OR--";
            // 
            // btnManageTransaction
            // 
            this.btnManageTransaction.Location = new System.Drawing.Point(162, 168);
            this.btnManageTransaction.Name = "btnManageTransaction";
            this.btnManageTransaction.Size = new System.Drawing.Size(99, 23);
            this.btnManageTransaction.TabIndex = 19;
            this.btnManageTransaction.Text = "Manage Transaction";
            this.btnManageTransaction.UseVisualStyleBackColor = true;
            this.btnManageTransaction.Click += new System.EventHandler(this.btnManageTransaction_Click);
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(162, 54);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(99, 23);
            this.btnCreateTransaction.TabIndex = 18;
            this.btnCreateTransaction.Text = "Create Trasaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please Enter Your Transaction ID";
            // 
            // textTransactionID
            // 
            this.textTransactionID.Location = new System.Drawing.Point(94, 139);
            this.textTransactionID.Name = "textTransactionID";
            this.textTransactionID.Size = new System.Drawing.Size(270, 20);
            this.textTransactionID.TabIndex = 16;
            // 
            // FormTransactionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManageTransaction);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTransactionID);
            this.Name = "FormTransactionPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkpoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTransactionID;
    }
}
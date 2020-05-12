namespace BankApplication
{
    partial class FormTransactionManagement
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
            this.textReceiverAccountID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textTransactionID = new System.Windows.Forms.TextBox();
            this.btnCheckTransaction = new System.Windows.Forms.Button();
            this.cmbAccountIDs = new System.Windows.Forms.ComboBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textReceiverAccountID
            // 
            this.textReceiverAccountID.Location = new System.Drawing.Point(72, 216);
            this.textReceiverAccountID.Name = "textReceiverAccountID";
            this.textReceiverAccountID.Size = new System.Drawing.Size(197, 20);
            this.textReceiverAccountID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Sender Account ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reciever Account ID";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(280, 216);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(145, 20);
            this.textAmount.TabIndex = 23;
            this.textAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(431, 216);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(101, 23);
            this.btnProcess.TabIndex = 25;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "--OR--";
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(257, 36);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(99, 23);
            this.btnCreateTransaction.TabIndex = 29;
            this.btnCreateTransaction.Text = "Create Trasaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Please Enter Your Transaction ID";
            // 
            // textTransactionID
            // 
            this.textTransactionID.Location = new System.Drawing.Point(107, 120);
            this.textTransactionID.Name = "textTransactionID";
            this.textTransactionID.Size = new System.Drawing.Size(270, 20);
            this.textTransactionID.TabIndex = 27;
            // 
            // btnCheckTransaction
            // 
            this.btnCheckTransaction.Location = new System.Drawing.Point(383, 118);
            this.btnCheckTransaction.Name = "btnCheckTransaction";
            this.btnCheckTransaction.Size = new System.Drawing.Size(101, 23);
            this.btnCheckTransaction.TabIndex = 32;
            this.btnCheckTransaction.Text = "Check";
            this.btnCheckTransaction.UseVisualStyleBackColor = true;
            this.btnCheckTransaction.Click += new System.EventHandler(this.btnCheckTransaction_Click);
            // 
            // cmbAccountIDs
            // 
            this.cmbAccountIDs.FormattingEnabled = true;
            this.cmbAccountIDs.Items.AddRange(new object[] {
            "--Select Account ID--"});
            this.cmbAccountIDs.Location = new System.Drawing.Point(72, 171);
            this.cmbAccountIDs.Name = "cmbAccountIDs";
            this.cmbAccountIDs.Size = new System.Drawing.Size(197, 21);
            this.cmbAccountIDs.TabIndex = 33;
            this.cmbAccountIDs.SelectedIndexChanged += new System.EventHandler(this.cmbAccountIDs_SelectedIndexChanged);
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(427, 171);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(40, 20);
            this.lblAccountBalance.TabIndex = 35;
            this.lblAccountBalance.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Account Balance : ";
            // 
            // FormTransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 319);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccountIDs);
            this.Controls.Add(this.btnCheckTransaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTransactionID);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textReceiverAccountID);
            this.Name = "FormTransactionManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransactionManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransactionManagement_FormClosing);
            this.Load += new System.EventHandler(this.FormTransactionManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textReceiverAccountID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTransactionID;
        private System.Windows.Forms.Button btnCheckTransaction;
        private System.Windows.Forms.ComboBox cmbAccountIDs;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label label6;
    }
}
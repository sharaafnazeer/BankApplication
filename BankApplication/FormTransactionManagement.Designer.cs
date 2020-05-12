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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchAccountIDs = new System.Windows.Forms.ComboBox();
            this.btnSearchTrans = new System.Windows.Forms.Button();
            this.lbSearchResults = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSenderAccountID = new System.Windows.Forms.Label();
            this.lblReceiverAccountID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textReceiverAccountID
            // 
            this.textReceiverAccountID.Location = new System.Drawing.Point(16, 241);
            this.textReceiverAccountID.Name = "textReceiverAccountID";
            this.textReceiverAccountID.Size = new System.Drawing.Size(177, 20);
            this.textReceiverAccountID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Sender Account ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reciever Account ID";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(206, 241);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(138, 20);
            this.textAmount.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(350, 241);
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
            this.label3.Location = new System.Drawing.Point(197, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "--OR--";
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(165, 40);
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
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Please Enter Your Transaction ID";
            // 
            // textTransactionID
            // 
            this.textTransactionID.Location = new System.Drawing.Point(15, 124);
            this.textTransactionID.Name = "textTransactionID";
            this.textTransactionID.Size = new System.Drawing.Size(178, 20);
            this.textTransactionID.TabIndex = 27;
            // 
            // btnCheckTransaction
            // 
            this.btnCheckTransaction.Location = new System.Drawing.Point(206, 122);
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
            this.cmbAccountIDs.Location = new System.Drawing.Point(16, 182);
            this.cmbAccountIDs.Name = "cmbAccountIDs";
            this.cmbAccountIDs.Size = new System.Drawing.Size(177, 21);
            this.cmbAccountIDs.TabIndex = 33;
            this.cmbAccountIDs.SelectedIndexChanged += new System.EventHandler(this.cmbAccountIDs_SelectedIndexChanged);
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(353, 183);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(40, 20);
            this.lblAccountBalance.TabIndex = 35;
            this.lblAccountBalance.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Account Balance : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Select Transaction ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckTransaction);
            this.groupBox1.Controls.Add(this.textTransactionID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCreateTransaction);
            this.groupBox1.Controls.Add(this.lblAccountBalance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAccountIDs);
            this.groupBox1.Controls.Add(this.textAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textReceiverAccountID);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 332);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Transactions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.lblReceiverAccountID);
            this.groupBox2.Controls.Add(this.lblSenderAccountID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbSearchResults);
            this.groupBox2.Controls.Add(this.btnSearchTrans);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbSearchAccountIDs);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(484, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 332);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Transactions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Select Sender Account ID";
            // 
            // cmbSearchAccountIDs
            // 
            this.cmbSearchAccountIDs.FormattingEnabled = true;
            this.cmbSearchAccountIDs.Items.AddRange(new object[] {
            "--Select Account ID--"});
            this.cmbSearchAccountIDs.Location = new System.Drawing.Point(13, 42);
            this.cmbSearchAccountIDs.Name = "cmbSearchAccountIDs";
            this.cmbSearchAccountIDs.Size = new System.Drawing.Size(187, 21);
            this.cmbSearchAccountIDs.TabIndex = 37;
            // 
            // btnSearchTrans
            // 
            this.btnSearchTrans.Location = new System.Drawing.Point(206, 40);
            this.btnSearchTrans.Name = "btnSearchTrans";
            this.btnSearchTrans.Size = new System.Drawing.Size(101, 23);
            this.btnSearchTrans.TabIndex = 43;
            this.btnSearchTrans.Text = "Search";
            this.btnSearchTrans.UseVisualStyleBackColor = true;
            this.btnSearchTrans.Click += new System.EventHandler(this.btnSearchTrans_Click);
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.FormattingEnabled = true;
            this.lbSearchResults.Location = new System.Drawing.Point(13, 96);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(166, 225);
            this.lbSearchResults.TabIndex = 44;
            this.lbSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbSearchResults_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Sender Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Receiver Account";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Amount";
            // 
            // lblSenderAccountID
            // 
            this.lblSenderAccountID.AutoSize = true;
            this.lblSenderAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAccountID.Location = new System.Drawing.Point(210, 136);
            this.lblSenderAccountID.Name = "lblSenderAccountID";
            this.lblSenderAccountID.Size = new System.Drawing.Size(64, 20);
            this.lblSenderAccountID.TabIndex = 36;
            this.lblSenderAccountID.Text = "-NONE-";
            // 
            // lblReceiverAccountID
            // 
            this.lblReceiverAccountID.AutoSize = true;
            this.lblReceiverAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAccountID.Location = new System.Drawing.Point(210, 197);
            this.lblReceiverAccountID.Name = "lblReceiverAccountID";
            this.lblReceiverAccountID.Size = new System.Drawing.Size(64, 20);
            this.lblReceiverAccountID.TabIndex = 47;
            this.lblReceiverAccountID.Text = "-NONE-";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(210, 249);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(64, 20);
            this.lblAmount.TabIndex = 48;
            this.lblAmount.Text = "-NONE-";
            // 
            // FormTransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransactionManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransactionManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransactionManagement_FormClosing);
            this.Load += new System.EventHandler(this.FormTransactionManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearchAccountIDs;
        private System.Windows.Forms.ListBox lbSearchResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSenderAccountID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblReceiverAccountID;
    }
}
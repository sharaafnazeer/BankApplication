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
            this.textSenderAccountID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textTransactionID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textReceiverAccountID
            // 
            this.textReceiverAccountID.Location = new System.Drawing.Point(36, 219);
            this.textReceiverAccountID.Name = "textReceiverAccountID";
            this.textReceiverAccountID.Size = new System.Drawing.Size(244, 20);
            this.textReceiverAccountID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Sender Account ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reciever Account ID";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(302, 174);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(244, 20);
            this.textAmount.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(302, 219);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(101, 23);
            this.btnProcess.TabIndex = 25;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textSenderAccountID
            // 
            this.textSenderAccountID.Location = new System.Drawing.Point(36, 174);
            this.textSenderAccountID.Name = "textSenderAccountID";
            this.textSenderAccountID.Size = new System.Drawing.Size(244, 20);
            this.textSenderAccountID.TabIndex = 26;
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
            this.label4.Location = new System.Drawing.Point(186, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Please Enter Your Transaction ID";
            // 
            // textTransactionID
            // 
            this.textTransactionID.Location = new System.Drawing.Point(189, 121);
            this.textTransactionID.Name = "textTransactionID";
            this.textTransactionID.Size = new System.Drawing.Size(270, 20);
            this.textTransactionID.TabIndex = 27;
            // 
            // FormTransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTransactionID);
            this.Controls.Add(this.textSenderAccountID);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textReceiverAccountID);
            this.Name = "FormTransactionManagement";
            this.Text = "FormTransactionManagement";
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
        private System.Windows.Forms.TextBox textSenderAccountID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTransactionID;
    }
}
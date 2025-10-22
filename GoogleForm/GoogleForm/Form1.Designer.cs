namespace GoogleForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numInitialDeposit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTargetAccountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSelectedAccNumber;
        private System.Windows.Forms.Label lblSelectedName;
        private System.Windows.Forms.Label lblSelectedType;
        private System.Windows.Forms.Label lblSelectedBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numInitialDeposit = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargetAccountNumber = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblSelectedAccNumber = new System.Windows.Forms.Label();
            this.lblSelectedName = new System.Windows.Forms.Label();
            this.lblSelectedType = new System.Windows.Forms.Label();
            this.lblSelectedBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialDeposit)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 20;
            this.listBoxAccounts.Location = new System.Drawing.Point(12, 12);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(320, 284);
            this.listBoxAccounts.TabIndex = 0;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.label1);
            this.groupBoxCreate.Controls.Add(this.txtHolderName);
            this.groupBoxCreate.Controls.Add(this.label2);
            this.groupBoxCreate.Controls.Add(this.cmbAccountType);
            this.groupBoxCreate.Controls.Add(this.label3);
            this.groupBoxCreate.Controls.Add(this.numInitialDeposit);
            this.groupBoxCreate.Controls.Add(this.btnCreate);
            this.groupBoxCreate.Location = new System.Drawing.Point(350, 12);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(320, 160);
            this.groupBoxCreate.TabIndex = 1;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder";
            // 
            // txtHolderName
            // 
            this.txtHolderName.Location = new System.Drawing.Point(12, 51);
            this.txtHolderName.Name = "txtHolderName";
            this.txtHolderName.Size = new System.Drawing.Size(292, 27);
            this.txtHolderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Type";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.cmbAccountType.Location = new System.Drawing.Point(12, 105);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(140, 28);
            this.cmbAccountType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Deposit";
            // 
            // numInitialDeposit
            // 
            this.numInitialDeposit.DecimalPlaces = 2;
            this.numInitialDeposit.Location = new System.Drawing.Point(165, 105);
            this.numInitialDeposit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numInitialDeposit.Name = "numInitialDeposit";
            this.numInitialDeposit.Size = new System.Drawing.Size(139, 27);
            this.numInitialDeposit.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 138);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(292, 28);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.label4);
            this.groupBoxActions.Controls.Add(this.numAmount);
            this.groupBoxActions.Controls.Add(this.btnDeposit);
            this.groupBoxActions.Controls.Add(this.btnWithdraw);
            this.groupBoxActions.Controls.Add(this.btnViewBalance);
            this.groupBoxActions.Controls.Add(this.btnExit);
            this.groupBoxActions.Controls.Add(this.label5);
            this.groupBoxActions.Controls.Add(this.txtTargetAccountNumber);
            this.groupBoxActions.Controls.Add(this.btnTransfer);
            this.groupBoxActions.Location = new System.Drawing.Point(350, 180);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(320, 200);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(12, 51);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(140, 27);
            this.numAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(12, 84);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(90, 28);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(108, 84);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(90, 28);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.Location = new System.Drawing.Point(204, 84);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(96, 28);
            this.btnViewBalance.TabIndex = 7;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.UseVisualStyleBackColor = true;
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 51);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Target Account #";
            // 
            // txtTargetAccountNumber
            // 
            this.txtTargetAccountNumber.Location = new System.Drawing.Point(12, 141);
            this.txtTargetAccountNumber.Name = "txtTargetAccountNumber";
            this.txtTargetAccountNumber.Size = new System.Drawing.Size(140, 27);
            this.txtTargetAccountNumber.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(165, 141);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(135, 27);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Selected account labels (static + dynamic)
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Account Number:";
            // 
            // lblSelectedAccNumber
            // 
            this.lblSelectedAccNumber.AutoSize = true;
            this.lblSelectedAccNumber.Location = new System.Drawing.Point(145, 392);
            this.lblSelectedAccNumber.Name = "lblSelectedAccNumber";
            this.lblSelectedAccNumber.Size = new System.Drawing.Size(12, 20);
            this.lblSelectedAccNumber.TabIndex = 4;
            this.lblSelectedAccNumber.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Name:";
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.Location = new System.Drawing.Point(145, 417);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(12, 20);
            this.lblSelectedName.TabIndex = 6;
            this.lblSelectedName.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type:";
            // 
            // lblSelectedType
            // 
            this.lblSelectedType.AutoSize = true;
            this.lblSelectedType.Location = new System.Drawing.Point(410, 392);
            this.lblSelectedType.Name = "lblSelectedType";
            this.lblSelectedType.Size = new System.Drawing.Size(12, 20);
            this.lblSelectedType.TabIndex = 8;
            this.lblSelectedType.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Balance:";
            // 
            // lblSelectedBalance
            // 
            this.lblSelectedBalance.AutoSize = true;
            this.lblSelectedBalance.Location = new System.Drawing.Point(410, 417);
            this.lblSelectedBalance.Name = "lblSelectedBalance";
            this.lblSelectedBalance.Size = new System.Drawing.Size(12, 20);
            this.lblSelectedBalance.TabIndex = 10;
            this.lblSelectedBalance.Text = "-";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lblSelectedBalance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSelectedType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSelectedName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSelectedAccNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.listBoxAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Banking - In Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialDeposit)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
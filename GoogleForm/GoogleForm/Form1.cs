using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace GoogleForm
{
    public partial class Form1 : Form
    {
        private readonly List<Account> _accounts = new();

        public Form1()
        {
            InitializeComponent();
            cmbAccountType.SelectedIndex = 0;
            RefreshAccountList();
        }

        private void RefreshAccountList()
        {
            listBoxAccounts.Items.Clear();
            foreach (var acc in _accounts)
                listBoxAccounts.Items.Add(acc);
            ClearSelectedAccountDetails();
        }

        private void ClearSelectedAccountDetails()
        {
            lblSelectedAccNumber.Text = "-";
            lblSelectedName.Text = "-";
            lblSelectedType.Text = "-";
            lblSelectedBalance.Text = "-";
        }

        private Account? GetSelectedAccount()
        {
            return listBoxAccounts.SelectedItem as Account;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtHolderName.Text.Trim();
            string type = cmbAccountType.SelectedItem?.ToString() ?? "Savings";
            decimal initialDeposit = numInitialDeposit.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter account holder name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var acc = new Account(name, type, initialDeposit);
                _accounts.Add(acc);
                RefreshAccountList();
                MessageBox.Show($"Account created successfully.\nAccount Number: {acc.AccountNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHolderName.Clear();
                numInitialDeposit.Value = 0;
                cmbAccountType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var acc = GetSelectedAccount();
            if (acc == null)
            {
                ClearSelectedAccountDetails();
                return;
            }

            lblSelectedAccNumber.Text = acc.AccountNumber.ToString();
            lblSelectedName.Text = acc.HolderName;
            lblSelectedType.Text = acc.AccountType;
            lblSelectedBalance.Text = acc.Balance.ToString("C");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var acc = GetSelectedAccount();
            if (acc == null)
            {
                MessageBox.Show("Please select an account to deposit into.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = numAmount.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Enter an amount greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                acc.Deposit(amount);
                listBoxAccounts.Refresh();
                listBoxAccounts_SelectedIndexChanged(sender, e);
                MessageBox.Show("Deposit successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deposit failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var acc = GetSelectedAccount();
            if (acc == null)
            {
                MessageBox.Show("Please select an account to withdraw from.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = numAmount.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Enter an amount greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                acc.Withdraw(amount);
                listBoxAccounts.Refresh();
                listBoxAccounts_SelectedIndexChanged(sender, e);
                MessageBox.Show("Withdrawal successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Withdrawal failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var source = GetSelectedAccount();
            if (source == null)
            {
                MessageBox.Show("Please select the source account.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTargetAccountNumber.Text.Trim(), out var targetAccNum))
            {
                MessageBox.Show("Enter a valid target account number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var target = _accounts.FirstOrDefault(a => a.AccountNumber == targetAccNum);
            if (target == null)
            {
                MessageBox.Show("Target account not found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = numAmount.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Enter an amount greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                source.TransferTo(target, amount);
                listBoxAccounts.Refresh();
                listBoxAccounts_SelectedIndexChanged(sender, e);
                MessageBox.Show("Transfer successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Transfer failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            var acc = GetSelectedAccount();
            if (acc == null)
            {
                MessageBox.Show("Please select an account to view balance.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Account: {acc.AccountNumber}\nHolder: {acc.HolderName}\nBalance: {acc.Balance:C}", "Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
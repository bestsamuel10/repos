using System;

namespace GoogleForm
{
    public class Account
    {
        private static int _nextAccountNumber = 1001;
        public int AccountNumber { get; }
        public string HolderName { get; private set; }
        public string AccountType { get; private set; } // "Savings" or "Current"
        public decimal Balance { get; private set; }

        public Account(string holderName, string accountType, decimal initialDeposit)
        {
            if (string.IsNullOrWhiteSpace(holderName))
                throw new ArgumentException("Account holder name is required.", nameof(holderName));
            if (initialDeposit < 0)
                throw new ArgumentException("Initial deposit cannot be negative.", nameof(initialDeposit));
            if (accountType != "Savings" && accountType != "Current")
                throw new ArgumentException("Account type must be Savings or Current.", nameof(accountType));

            AccountNumber = _nextAccountNumber++;
            HolderName = holderName.Trim();
            AccountType = accountType;
            Balance = initialDeposit;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
            if (amount > Balance) throw new InvalidOperationException("Insufficient balance.");
            Balance -= amount;
        }

        public void TransferTo(Account target, decimal amount)
        {
            if (target == null) throw new ArgumentNullException(nameof(target));
            if (target.AccountNumber == this.AccountNumber) throw new InvalidOperationException("Cannot transfer to the same account.");
            Withdraw(amount);
            target.Deposit(amount);
        }

        public override string ToString()
        {
            return $"{AccountNumber} - {HolderName} ({AccountType})";
        }
    }
}
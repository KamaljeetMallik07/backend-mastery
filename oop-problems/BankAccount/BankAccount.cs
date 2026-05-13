using BankAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        // ENCAPSULATION: AccountNumber set once in constructor, never again
        public string AccountNumber { get; }
        public string HolderName { get; }

        //  ENCAPSULATION: Balance has private set — ONLY Deposit/Withdraw can change it
        public decimal Balance { get; private set; }

        // ENCAPSULATION: External code gets a READ-ONLY view of history
        private readonly List<Transaction> _transactions = new();
        public IReadOnlyList<Transaction> TransactionHistory => _transactions.AsReadOnly();

        public BankAccount(string holderName, decimal initialDeposit = 0)
        {
            if (string.IsNullOrWhiteSpace(holderName))
                throw new ArgumentException("Holder name cannot be empty.", nameof(holderName));

            HolderName = holderName;
            AccountNumber = GenerateAccountNumber();
            Balance = 0;

            if (initialDeposit > 0)
                Deposit(initialDeposit);
        }

        // PUBLIC METHOD: only valid way to add money
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException(
                    $"Deposit amount must be positive. Got: {amount}", nameof(amount));

            Balance += amount;

            _transactions.Add(new Transaction(
                type: TransactionType.Deposit,
                amount: amount,
                balanceAfter: Balance,
                description: "Cash deposit"
            ));
        }

        // PUBLIC METHOD: only valid way to remove money
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException(
                    $"Withdrawal amount must be positive. Got: {amount}", nameof(amount));

            if (amount > Balance)
                throw new InvalidOperationException(
                    $"Insufficient funds. Balance: {Balance:C}, Requested: {amount:C}");

            Balance -= amount;

            _transactions.Add(new Transaction(
                type: TransactionType.Withdrawl,
                amount: amount,
                balanceAfter: Balance,
                description: "Cash withdrawal"
            ));
        }

        //  ATOMIC TRANSFER: both accounts updated, both record the transaction
        public void Transfer(decimal amount, BankAccount targetAccount)
        {
            if (targetAccount == null)
                throw new ArgumentNullException(nameof(targetAccount));

            if (amount <= 0)
                throw new ArgumentException("Transfer amount must be positive.", nameof(amount));

            if (amount > Balance)
                throw new InvalidOperationException(
                    $"Insufficient funds for transfer. Balance: {Balance:C}");

            // Deduct from source
            Balance -= amount;
            _transactions.Add(new Transaction(
                type: TransactionType.TransferOut,
                amount: amount,
                balanceAfter: Balance,
                description: $"Transfer to {targetAccount.AccountNumber}"
            ));

            // Add to target
            targetAccount.Balance += amount;
            targetAccount._transactions.Add(new Transaction(
                type: TransactionType.TransferIn,
                amount: amount,
                balanceAfter: targetAccount.Balance,
                description: $"Transfer from {AccountNumber}"
            ));
        }

        public void GetStatement()
        {
            Console.WriteLine(new string('=', 75));
            Console.WriteLine($"  ACCOUNT STATEMENT — {HolderName} | Acc: {AccountNumber}");
            Console.WriteLine(new string('=', 75));

            if (_transactions.Count == 0)
            {
                Console.WriteLine("  No transactions found.");
            }
            else
            {
                foreach (var t in _transactions)
                    Console.WriteLine("  " + t);
            }

            Console.WriteLine(new string('-', 75));
            Console.WriteLine($"  Current Balance: {Balance:C}");
            Console.WriteLine(new string('=', 75));
        }

        private static string GenerateAccountNumber()
        {
            return "ACC" + Random.Shared.Next(100000, 999999).ToString();
        }
    }
}

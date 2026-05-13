using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAccount.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; }
        public TransactionType Type { get; }
        public decimal Amount { get; }
        public decimal BalanceAfter { get; }
        public DateTime Timestamp { get; }
        public string Description { get; }
        public Transaction(TransactionType type, decimal amount,
                       decimal balanceAfter, string description)
        {
            TransactionId = Guid.NewGuid();
            Type = type;
            Amount = amount;
            BalanceAfter = balanceAfter;
            Timestamp = DateTime.UtcNow;
            Description = description;
        }

        public override string ToString()
        {
            return $"[{Timestamp:dd-MM-yyyy HH:mm:ss}] " +
                   $"{Type,-12} | Amount: {Amount,10:C} " +
                   $"| Balance: {BalanceAfter,10:C} | {Description}";
        }
    }
}

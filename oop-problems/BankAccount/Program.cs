namespace BankAccount
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var kamal = new BankAccount("Kamaljeet Mallik", initialDeposit: 10000);
            var riya = new BankAccount("Riya Sharma", initialDeposit: 5000);

            // Normal operations
            kamal.Deposit(2000);
            kamal.Withdraw(500);
            kamal.Transfer(3000, riya);

            // Print statements
            kamal.GetStatement();
            riya.GetStatement();

            // Test invalid operations
            try
            {
                kamal.Withdraw(99999); // should throw
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\n Error caught: {ex.Message}");
            }

            try
            {
                kamal.Deposit(-100); // should throw
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error caught: {ex.Message}");
            }
        }
    }
}

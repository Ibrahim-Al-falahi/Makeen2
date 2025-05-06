namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("A", 111, 100);
            BankAccount bankAccount2 = new BankAccount("B", 222, 90);
            BankAccount bankAccount3 = new BankAccount("C", 333, 150);

            BankAccount.ShowTotalAccounts();
        }
    }
}

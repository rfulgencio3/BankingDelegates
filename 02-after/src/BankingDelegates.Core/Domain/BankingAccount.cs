namespace BankingDelegates.Core.Domain;

public class BankingAccount
{
    public double Balance { get; private set; }

    public BankingAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    // Delegate para ações após a transação
    public delegate void AfterTransactionDelegate(double amount, string transactionType);
    public AfterTransactionDelegate AfterTransaction { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
        AfterTransaction?.Invoke(amount, "Deposit");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            AfterTransaction?.Invoke(amount, "Withdraw");
        }
        else
        {
            Console.WriteLine("Insuficent balance.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Actual balance: {Balance}");
    }
}

namespace BankingWithoutDelegates.Core.Domain;

public class BankingAccountBefore
{
    public double Balance { get; private set; }

    public BankingAccountBefore(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount} deposit made. Current Balance: {Balance}");
    }

    public void Withdraw(double valor)
    {
        if (Balance >= valor)
        {
            Balance -= valor;
            Console.WriteLine($"Saque de {valor} realizado. Saldo Atual: {Balance}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Saldo atual: {Balance}");
    }
}
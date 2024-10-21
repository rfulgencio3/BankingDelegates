using BankingDelegates.Application.Services.Interfaces;
using BankingDelegates.Core.Domain;

namespace BankingDelegates.Application.Services;

public class TransactionService : ITransactionService
{
    private readonly BankingAccount _account;

    public TransactionService(BankingAccount account)
    {
        _account = account;
    }

    public void RegisterTransaction(double amount, string type)
    {
        Console.WriteLine($"Transaction: {type} of {amount}. Current Balance: {_account.Balance}");
    }
}

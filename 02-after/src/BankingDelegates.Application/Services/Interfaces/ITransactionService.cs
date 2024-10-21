namespace BankingDelegates.Application.Services.Interfaces;

public interface ITransactionService
{
    void RegisterTransaction(double valor, string tipo);
}

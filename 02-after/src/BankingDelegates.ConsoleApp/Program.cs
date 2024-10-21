using BankingDelegates.Application.Services;
using BankingDelegates.Core.Domain;

class Program
{
    static void Main()
    {
        var account = new BankingAccount(500.0);
        var transacaoService = new TransactionService(account);

        // Usando delegates para associar ações após transações
        account.AfterTransaction += transacaoService.RegisterTransaction;

        bool @continue = true;

        while (@continue)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - View Balance");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            Console.WriteLine("4 - Exit");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    account.ViewBalance();
                    break;
                case "2":
                    Console.WriteLine("Enter the deposit amount:");
                    double depositValue = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositValue);
                    break;
                case "3":
                    Console.WriteLine("Enter the withdrawal amount:");
                    double withdrawValue = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdrawValue);
                    break;
                case "4":
                    @continue = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
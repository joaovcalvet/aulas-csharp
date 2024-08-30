using System.Text;

namespace Course.Entities;
class Account
{
    private protected int Number;
    private protected string Holder;
    private protected double Balance;

    public Account(int number, string holder, double balance)
    {
        this.Number = number;
        this.Holder = holder ?? "";
        this.Balance = balance;
    }

    public virtual void Withdraw(double amount)
    {
        if(this.Balance >= amount)
        {
            this.Balance -= amount;
            Console.WriteLine("Saque realizado com Sucesso!");
            return;
        }

        Console.WriteLine("Valor do saque além do total da conta.");
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
        Console.WriteLine("Depósito realizado com Sucesso!");
    }

    public void CheckAccount()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine("<-- Informações da Conta -->");
        str.AppendLine($"Número da Conta: {Number}");
        str.AppendLine($"Proprietário da Conta: {Holder}");
        str.Append($"Saldo da Conta: R${Balance}");
        Console.WriteLine(str);
    }
}
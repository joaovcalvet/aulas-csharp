using Course.Entities.Exceptions;

namespace Course.Entities;

class Account
{
    private readonly int Number;
    private readonly string Holder;
    public double Balance {get; private set;}
    private readonly double WithdrawLimit;

    public Account(int number, string holder, double balance, double limit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = limit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if(amount > Balance)
            throw new WithdrawException("Your balance is not enough for the withdraw.");

        if(amount > WithdrawLimit)
            throw new LimitException("The amount exceeds withdraw limit");

        Balance -= amount;
        Console.WriteLine("New Balance: " + Balance);
    }
}
namespace Course.Entities;
class SavingsAccount : Account
{
    private protected double InterestRate;
    private int Tax = 5;

    public SavingsAccount(int number, string holder, double balance, double interest) : 
    base(number, holder, balance)
    {
        this.InterestRate = interest;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

    public sealed override void Withdraw(double amount)
    {
        if(Balance >= amount + Tax)
            base.Withdraw(amount + Tax);
    }
}
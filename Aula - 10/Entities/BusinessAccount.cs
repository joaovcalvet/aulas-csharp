namespace Course.Entities;
sealed class BusinessAccount : Account
{
    private double LoanLimit;

    public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
    {
        this.LoanLimit = loanlimit;
    }

    public void Loan(double amount)
    {
        if(amount <= LoanLimit)
        {
            this.Balance += amount;
            Console.WriteLine("Emprestimo realizado com Sucesso!");
            return;
        }

        Console.WriteLine("Valor do empréstimo além do limite permitido.");
    }
}
namespace Course.Entities;

class PessoaJuridica : Pessoa
{
    private int Employees;

    public PessoaJuridica(string name, double income, int employees):
    base(name, income)
    {
        Employees = employees;
    }

    public override double PayTaxes()
    {
        if(Employees > 10)
            return AnualIncome * 0.14;

        return AnualIncome * 0.16;
    }
}
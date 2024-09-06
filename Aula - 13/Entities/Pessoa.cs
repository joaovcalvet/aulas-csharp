namespace Course.Entities;

abstract class Pessoa
{
    public string Name {get; private set;}
    protected double AnualIncome {get; private set;}

    public Pessoa(string name, double income)
    {
        Name = name;
        AnualIncome = income;
    }

    public abstract double PayTaxes();
}
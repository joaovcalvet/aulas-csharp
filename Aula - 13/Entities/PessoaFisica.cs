namespace Course.Entities;

class PessoaFisica : Pessoa
{
    private double MedicalBills = 0;

    public PessoaFisica(string name, double income):
    base(name, income){}

    public PessoaFisica(string name, double income, double bills):
    base(name, income)
    {
        MedicalBills = bills;
    }

    public override double PayTaxes()
    {
        if(AnualIncome < 20000)
            return (AnualIncome * 0.15) - (MedicalBills * 0.50);

        return (AnualIncome * 0.25) - (MedicalBills * 0.50);
    }
}
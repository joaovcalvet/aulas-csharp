using System.Text;

namespace Course.Entities;

class OutsourcedEmployee : Employee
{
    private double AdditionalCharge;

    public OutsourcedEmployee(string name, int hours, double vPH, double aC) : base(name, hours, vPH)
    {
        this.AdditionalCharge = aC;
    }

    public override double Payment()
    {
        return base.Payment() + (AdditionalCharge + (AdditionalCharge * 0.1));
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Nome: {Name}");
        str.AppendLine($"Horas Trabalhadas: {Hours} Horas");
        str.AppendLine($"Valor por Hora: R${ValuePerHour}");
        str.AppendLine($"Valor do Adicional: R${AdditionalCharge}");
        str.AppendLine($"Total a Receber: R${Payment()}");
        return str.ToString();
    }
}
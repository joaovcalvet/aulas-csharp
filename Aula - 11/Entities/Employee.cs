using System.Text;

namespace Course.Entities;
class Employee
{
    protected string Name;
    protected int Hours;
    protected double ValuePerHour;

    public Employee(string name, int hours, double perHour)
    {
        Name = name;
        Hours = hours;
        ValuePerHour = perHour;
    }

    public virtual double Payment()
    {
        return ValuePerHour * Hours;
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine($"Nome: {Name}");
        str.AppendLine($"Horas Trabalhadas: {Hours} Horas");
        str.AppendLine($"Valor por Hora: R${ValuePerHour}");
        str.AppendLine($"Total a Receber: R${Payment()}");
        return str.ToString();
    }
}
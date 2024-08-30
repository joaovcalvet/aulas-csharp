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
}
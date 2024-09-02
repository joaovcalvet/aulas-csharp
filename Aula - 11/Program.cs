using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the Number of employees: ");
            int nEmployees = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < nEmployees; i++)
            {
                string name;
                int hours;
                double vPH;

                Console.WriteLine($"\nEmployee #{i+1} data:");
                Console.Write("Outsourced (y/n): ");
                string opc = Console.ReadLine() ?? "x";

                switch (opc.ToLower())
                {
                    case "y":
                        double aC;

                        Console.Write("Name: ");
                        name = Console.ReadLine() ?? "";
                        Console.Write("Hours: ");
                        hours = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Value per Hour: ");
                        vPH = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Additional Charges: ");
                        aC = Convert.ToDouble(Console.ReadLine());

                        OutsourcedEmployee oe = new OutsourcedEmployee(name, hours, vPH, aC);
                        employees.Add(oe);
                        break;

                    case "n":
                        Console.Write("Name: ");
                        name = Console.ReadLine() ?? "";
                        Console.Write("Hours: ");
                        hours = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Value per Hour: ");
                        vPH = Convert.ToDouble(Console.ReadLine());

                        Employee e = new Employee(name, hours, vPH);
                        employees.Add(e);
                        break;
                    default:
                        Console.WriteLine("Opção errada mano...");
                        break;
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
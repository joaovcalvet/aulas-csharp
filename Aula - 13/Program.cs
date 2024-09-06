using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double income;

            List<Pessoa> persons = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                string opc = Console.ReadLine() ?? "";

                switch (opc.ToLower())
                {
                    case "i":
                        Console.Write("Name: ");
                        name = Console.ReadLine() ?? "";
                        Console.Write("Anual income: ");
                        income = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Health expenditures? (y/n): ");
                        string opc1 = Console.ReadLine() ?? "";

                        if(opc1.ToLower() == "y")
                        {
                            Console.Write("Health bills: ");
                            double bills = Convert.ToDouble(Console.ReadLine());

                            persons.Add(new PessoaFisica(name, income, bills));
                            break;
                        }

                        persons.Add(new PessoaFisica(name, income));
                        break;
                    case "c":
                        int employees;

                        Console.Write("Name: ");
                        name = Console.ReadLine() ?? "";
                        Console.Write("Anaul income: ");
                        income = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Employees: ");
                        employees = Convert.ToInt32(Console.ReadLine());

                        persons.Add(new PessoaJuridica(name, income, employees));
                        break;
                    default:
                        Console.WriteLine("Idiota");
                        break;
                }
            }

            Console.WriteLine("\nTAXES PAID\n");
            double totalTaxes = 0;

            foreach(Pessoa person in persons)
            {
                Console.WriteLine($"{person.Name}: R${person.PayTaxes():f2}");
                totalTaxes += person.PayTaxes();
            }

            Console.WriteLine($"\nTOTAL TAXES: R${totalTaxes:f2}");
        }
    }
}
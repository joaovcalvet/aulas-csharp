using Course.Entities;
using Course.Entities.Exceptions;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        string holder = "";
        double balance = 0, limit = 0, amount = 0;

        Console.WriteLine("Enter account data:");

        try {
            Console.Write("Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Holder: ");
            holder = Console.ReadLine() ?? "";
            Console.Write("Initial Balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            limit = Convert.ToDouble(Console.ReadLine());   
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            Environment.Exit(13);
        }

        Console.Write("\nEnter amount to withdraw: ");
        amount = Convert.ToDouble(Console.ReadLine());

        try {
            Account account = new Account(number, holder, balance, limit);
            account.Withdraw(amount);
        } catch (DomainException e) {
            Console.WriteLine(e.Message);
        }
    }
}
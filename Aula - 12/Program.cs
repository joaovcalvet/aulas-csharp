using System.Diagnostics.Contracts;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prods = new List<Product>();

            Console.Write("Enter the number of products: ");
            int prodNum = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < prodNum; i++)
            {
                string prodName;
                double prodPrice;

                Console.WriteLine($"\nProduct #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                string opc = Console.ReadLine() ?? "";

                switch (opc)
                {
                    case "c":
                        Console.Write("Enter with product name: ");
                        prodName = Console.ReadLine() ?? "";
                        Console.Write("Enter with product price: R$");
                        prodPrice = Convert.ToDouble(Console.ReadLine());

                        Product prod = new Product(prodName, prodPrice);
                        prods.Add(prod);
                        break;
                    case "u":
                        DateTime date;

                        Console.Write("Enter with product name: ");
                        prodName = Console.ReadLine() ?? "";
                        Console.Write("Enter with product price: R$");
                        prodPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter with manufactured date: ");
                        date = Convert.ToDateTime(Console.ReadLine());

                        UsedProduct usedProd = new UsedProduct(prodName, prodPrice, date);
                        prods.Add(usedProd);
                        break;
                    case "i":
                        double customFee;

                        Console.Write("Enter with product name: ");
                        prodName = Console.ReadLine() ?? "";
                        Console.Write("Enter with product price: R$");
                        prodPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter with custom fee price: R$");
                        customFee = Convert.ToDouble(Console.ReadLine());

                        ImportedProduct impProd = new ImportedProduct(prodName, prodPrice, customFee);
                        prods.Add(impProd);
                        break;
                    default:
                        Console.WriteLine("Seu animal");
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS");
            foreach(Product prod in prods)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
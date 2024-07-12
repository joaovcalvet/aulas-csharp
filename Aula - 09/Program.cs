using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definição do Cliente
            Client cliente;
            Order pedido;

            Console.WriteLine("--- Bem-Vindo(a)! ---");
            Console.WriteLine("Entre com as informações do cliente: ");

            Console.Write("Nome do Cliente: ");
            string? nome = Console.ReadLine();
            nome ??= "Nome não Informado";

            Console.WriteLine(nome);

            Console.Write("Email do Cliente: ");
            string? email = Console.ReadLine();
            email ??= "Email não Informado";

            Console.Write("Data de Nascimento do Cliente (dd/mm/yyyy): ");
            DateTime aniversario = Convert.ToDateTime(Console.ReadLine());

            cliente = new Client(nome, email, aniversario);

            //Definição do Pedido
            OrderStatus status = OrderStatus.PENDING_PAYMENT;
            pedido = new Order(DateTime.Now, status, cliente);

            Console.Write("\nQuantos Itens o cliente vai adicionar ao pedido?: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"\n\nProduto {i+1}\n");

                Console.Write("Qual produto será adicionado?: ");
                string? prod = Console.ReadLine();
                prod ??= "Produto não Informado";

                Console.Write("Qual será o valor do produto?: $");
                double priceProd = Convert.ToDouble(Console.ReadLine());

                Product produto = new Product(prod, priceProd);

                Console.Write("Qual quantidade será adicionada?: ");
                int qtdProd = Convert.ToInt32(Console.ReadLine());

                OrderItem item = new OrderItem(qtdProd, produto);

                pedido.AddItem(item);
            }

            Console.WriteLine("\nPedido Finalizado!\n");
            Console.WriteLine(pedido);
        }
    }
}
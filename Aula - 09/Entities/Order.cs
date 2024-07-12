using System.Security.Cryptography.X509Certificates;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment;
        public OrderStatus Status;
        public Client Cliente;
        public List<OrderItem> Itens;

        public Order(DateTime date, OrderStatus status, Client cliente)
        {
            Moment = date;
            Status = status;
            Cliente = cliente;
            Itens = new List<OrderItem>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {this.Moment}");
            sb.AppendLine($"Client: {this.Cliente}");
            sb.AppendLine("Order items:");

            for(int i = 0; i < Itens.Count; i++)
            {
                sb.Append($"{i+1}° Product: ");
                sb.Append($"{Itens[i].Produto.Name}, ${Itens[i].Produto.Price}, ");
                sb.AppendLine($"Quantity: {Itens[i].Quantity}, Subtotal: ${Itens[i].Price}, ");
            }

            sb.AppendLine($"Total Price: ${this.Total()}");

            return sb.ToString();
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Itens)
                total += item.Price;

            return total;
        }
    }
}
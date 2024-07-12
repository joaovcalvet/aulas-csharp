namespace Course.Entities
{
    class OrderItem
    {
        public int Quantity;
        public double Price;
        public Product Produto;

        public OrderItem(int quantity, Product produto)
        {
            Quantity = quantity;
            Produto = produto;
            Price = SubTotal();
        }

        public double SubTotal()
        {
            return Quantity * Produto.Price;
        }
    }
}
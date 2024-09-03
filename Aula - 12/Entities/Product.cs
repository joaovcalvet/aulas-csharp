using System.Reflection.Metadata.Ecma335;

namespace Course.Entities;

class Product
{
    protected string Name;
    protected double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string PriceTag()
    {
        return $"{Name} R${Price}";
    }
}
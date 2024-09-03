namespace Course.Entities;

class UsedProduct : Product
{
    private DateTime ManufactureDate;

    public UsedProduct(string name, double price, DateTime date):
    base(name, price)
    {
        ManufactureDate = date;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) R${Price} (Manufactured date: {ManufactureDate.Date})";
    }
}
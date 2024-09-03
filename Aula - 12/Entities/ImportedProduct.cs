namespace Course.Entities;

class ImportedProduct : Product
{
    private double CustomFee;

    public ImportedProduct(string name, double price, double custom):
    base(name, price)
    {
        CustomFee = custom;
    }

    public override string PriceTag()
    {
        return $"{Name} R${Price + CustomFee} (Custom fee: R${CustomFee})";
    }
}
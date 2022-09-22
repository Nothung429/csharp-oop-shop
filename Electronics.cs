public class Electronics : Product
{
    public string brand { get; set; }

    public Electronics(int code, string name, string description, float price, float taxedprice, string extended, string brand) : base(code, name, description, price, taxedprice, extended)
    {
        this.brand = brand;
    }
}

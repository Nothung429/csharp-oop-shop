public class Electronics : Product
{
    public string brand { get; set; }
    public string type { get; set; }

    public Electronics(int code, string name, string description, float price, string extended) : base(code, name, description, price, extended)
    {
        this.brand = brand;
        this.type = type;
    }
}

public class Fruit : Product
{
    public int pieces { get; set; }
    public string type { get; set; }

    public Fruit(int code, string name, string description, float price, string extended) : base(code, name, description, price, extended)
    {
        this.pieces = pieces; //5
        this.type = type;
    }
}

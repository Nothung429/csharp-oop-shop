public class Fruit : Product
{
    public int pieces { get; set; }

    public Fruit(int code, string name, string description, float price, float taxedprice, string extended, int pieces) : base(code, name, description, price, taxedprice, extended)
    {
        this.pieces = pieces; //5
    }
}

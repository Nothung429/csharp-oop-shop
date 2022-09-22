public class TinFood : Product
{
    public string brand { get; set; }
    public int weight { get; set; }
    public TinFood(int code, string name, string description, float price, float taxedprice, string extended, string brand, int weight) : base(code, name, description, price, taxedprice, extended)
    {
        this.brand = brand;
        this.weight = weight; //300
    }
}
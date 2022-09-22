public class TinFood : Product
{
    public string brand { get; set; }
    public string type { get; set; }
    public int weight { get; set; }
    public TinFood(int code, string name, string description, float price, string extended) : base(code, name, description, price, extended)
    {
        this.brand = brand;
        this.type = type;
        this.weight = weight; //300
    }
}
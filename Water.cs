public class Water : Product
{
    public float litres { get; set; }
    public int pH { get; set; }
    public string source { get; set; }
    public Water(int code, string name, string description, float price, string extended) : base(code, name, description, price, extended)
    {
        this.litres = litres; //1.5f
        this.pH = pH;
        this.source = source;
    }
}

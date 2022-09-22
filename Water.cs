public class Water : Product
{
    public float Litres { get; set; }
    public string Source { get; set; }
    public int pH = 7;
    public Water(int code, string name, string description, float price, float taxedprice, string extended, float Litres, string Source) : base(code, name, description, price, taxedprice, extended)
    {
        this.Source = GetWaterSource();
        this.Litres = LimitLitres(); //1.5f
        //this.Litres = ConvertToGallons();
    }
    public string GetWaterSource()
    {
        Console.WriteLine("Inserisci la sorgente dell'acqua: ");
        return Console.ReadLine();
    }
    public float LimitLitres()
    {
        Console.WriteLine("Inserisci i litri della bottiglia: ");
        if (Console.Read() <= 2)
        {
            return Litres;
        }
        else
        {
            Console.WriteLine("Hai esagerato con le quantità");
            return Litres = 0.0f;
        }        
    }
    public float ConvertToGallons()
    {
        Console.WriteLine("Vuoi convertire da galloni in litri: si/no");
        if (Console.ReadLine() == "si")
        {
            Litres = Litres * 3.785f;
            return Litres;
        }
        else
        {
            Console.WriteLine("Sei una persona civilizzata");
            return Litres = Litres;
        }
    }
}

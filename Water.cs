public class Water : Product
{
    public float Litres { get; set; }
    public string Source { get; set; }
    public float litresCap = 1.5f;
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
        if (Convert.ToSingle(Console.Read()) <= litresCap)
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
    public override void Stampa()
    {
        Console.WriteLine($"Il codice del tuo prodotto è: {code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {ExtendedName()}");
        Console.WriteLine($"Il pH dell'acqua è: {pH}");
        Console.WriteLine($"La sorgente dell'acqua è: {Source}");
        Console.WriteLine($"I litri nella bottiglia sono: {Litres}");
        Console.WriteLine($"In galloni: {ConvertToGallons()}");
    }
}

public class TinFood : Product
{
    public string brand { get; set; }
    public int weight { get; set; }
    public TinFood(int code, string name, string description, float price, float taxedprice, string extended, string brand, int weight) : base(code, name, description, price, taxedprice, extended)
    {
        this.brand = brand;
        this.weight = weight; //300
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
        Console.WriteLine($"La marca della scatoletta è: {brand}");
        Console.WriteLine($"Il peso della scatoletta è: {weight}");
    }
}

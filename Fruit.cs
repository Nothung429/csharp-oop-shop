public class Fruit : Product
{
    public int pieces { get; set; }

    public Fruit(int code, string name, string description, float price, float taxedprice, string extended, int pieces) : base(code, name, description, price, taxedprice, extended)
    {
        this.pieces = pieces; //5
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
        Console.WriteLine($"Il numero di pezzi di frutta è: {pieces}");
    }
}

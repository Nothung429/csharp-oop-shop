public class Product
{
    public int code { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public int iva = 25;
    public string extended { get; set; }
    public Product(int code, string name, string description, float price, string extended)
    {
        this.code = RandomCode();
        this.name = GetUserName();
        this.description = GetUserDescription();
        this.price = RandomPrice();
        this.price = TaxedPrice();
        this.extended = ExtendedName();
    }
    public int RandomCode()
    {
        Random r = new Random();
        int randomCoding = r.Next(10000000, 99999999);
        return randomCoding;
    }

    public string GetUserName()
    {
        Console.WriteLine("Inserisci il nome del prodotto: ");
        return Console.ReadLine(); ;
    }

    public string GetUserDescription()
    {
        Console.WriteLine("Inserisci la descrizione del prodotto: ");
        return Console.ReadLine();
    }

    public float RandomPrice()
    {
        Random r = new Random();
        float randomMoney = r.Next(1, 99);
        return randomMoney;
    }

    public float TaxedPrice()
    {
        float tax = price + ((price / 100) * iva);
        return tax;
    }
    public string ExtendedName()
    {
        string extended = name + code;
        return extended;
    }    
}
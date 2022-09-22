public class Product : Shop
{
    public int code { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }

    public float taxedprice = 0.0f;

    public int iva = 25;
    public string extended { get; set; }
    public Product(int code, string name, string description, float price, float taxedprice, string extended) : base(name)
    {
        this.code = RandomCode();
        this.name = GetUserName();
        this.description = GetUserDescription();
        this.price = GetUserPrice();
        this.taxedprice = TaxedPrice();
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

    public float GetUserPrice()
    {
        Console.WriteLine("Inserisci il prezzo del prodotto: ");
        price = Convert.ToSingle(Console.ReadLine());
        return price;
    }

    public float TaxedPrice()
    {
        taxedprice = price;
        float tax = taxedprice + ((taxedprice / 100) * iva);
        return tax;
    }
    public string ExtendedName()
    {
        string extended = name + code;
        return extended;
    }
}
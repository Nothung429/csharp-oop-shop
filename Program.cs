// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
//Creare una classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private):
//i costruttori,
//i metodi getter e setter
//eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura

//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.

//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

Prodotto mioProdotto = new Prodotto(123, "iphone", "verde", 2.99f);

Console.WriteLine($"Il codice del tuo prodotto è: {mioProdotto.GetCode()}");
Console.WriteLine($"Il nome del tuo prodotto è: {mioProdotto.GetName()}");
Console.WriteLine($"La descrizione del tuo prodotto è: {mioProdotto.GetDescription()}");
Console.WriteLine($"Il prezzo del tuo prodotto è: {mioProdotto.GetPrice()}");
Console.WriteLine($"L'IVA per il tuo prodotto è: {mioProdotto.GetIva()}");
public class Prodotto
{
    private int code;
    private string name;
    private string description;
    private float price;
    private int iva = 25;
    public Prodotto(int code, string name, string description, float price)
    {
        this.code = RandomCode();
        this.name = GetUserName();
        this.description = GetUserDescription();
        this.price = RandomPrice();
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

    public int GetCode()
    {
        return this.code;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetDescription()
    {
        return this.description;
    }
    public float GetPrice()
    {
        return this.price;
    }
    public int GetIva()
    {
        return this.iva;
    }
}
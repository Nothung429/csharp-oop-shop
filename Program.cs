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

Console.WriteLine($"Il codice del tuo prodotto è: {mioProdotto.code}");
Console.WriteLine($"Il nome del tuo prodotto è: {mioProdotto.name}");
Console.WriteLine($"La descrizione del tuo prodotto è: {mioProdotto.description}");
Console.WriteLine($"Il prezzo del tuo prodotto è: {mioProdotto.price}");
Console.WriteLine($"L'IVA per il tuo prodotto è: {mioProdotto.iva}");
public class Prodotto
{
    public int code;
    public string name;
    public string description;
    public float price;
    public int iva = 25;
    public Prodotto(int code, string newName, string newDescription, float price)
    {
        this.code = randomCode();
        this.name = GetName(newName);
        this.description = GetDescription(newDescription);
        this.price = randomPrice();
    }

    public int randomCode()
    {
        Random r = new Random();
        int randomCoding = r.Next(10000000, 99999999);
        return randomCoding;
    }

    public string GetName(string newName)
    {
        Console.WriteLine("Inserisci il nome del prodotto: ");
        Console.ReadLine();
        this.name = newName;
        return newName;
    }

    public string GetDescription(string newDescription)
    {
        Console.WriteLine("Inserisci la descrizione del prodotto: ");
        Console.ReadLine();
        this.description = newDescription;
        return newDescription;
    }

    public float randomPrice()
    {
        Random r = new Random();
        float randomMoney = r.Next(1, 99);
        return randomMoney;
    }
}
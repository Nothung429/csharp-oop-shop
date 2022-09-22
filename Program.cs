//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop, vi chiedo di essere più specifichi e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.

//In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
//    Acqua(massimo 1.5L)
//    Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
//    Elettrodomestico
//    Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)

//Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere i loro attributi e metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi generici dalla classe Prodotto creata nell’esercizio precedente.

//Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:
//    attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
//    attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
//    attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
//    ... ecc ecc
//    metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
//    metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
//    metodo svuota() che rimuove tutta l’acqua dalla bottiglia.

//    metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”, l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.

//    un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).

//Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato dei vostri oggetti (ad esempio non posso bere più dei litri contenuti nella bottiglia, o non posso riempire più di tot una bottiglia!).

//E così via per tutti gli altri elementi qui sopra riportati, provate a pensare attributi e metodi che potrebbero servire ai vostri prodotti specializzati Acqua, sacchetto di frutta a pezzi, elettrodomestici e cibo in scatola.

//Al solito usate opportunamente i livelli di accesso (public, private, protected o altro se necessario), i costruttori, i metodi getter e setter (o le properties) ed eventuali altri metodi di “utilità“.

//Pensate anche se avete bisogno di eventuali metodi statici o attributi statici (ad esempio potrebbero essere i limiti dei vostri oggetti ), e ad eventuali override e overload di metodi come visto per Acqua.

//Una volta finite più o meno le vostre classi, nel Program.cs, provate a testare un pò i vostri prodotti specializzati, osservando come i metodi della classe generica prodotto e quelli più specifici vengono richiamati e siano disponibili.

//Parte 1
//Product mioProduct = new Product(123, "iphone", "verde", 2.99f, 2.4f, "");

//Console.WriteLine($"Il codice del tuo prodotto è: {mioProduct.code}");
//Console.WriteLine($"Il nome del tuo prodotto è: {mioProduct.name}");
//Console.WriteLine($"La descrizione del tuo prodotto è: {mioProduct.description}");
//Console.WriteLine($"Il prezzo del tuo prodotto è: {mioProduct.price}$");
//Console.WriteLine($"L'IVA per il tuo prodotto è: {mioProduct.iva}");
//Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {mioProduct.TaxedPrice()}$");
//Console.WriteLine($"Il nome completo del tuo prodotto è: {mioProduct.ExtendedName()}");

//Parte 2
Shop myShop = new Shop("Bazar di Johnny");
Console.WriteLine($"Benvenuto al {myShop.name}\n");

Console.WriteLine("Digita 1 per aggiungere un prodotto GENERICO");
Console.WriteLine("Digita 2 per aggiungere un prodotto ACQUA");
Console.WriteLine("Digita 3 per aggiungere un prodotto FRUTTA");
Console.WriteLine("Digita 4 per aggiungere un prodotto ELETTRODOMESTICO");
Console.WriteLine("Digita 5 per aggiungere un prodotto CIBO IN SCATOLA");
int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:
        Product myProduct = new Product(123, "iphone", "verde", 2.99f, 2.4f, "");

        Console.WriteLine($"Il codice del tuo prodotto è: {myProduct.code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {myProduct.name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {myProduct.description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {myProduct.price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {myProduct.iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {myProduct.TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {myProduct.ExtendedName()}");
        break;

    case 2:
        Water myWater = new Water(123, "sorgiva", "bella", 2.99f, 2.4f, "", 1.2f, 7, "levissima");

        Console.WriteLine($"Il codice del tuo prodotto è: {myWater.code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {myWater.name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {myWater.description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {myWater.price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {myWater.iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {myWater.TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {myWater.ExtendedName()}");
        Console.WriteLine($"I litri nella bottiglia sono: {myWater.litres}");
        Console.WriteLine($"Il pH dell'acqua è: {myWater.pH}");
        Console.WriteLine($"La sorgente dell'acqua è: {myWater.source}");
        break;

    case 3:
        Fruit myFruit = new Fruit(123, "sorgiva", "bella", 2.99f, 2.4f, "", 4);

        Console.WriteLine($"Il codice del tuo prodotto è: {myFruit.code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {myFruit.name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {myFruit.description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {myFruit.price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {myFruit.iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {myFruit.TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {myFruit.ExtendedName()}");
        Console.WriteLine($"Il numero di pezzi di frutta è: {myFruit.pieces}");
        break;

    case 4:
        Electronics myElectronics = new Electronics(123, "iphone", "verde", 2.99f, 2.4f, "", "whirpool");

        Console.WriteLine($"Il codice del tuo prodotto è: {myElectronics.code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {myElectronics.name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {myElectronics.description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {myElectronics.price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {myElectronics.iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {myElectronics.TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {myElectronics.ExtendedName()}");
        Console.WriteLine($"La marca dell'elettrodomestico è: {myElectronics.brand}");
        break;

    case 5:
        TinFood myTinFood = new TinFood(123, "iphone", "verde", 2.99f, 2.4f, "", "ruggiero", 250);

        Console.WriteLine($"Il codice del tuo prodotto è: {myTinFood.code}");
        Console.WriteLine($"Il nome del tuo prodotto è: {myTinFood.name}");
        Console.WriteLine($"La descrizione del tuo prodotto è: {myTinFood.description}");
        Console.WriteLine($"Il prezzo del tuo prodotto è: {myTinFood.price}$");
        Console.WriteLine($"L'IVA per il tuo prodotto è: {myTinFood.iva}");
        Console.WriteLine($"Il prezzo del tuo prodotto con l'IVA è: {myTinFood.TaxedPrice()}$");
        Console.WriteLine($"Il nome completo del tuo prodotto è: {myTinFood.ExtendedName()}");
        Console.WriteLine($"La marca della scatoletta è: {myTinFood.brand}");
        Console.WriteLine($"Il peso della scatoletta è: {myTinFood.weight}");
        break;
}


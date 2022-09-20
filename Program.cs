﻿//User
//cognome,
//nome,
//email,
//password,
//recapito telefonico

//Book
//ISBN,
//pagine,
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).

//DVD
//codice seriale,
//durata,
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).

#region Riempio le liste books & dvds
Library myLibrary = new Library("Biblioteca Nazionale");

Book firstBook = new Book("12345678", 200, "Libro", 2018, "Horror", "A18", "Maccio Capatonda");
Book secondBook = new Book("87654321", 300, "Lo straniero", 1942, "Romanzo", "B88", "Albert Camus");
secondBook.Available = false;

List < Book > theseBooks = new List<Book> { firstBook, secondBook };

Dvd firstDvd = new Dvd("00990099", 160, "American Gangster", 2007, "Drammatico", "D2", "Ridley Scott");
Dvd secondDvd = new Dvd("99009900", 155, "Il Gladiatore", 2000, "Epico", "D3", "Ridley Scott");

List<Dvd> theseDvds = new List<Dvd> { firstDvd, secondDvd };

myLibrary.Books = theseBooks;

myLibrary.Dvds = theseDvds;

#endregion

Console.Write("Inserisci il tuo cognome: ");
string newSurname = Console.ReadLine();

Console.WriteLine();

Console.Write("Inserisci il tuo nome: ");
string newName = Console.ReadLine();

Console.WriteLine();

Console.Write("Inserisci la tua email: ");
string newEmail = Console.ReadLine();

Console.WriteLine();

Console.Write("Inserisci una nuova password: ");
string newPassword = Console.ReadLine();

Console.WriteLine();

Console.Write("Inserisci il tuo recapito telefonico: ");
string newPhone = Console.ReadLine();

User newUser = new User(newSurname, newName, newEmail, newPassword, newPhone);

Console.Write("Trova velocemente il prodotto che cerchi (dvd/libro) tramite codice identificativo oppure tramite titolo: ");
string keyWord = Console.ReadLine();

Document searchResult = myLibrary.GetDocument(keyWord);

if(searchResult.Title == "Prodotto non trovato")
{
    Console.WriteLine("Siamo spiacenti ma attualmente il prodotto richiesto non è presente in nessun scaffale");
} else
{
    Console.WriteLine($"Abbiamo trovato un prodotto che combacia con i criteri di ricerca: {searchResult.Title}");
    Console.Write("Vuoi procedere con il prestito? ");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() == "si" && searchResult.Available)
    {
        Loan newLoan = new Loan("12", 2210219, 22112019, searchResult);
        Console.WriteLine($"Prestito collegato al prodotto {searchResult.Title} accettato!");
    }
    else if (userAnswer.ToLower() == "si" && !searchResult.Available)
    {
        Console.WriteLine($"Il prodotto {searchResult.Title} è già collegato ad un altro prestito");
    }
    else
    {
        Console.WriteLine("Capisco, peccato...");
    }
}
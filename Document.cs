//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
public class Document
{
    protected string title;
    protected int year;
    protected string genre;
    protected bool available;
    protected string shelfCode;
    protected string author;

    public Document(string title, int year, string genre, bool available, string shelfCode, string author)
    {
        this.title = title;
        this.year = year;
        this.genre = genre;
        this.available = available;
        this.shelfCode = shelfCode;
        this.author = author;
    }
}
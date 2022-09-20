//User
//cognome,
//nome,
//email,
//password,
//recapito telefonico
public class Book : Document
{
    private string isbn;
    private int pages;
    public Book(string isbn, int pages, string title, int year, string genre, bool available, string shelfCode, string author) : base(title, year, genre, available, shelfCode, author)
    {
        this.isbn = isbn;
        this.pages = pages;
    }
}
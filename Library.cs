public class Library
{
    private string name;
    private List<Book> books;
    private List<Dvd> dvds;

    public Library(string name)
    {
        this.name = name;
    }

    public List<Book> Books
    {
        get
        {
            return books;
        } set
        {
            books = value;
        }
    }

    public List<Dvd> Dvds
    {
        get { 
            return dvds; 
        } set
        {
            dvds = value;
        }
    }

    public Document GetDocument(string value)
    {
        foreach (Dvd dvd in dvds)
        {
            if (dvd.IdCode == value || dvd.Title == value)
            {
                return dvd;
            }
        }
        foreach (Book book in books)
        {
            if (book.IdCode == value || book.Title == value)
            {
                return book;
            }
        }
        return new Document();
    }
}
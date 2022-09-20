public class BookLoan : Loan{
    private Book book;

    public BookLoan(Book book, string idCode, int startDate, int endDate) : base(idCode, startDate, endDate)
    {
        this.book = book;
    }
}

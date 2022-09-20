public class DvdLoan : Loan
{
    private Dvd dvd;

    public DvdLoan(Dvd dvd, string idCode, int startDate, int endDate) : base(idCode, startDate, endDate)
    {
        this.dvd = dvd;
    }

}
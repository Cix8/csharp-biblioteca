public class Loan
{
    public string idCode;
    public int startDate;
    public int endDate;

    public Loan(string idCode, int startDate, int endDate)
    {
        this.idCode = idCode;
        this.startDate = startDate;
        this.endDate = endDate;
    }
}
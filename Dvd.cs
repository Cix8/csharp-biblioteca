//User
//cognome,
//nome,
//email,
//password,
//recapito telefonico
public class Dvd : Document
{
    private string serialNumber;
    private int durationInMinutes;

    public Dvd(string serialNumber, int durationInMinutes, string title, int year, string genre, bool available, string shelfCode, string author) : base(title, year, genre, available, shelfCode, author)
    {
        this.serialNumber = serialNumber;
        this.durationInMinutes = durationInMinutes;
    }
}
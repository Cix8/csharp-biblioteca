//cognome,
//nome,
//email,
//password,
//recapito telefonico



public class User
{
    private string surname;
    private string name;
    private string email;
    private string password;
    private string phone;

    public User(string surname, string name, string email, string password, string phone)
    {
        this.surname = surname;
        this.name = name;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }
}

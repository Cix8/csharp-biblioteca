//User
//cognome,
//nome,
//email,
//password,
//recapito telefonico

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

namespace GuessNumber.Model;

public class User
{
    public string UserName { get; set; }
    public string Email { get; set; }

    public User(string userName, string email)
    {
        if (userName is null || email is null)
        {
            throw new ArgumentNullException("Аргумент не должен быть null");
        }

        UserName = userName;
        Email = email;
    }
}
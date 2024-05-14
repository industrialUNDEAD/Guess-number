using GuessNumber.Controller.Abstractions;

namespace GuessNumber.Controller;

public class EmailValidator : IValidateEmail
{
    public void ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException("Email не может быть пустым или состоять из пробелов.");
        }

        if (!email.Contains('@'))
        {
            throw new Exception("Отсутствует директива @");
        }
    }
}
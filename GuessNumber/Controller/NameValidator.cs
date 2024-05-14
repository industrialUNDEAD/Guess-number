using GuessNumber.Controller.Abstractions;

namespace GuessNumber.Controller;

public class NameValidator : IValidateName
{
    public void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("UserName не может быть пустым.");
        }

        if (name.StartsWith('!'))
        {
            throw new Exception("UserName не может начинаться со знака !");
        }
    }
}
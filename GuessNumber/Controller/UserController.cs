using GuessNumber.Controller.Abstractions;
using GuessNumber.Model;

namespace GuessNumber.Controller;

public class UserController : ControllerBase // Принцип LSP. Производный и базовы классы имют общее поведение. 
{
    // Тип UserController соблюдает принцип SRP., т.к. через него проходит только 1 ось изменений.
    // Причина внисенеия имзенений в типе связаны исключительно с моделью User, и других причин для изменения нет.
    private IValidateName _nameValidator;
    private IValidateEmail _emailValidator;
    
    public UserController(IValidateName nameValidator, IValidateEmail emailValidator)
    {
        _nameValidator = nameValidator;
        _emailValidator = emailValidator;
    }   
    
    public void UserCreate(string name, string email)
    {
        UserValidate(name, email);
        var user = new User(name, email);

    }

    private void UserValidate(string name, string email)
    {
        // Принцип OCP.
        // Что бы расширить данный метод не нужно менять текущую функциональность, просто добавить новый код.
        // Например, если добавятся поля для юзера, то можно и расширить валидацию этих полей через новые классы с методами.
        _nameValidator.ValidateName(name);
        _emailValidator.ValidateEmail(email);
    }
}
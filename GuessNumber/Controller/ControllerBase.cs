using GuessNumber.Controller.Abstractions;

namespace GuessNumber.Controller;

public abstract class ControllerBase
{
    // Принцип DIP. Компоненты взаимодействуют через абстракции.
    // ControllerBase взаимодействует с внешним модулем через абтракцию.
    private readonly IDataSaver _saverManager = new MemorySaver(); // здесь происходит внедрение зависимости
    
    protected void Save<T>(T item) where T : class
    {
        _saverManager.Save(item);
    }

    protected ICollection<T> Load<T>() where T : class
    {
        return _saverManager.Load<T>();
    }
}
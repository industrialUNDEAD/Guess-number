using GuessNumber.Controller.Abstractions;

namespace GuessNumber.Controller;

public class MemorySaver : IDataSaver
{
    public void Save<T>(T item) where T : class
    {
        //TODO: реалиозовать сохранение в оперативной памяти.
        throw new NotImplementedException();
    }

    public ICollection<T> Load<T>() where T : class
    {
        //TODO: реалиозовать загрузку из оперативной памяти.
        throw new NotImplementedException();
    }
}
using System.Text.Json;
using GuessNumber.Controller.Abstractions;

namespace GuessNumber.Controller;

public class SerializableSaver : IDataSaver
{
    public void Save<T>(T item) where T : class
    {
        //TODO: реализовать сохоранение в json файл.
        throw new NotImplementedException();
    }

    public ICollection<T> Load<T>() where T : class
    {
        //TODO: реализовать загрузку из json файла.
        throw new NotImplementedException();
    }
}
namespace GuessNumber.Controller.Abstractions;

public interface IDataSaver
{
    void Save<T>(T item) where T : class;
    ICollection<T> Load<T>() where T : class;
}
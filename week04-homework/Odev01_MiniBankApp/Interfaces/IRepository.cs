namespace MiniBankApp.Interfaces;

public interface IRepository<T>
{
    void Add(T item);

    T? GetById(int id);

    List<T> GetAll();

    void Delete(int id);
}
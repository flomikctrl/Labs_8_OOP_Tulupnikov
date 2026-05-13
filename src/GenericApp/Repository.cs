namespace GenericRepositoryDemo {
    public class Repository<T> where T : class {
    private readonly List<T> _items = new();
    public void Add(T item) {
    _items.Add(item);
    }

    public void Remove(T item) {
    _items.Remove(item);
    }

    public IEnumerable<T> GetAll() {
    return _items;
    }

    public void PrintAll() {
    foreach (var item in _items)
    Console.WriteLine(item);
    }
    }
}
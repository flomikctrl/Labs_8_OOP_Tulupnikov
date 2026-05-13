namespace GenericRepositoryDemo {
    public class User {
    public string? Name { get; set; }
    public int Age { get; set; }

    public override string ToString() =>
    $"Пользователи: {Name}, Возраст: {Age}";
    }

    public class Product {
    public string? Title { get; set; }
    public decimal Price { get; set; }

    public override string ToString() =>
    $"Товары: {Title}, Цена: {Price} Py6.";
    }
}
Storage<int> intStorage = new();
intStorage.SetValue(42);
Console.WriteLine($"Int: {intStorage.GetValue()}");

Storage<string> strStorage = new();
strStorage.SetValue("Hello");
Console.WriteLine($"String: {strStorage.GetValue()}");

class Storage<T> {
    private T value;

    public void SetValue(T val) {
        value = val;
    }

    public T GetValue() {
        return value;
    }
}

// class IntStorage {
//     private int value;
//     public void SetValue(int val) {
//         value = val;
//     }
//     public int GetValue() {
//         return value;
//     }
// }
// class StringStorage {
//     private string? value;
//     public void SetValue(string val) {
//         value = val;
//     }
//     public string GetValue() {
//         return value;
//     }
// }
using GenericApp;

// Обмен строк
string str1 = "Hello", str2 = "World";
Console.WriteLine($"До обмена: str1 = {str1}, str2 = {str2}");
Helper.Swap(ref str1, ref str2);

Console.WriteLine();

// Вывод массивов
int[] numbers = [1, 2, 3, 4, 5];
Console.Write("Массив чисел: ");
Helper.PrintArray(numbers);

string[] words = ["C#", "Generics", "ООП"];
Console.Write("Массив строк: ");
Helper.PrintArray(words);

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



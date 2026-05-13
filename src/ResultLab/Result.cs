namespace ResultLab
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public string? Error { get; }

        // Приватный конструктор: гарантирует, что состояние объекта 
        // будет либо "успех", либо "ошибка", без промежуточных вариантов.
        private Result(T? value, string? error, bool isSuccess)
        {
            Value = value;
            Error = error;
            IsSuccess = isSuccess;
        }

        // Статический метод для успешного завершения
        public static Result<T> Success(T value) => new Result<T>(value, null, true);

        // Статический метод для возврата ошибки
        public static Result<T> Failure(string error) => new Result<T>(default, error, false);
    }
}
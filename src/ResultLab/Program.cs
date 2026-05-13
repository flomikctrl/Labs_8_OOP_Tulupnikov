using System;

namespace ResultLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ID пользователя для поиска: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                // Вызываем метод, который возвращает наш обобщенный Result
                var result = GetUserById(id);

                if (result.IsSuccess)
                {
                    Console.WriteLine($"Успешно найдено! {result.Value}");
                }
                else
                {
                    Console.WriteLine($"Произошла ошибка: {result.Error}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
        }

        // Метод имитирует поиск в базе данных
        static Result<User> GetUserById(int id)
        {
            if (id < 0)
            {
                return Result<User>.Failure("ID не может быть меньше нуля.");
            }

            // Допустим, пользователь найден
            var user = new User { Id = id, Name = "Иван Иванов" };
            return Result<User>.Success(user);
        }
    }
}
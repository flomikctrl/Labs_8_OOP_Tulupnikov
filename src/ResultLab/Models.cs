namespace ResultLab
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Пользователь: {Name} (ID: {Id})";
        }
    }
}
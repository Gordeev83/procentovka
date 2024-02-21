namespace procentovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение: ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            double result = value * percent / 100;

            Console.WriteLine($"Результат: {result}");
        }
    }
}

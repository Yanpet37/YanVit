namespace HW1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear user!");
            Console.WriteLine("I need you to fill in your name, age and height");
            Console.WriteLine("Please, enter 1 to continue");

            string input = Console.ReadLine();

            if (input != "1")
            {
                Console.WriteLine("You entered an incorrect value. Exiting program.");
                return; // Завершаемся, если импут неверный 
            }

            // Если ввели 1, то продолжаем выполнение
            Console.WriteLine("Great! Now let's continue.");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Запросили имя, сохранили

            int age;
            Console.Write("Enter your age: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid age.");
                Console.Write("Enter your age: ");
            } // Запросили возраст, проверили что можно перевести в число, проверили что больше 0, если нет то повторили

            double height;
            Console.Write("Enter your height in cm: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid height.");
                Console.Write("Enter your height in cm: "); // Запросили рост, проверили что можно ввести с запятой, проверили что больше 0, если нет повторили 
            }

            Console.WriteLine($"\nHi, {name}!");
            Console.WriteLine($"\tYour age: {age} years.");
            Console.WriteLine($"\t\tYour height: {height} cm.");
        } // Вывели
    }
}
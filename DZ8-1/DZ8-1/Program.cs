namespace DZ8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово!");
            string slovo = Console.ReadLine();

            string slovo2 = slovo.Replace(" ", "");

            char[] charSlovo = slovo2.ToCharArray();
            Array.Reverse(charSlovo);
            string slovo3 = new string(charSlovo);

            if (slovo2.Equals(slovo3, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Слово является палиндромом");
            }
            else
            {
                Console.WriteLine("Слово не является палиндромом");
            }
        }
    }
}

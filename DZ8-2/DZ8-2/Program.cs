using System.Text;

namespace DZ8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Helo World";
            StringBuilder sb = new StringBuilder();

            foreach (char element in input)
            {
                if (element != ' ')
                {
                    sb.Append(element);
                }
            }
            string result = sb.ToString();
            Console.WriteLine($"Результат: {result}");
        }
    }
}

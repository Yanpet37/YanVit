using System.Text;

namespace DZ8_2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = ("Hello World");
            StringBuilder sb = new StringBuilder("Hello World");
            sb.Replace(" ", "");
            Console.WriteLine(sb.ToString());
        }
    }
}

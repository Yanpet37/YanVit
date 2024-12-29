namespace DZ7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] DZ7 = new int[6];

            for (int i = 0; i < DZ7.Length; i++)
            {
                Console.Write($"Введите элементы массива {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    DZ7[i] = result;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                    i--;
                }
            }

            Array.Sort(DZ7);
            Array.Reverse(DZ7);
            Console.WriteLine("Отсортированные элементы массива по убыванию:");

            foreach (int num in DZ7)
            {
                Console.WriteLine(num);
            }
        }
    }
}

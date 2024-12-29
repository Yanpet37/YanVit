namespace DZ7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] DZ7 =
            {
                { 3, 4, 5 },
                { 1, 4, 9 },
                { 6, 8, 2 }
            };

            for (int row = 0; row < DZ7.GetLength(0); row++) 
            {
                int max = int.MinValue; 

                for (int colmn = 0; colmn < DZ7.GetLength(1); colmn++) 
                {
                    if (DZ7[row, colmn] > max)
                    {
                        max = DZ7[row, colmn]; 
                    }
                }

                Console.WriteLine($"Максимальное значение в строке {row + 1}: {max}");
            }
        }
    }
}

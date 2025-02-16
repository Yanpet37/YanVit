class Program
{
    static void Main()
    {
        int size = 4; 
        int[,] array =
        {
            { 5, 8, 3, 2 },
            { 6, 7, 4, 1 },
            { 9, 2, 5, 6 },
            { 3, 7, 8, 4 }
        };

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i < j)
                {
                    array[i, j] = 1;
                }
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };
            var row = "";

            string[] layers = new string[mas.GetLength(0)];
            row += "{";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                row += "{";
                string[] rows = new string[mas.GetLength(1)];
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    row += "{";
                    string[] elements = new string[mas.GetLength(2)];
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        row += mas[i, j, k];
                        if (k != mas.GetLength(2) - 1)
                        {
                            row += ",";
                        }
                    }
                    row += "}";
                    if (j != mas.GetLength(1) - 1)
                    {
                        row += ",";
                    }
                }
                row += "}";
                if (i != mas.GetLength(0) - 1)
                {
                    row += ",";
                }
            }
            row += "}";
            Console.WriteLine(row);
        }
    }
}

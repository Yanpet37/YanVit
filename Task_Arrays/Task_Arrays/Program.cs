namespace Task_Arrays;

class Program
{
    static void Main()
    {
        int[] numbers = new int[15];
        var rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 100);    
            Console.WriteLine(numbers[i]);
        }
        numbers.Min();
        numbers.Max();

        Console.WriteLine($"Массив мин {numbers.Min()} и массив макс {numbers.Max()}");  
    } 
}

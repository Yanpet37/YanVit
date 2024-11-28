namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password (Hint - three letters)");
            string введённыйПароль = Console.ReadLine();

            string правильныйПароль = "Yan";
            if (введённыйПароль == правильныйПароль)
            {
                Console.WriteLine("Password is accepted!");
                Console.WriteLine("Hello World, Hello Vita!");

            }
            else
            {
                Console.WriteLine("Password is wrong!");
            }
            //else
            //{
            //    Console.WriteLine("Password is wrong!");
            //}
        }
    }
}

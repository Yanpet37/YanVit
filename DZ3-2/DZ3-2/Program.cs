namespace DZ3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, пользователь!");

            bool boolvalue1;
            bool boolvalue2;

            while (true)
            {
                Console.Write("Введи первое булевое значение (true/false): ");
                if (bool.TryParse(Console.ReadLine(), out boolvalue1))
                {
                    break; 
                }
                Console.WriteLine("Некорректный ввод! Пожалуйста, введите 'true' или 'false'.");
            }
            // используем цикл WHILE, который не закончится пока мы не получим от пользователя булевое Value1
            // методом Console.ReadLine() считываем введенное значение и пробуем преобразовть его в булевое командой bool.TryParse
            // rоманда break завершает бесконечный цикл, так как пользователь ввёл правильное значение
            // словом out я записываю значение в переменную value1

            while (true)
            {
                Console.Write("Введи второе булевое значение (true/false): ");
                if (bool.TryParse(Console.ReadLine(), out boolvalue2))
                {
                    break; 
                }
                Console.WriteLine("Некорректный ввод! Пожалуйста, введи 'true' или 'false'.");
            }
            Console.WriteLine("\n{0,-25} | {1}", "Операция", "Результат");
            Console.WriteLine(new string('-', 30)); //строка из повторяющегося символа, спец конструкция, дефис повторится 15 раз

            Console.WriteLine("{0,-25} | {1}", $"{boolvalue1} AND {boolvalue2}", boolvalue1 && boolvalue2); //тру, если оба равны тру
            Console.WriteLine("{0,-25} | {1}", $"{boolvalue1} OR {boolvalue2}", boolvalue1 || boolvalue2); //тру, если хотя бы одно тру
            Console.WriteLine("{0,-25} | {1}", $"NOT {boolvalue1}", !boolvalue1); //если одно тру, то второе должно быть фолс
            Console.WriteLine("{0,-25} | {1}", $"NOT {boolvalue2}", !boolvalue2); 
            Console.WriteLine("{0,-25} | {1}", $"{boolvalue1} XOR {boolvalue2}", boolvalue1 ^ boolvalue2);  // тру, если только одно значение тру
            Console.WriteLine("{0,-25} | {1}", $"{boolvalue1} & {boolvalue2} (AND)", boolvalue1 & boolvalue2);  // тру, если оба, тру (проверяет оба значения обязательно)
            Console.WriteLine("{0,-25} | {1}", $"{boolvalue1} | {boolvalue2} (OR)", boolvalue1 | boolvalue2);   // тру, если хотя бы одно значение тру (проверяет оба)
            // 0 - индекс первого аргумента, -15 это ширина столбца для первого значения, минусом выравниваю по левому краю
            // | - оюычный разделитель, вставляю когда хочу
            // 1 - второе значение

        }
    }
}
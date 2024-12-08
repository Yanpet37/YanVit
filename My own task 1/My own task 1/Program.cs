namespace My_own_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int priceApples = 3; //задаю константные переменные для хранения цент на товары
            const int priceBananas = 2;
            const int priceMilk = 4;
            const int priceBread = 5;

            int total = 0; //переменная для суммы покупок, в неё буду считать 

            //в общем это забавная новая штука для меня - флаг для управления циклом while, т.е. цикл работает пока есть True
            //при вводе "5" срабатывает false и цикл завершается
            bool isRunning = true;

            //вывожу меню с товарами и приветственные слова
            Console.WriteLine("Welcome to the Shopping Cart!");
            Console.WriteLine("1. Apples - $3");
            Console.WriteLine("2. Bananas - $2");
            Console.WriteLine("3. Milk - $4");
            Console.WriteLine("4. Bread - $5");
            Console.WriteLine("5. Checkout");
            
            //здесь как я понимаю то что в скобказ связано с флагом т.е.  цикл работает, пока пользователь не выберет выход 5
            while (isRunning)
            {
                Console.Write("\nEnter your choice: "); //запрашиваем выбор пользователя
                string input = Console.ReadLine(); // Читаем ввод с консоли

                //проверяем, что пользователь ввел корректное число - если нет внизу блок для отработки
                if (int.TryParse(input, out int choice))
                {
                    //ну а вот теперь switch для обработки выбора
                    switch (choice)
                    {
                        case 1: //если пользователь выбрал "1" (яблоки)
                            total += priceApples; // Добавляем цену яблок к общей сумме
                            Console.WriteLine($"Apples added. Total: ${total}");
                            break; //завершаем выполнение этого блока case

                        case 2: //если пользователь выбрал "2" (бананы)
                            total += priceBananas; // Добавляем цену бананов к общей сумме
                            Console.WriteLine($"Bananas added. Total: ${total}");
                            break; 

                        case 3: //если пользователь выбрал "3" (молоко)
                            total += priceMilk; // Добавляем цену молока к общей сумме
                            Console.WriteLine($"Milk added. Total: ${total}");
                            break; 

                        case 4: //если пользователь выбрал "4" (хлеб)
                            total += priceBread; // Добавляем цену хлеба к общей сумме
                            Console.WriteLine($"Bread added. Total: ${total}");
                            break; 

                        case 5: //если пользователь выбрал "5" (Checkout)
                            Console.WriteLine("Checking out..."); // Выводим сообщение
                            isRunning = false; // Меняем флаг, чтобы выйти из цикла
                            break; 

                        default: // Если введено число, не соответствующее пунктам меню
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break; // Завершаем выполнение блока default
                    }

                    //каждый блок case выполняется, если значение choice совпадает с указанными в переменных числами
                    //после выполнения блока case программа выходит из switch из-за команды break
                    //если значение не соответствует ни одному case, выполняется блок default.
                }
                else
                {
                    //вторая часть if - если пользователь ввел что-то некорректное (например, буквы вместо числа)
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            //после выхода из цикла подводим итоги
            Console.WriteLine("\n--- Checkout Summary ---");
            //"\n" - Это управляющий символ, обозначающий перенос строки
            //при добавлении \n текст, который идет после него, выводится с новой строки.

            Console.WriteLine($"Total before discount: ${total}");

            // Проверяем, нужно ли применять скидку
            int discount = total > 5 ? 1 : 0; // Скидка $1, если сумма больше $5
            Console.WriteLine($"Discount applied: ${discount}");
            Console.WriteLine($"Final total: ${total - discount}");
            Console.WriteLine("Thank you for shopping!");
        }
    }
}
    


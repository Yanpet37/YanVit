namespace DZ9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            products.Add("молоко", 3); 
            products.Add("масло", 4);

            Console.WriteLine("Список продуктов:");
            foreach (var product in products)
            {
                Console.WriteLine($"Продукт: {product.Key}, Цена: {product.Value}");
            }
            
            Console.Write("Для поиска введите название: ");
            string productName = Console.ReadLine();

            if (products.ContainsKey(productName))
            {
                Console.WriteLine($"Цена продукта '{productName}': {products[productName]}");
            }
            else
            {
                Console.WriteLine($"Продукт '{productName}' отсутствует в списке.");
            }
            foreach (var key in products.Keys.ToList()) 
            {
                products[key] *= 1.1; 
            }

            Console.WriteLine("Обновлённые цены продуктов:");
            foreach (var product in products)
            {
                Console.WriteLine($"Продукт: {product.Key}, Цена: {product.Value}");
            }
        }
    }
}

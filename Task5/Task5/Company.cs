namespace Task5
{
    public class Company
    {
        public virtual string Name { get; set; }
        public virtual int Year { get; set; }
        public virtual void SeeInfo()
        {
            Console.WriteLine($"Компания: {Name}, Основана в: {Year}");
        }
    }
}

using Task3;

namespace Task3
{
    public static class DTExten
    {
        public static string MethodX(this DateTime date)
        {
            int year = date.Year + 5508;
            int day = date.Day;
            string monthName = date.ToString("MMMM");

            return $"День '{day}' месяца '{monthName}' года '{year}' от сотворения мира.";
        }
    }
}

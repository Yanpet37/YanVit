namespace Task2
{
    public class MyString
    {
        private string value;

        public MyString()
        {
            value = string.Empty;
        }

        public MyString(string input)
        {
            value = input;
        }

        public string Reverse()
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

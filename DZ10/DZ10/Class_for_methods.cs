namespace DZ10
{
    public class InputValidator
    {
        public void ValidateInput(string input)
        {
            if (input != "боль")
            {
                throw new InvalidInputExceptionnn("Недопустимый ввод: разрешено только слово 'боль' в нижнем регистре.");
            }
        }
    }
}



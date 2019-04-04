namespace ExampleDomain.Services
{
    public class UpperCaseTextChanger
    {
        public string Change(string message)
        {
            return message.ToUpper();
        }
    }
}
namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration validation using c#");
            ValidFirstName validFirstName = new ValidFirstName();
            validFirstName.IsValidFirstName();
        }
    }
}
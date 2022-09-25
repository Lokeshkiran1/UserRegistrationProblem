namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration validation using c#");
            Patterns validFirstName = new Patterns();
            validFirstName.IsValidFirstName();
            validFirstName.IsValidLastName();
            validFirstName.IsValidEmail();
        }
    }
}
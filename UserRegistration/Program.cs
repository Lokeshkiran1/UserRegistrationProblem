namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration validation using c#");
            Pattern validFirstName = new Pattern();
            validFirstName.IsValidFirstName();
            validFirstName.IsValidLastName();
        }
    }
}
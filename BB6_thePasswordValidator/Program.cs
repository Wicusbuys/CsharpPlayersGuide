//Boss Battle: The Password Validator
//-------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        PasswordValidator validator = new PasswordValidator();

        while (true)
        {
            Console.Write("Enter a password: ");
            string? input = Console.ReadLine();

            if (input == null) break;

            if (validator.IsValid(input)) Console.WriteLine("Password is valid");
            else Console.WriteLine("Password is not valid");
        }
    }
}

class PasswordValidator
{
    public bool IsValid(string password)
    {
        return password.Length >= 6
            && password.Length <= 13
            && password.Any(char.IsUpper)
            && password.Any(char.IsLower)
            && password.Any(char.IsDigit)
            && !password.Contains('T')
            && !password.Contains('&');
    }
}
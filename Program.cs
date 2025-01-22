using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password: ");

            string password = Console.ReadLine();

            if (PasswordValid(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is not valid");
            }

            static bool PasswordValid(string password)
            {
                if (password.Length < 8)
                {
                    return false;
                }

                bool hasLower = false;
                bool hasUpper = false;
                bool hasSpecialChar = false;
                bool hasDigit = false;

                foreach (char c in password)
                {
                    if (char.IsLower(c))
                    {
                        return true;
                    }
                    else if (char.IsUpper(c))
                    {
                        return true;
                    }
                    else if (!char.IsLetterOrDigit(c))
                    {
                        return true;
                    }
                    else if (char.IsDigit(c))
                    {
                        return true;
                    }

                    if (hasLower && hasUpper && hasSpecialChar && hasDigit)
                    {
                        break;
                    }
                }
                return hasUpper && hasSpecialChar && hasDigit && hasLower;
            }
        }
    }
}

using System;

namespace WritePasswordInvisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InputPassword());
        }
        public static string InputPassword()
        {
            string password = "";
            string stars = "*";
            Console.Write("Enter password: ");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password = password.Substring(0, password.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    password += key.KeyChar;
                    Console.Write(stars);
                }
            }
            return password;
        }
    }
}
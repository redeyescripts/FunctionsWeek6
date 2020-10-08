using System;
using System.Reflection.PortableExecutable;

namespace FunctionsWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            Triip1();
        }

        public static void HelloUser()
        {
            Console.WriteLine("Enter your name:");
                string userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}");
        }

        public static void Triip1()
        {
            Console.WriteLine("Enter your first number:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int b = Int32.Parse(Console.ReadLine());

            int result = a + b;
                Console.WriteLine(result);
        }
    }
}

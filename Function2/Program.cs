using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5);
            DisplayString("100");
        }
        public static  void ParamsSum(int a, int b)
        {
            int result = a + b;
                Console.WriteLine(result);

        }
        public static void DisplayString(string someString)
        {
            Console.WriteLine(someString);
        }
    }
}

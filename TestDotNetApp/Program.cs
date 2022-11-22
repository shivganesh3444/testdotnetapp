using System;

namespace TestDotNetApp
{
    public class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multiplication(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                int a, b;
                Program pObj = new Program();


                Console.Write("Enter first number?");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number?");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Addintion is {0}", pObj.add(a, b));
                Console.WriteLine("Multiplication is {0}", pObj.multiplication(a, b));

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

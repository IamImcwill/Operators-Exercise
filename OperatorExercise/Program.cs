using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtract = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {subtract}");
            Console.WriteLine($"{a} + {b} is {product}");
            Console.WriteLine($"{a} + {b} is {quotient} remainder {remainder}");




            //1. modifier 2. scope 3. return type 4. method name 5. parameter

            static double AreaOfCircle(double radius)
            {
                return Math.PI* Math.Pow(radius, 2);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter the radius");
               double userInput =  double.Parse(Console.ReadLine());
             
                Console.WriteLine(AreaOfCircle(userInput));
             
            }
    }
    }
}

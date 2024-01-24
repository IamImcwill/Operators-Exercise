namespace OperatorExercise
{
    public class Program
    {
        //1.modifier 2. scope 3.return type  4. method name 5. parameter
        public static double AreaOfCicle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius");
            double userInput = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCicle(userInput));





            int a = 17;
            int b = 4;

            //Other operation;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            //Output for other operation

            Console.WriteLine($"Addition: {a} + {b} is {sum}.");
            Console.WriteLine($"Subtraction: {a} - {b} is {difference}.");
            Console.WriteLine($"Multiplication: {a} * {b} is {product}.");


            //Division integer division

            int quotient = a / b;
            int remainder = a % b;

            //Output using string interpolation

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");








        }
    }
}


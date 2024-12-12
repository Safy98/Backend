namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sum of two number

            float n1, n2;
            Console.WriteLine("Enter Two Number to get thier sum");
            Console.WriteLine("Enter the first number");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seconed number");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The result is {n1 + n2}");

            #endregion

            #region Operations

            Console.WriteLine($"-1+4*6 = {-1+4*6}");
            Console.WriteLine($"( 35+ 5 ) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($" 2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");


            #endregion

            #region

            Console.WriteLine("Enter the first integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("\nComparison Results:");

            // Complex expression 1: Check if all three numbers are equal
            Console.WriteLine($"1. All numbers are equal: {a == b && b == c}");

            // Complex expression 2: Check if any two numbers are equal
            Console.WriteLine($"2. Any two numbers are equal: {(a == b || b == c || a == c)}");

            // Complex expression 3: Check if the first number is greater than the sum of the other two
            Console.WriteLine($"3. First number is greater than the sum of the other two: {a > (b + c)}");

            // Complex expression 4: Check if the product of two numbers equals the third number
            Console.WriteLine($"4. Product of any two numbers equals the third: {(a * b == c || b * c == a || a * c == b)}");

            // Complex expression 5: Check if the numbers are in ascending order
            Console.WriteLine($"5. Numbers are in ascending order: {a < b && b < c}");

            Console.WriteLine("\nEnd of Comparison.");

            #endregion

        }
    }
}

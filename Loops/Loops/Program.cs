using static System.Console;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int product = 1;

            for (int i = 1; i < 40; i += 3)
            {
                product *= i;
            }
            WriteLine("Task 1");
            WriteLine($"{product}\n");

            //Task 2

            int count = 0;
            int sum = 0;
            int product1 = 1;

            for (int i = -30; i <= 28; i++)
            {
                if (i % 3 == 0 && i % 6 == 0)
                {
                    sum += i;
                }
                if (i % 5 == 0 && i % 2 == 0)
                {
                    product1 *= i;
                }
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            WriteLine("Task 2");
            WriteLine($"Sum: {sum}");
            WriteLine($"Product: {product1}");
            WriteLine($"Count: {count}\n");

            //Task 3

            long numberOne = 304001;
            long numberTwo = 304001;
            long remainder = 0;
            long sum1 = 0;
            int count1 = 0;

            while (numberOne > 0)
            {
                remainder = numberOne % 10;
                sum1 += remainder;
                numberOne = numberOne / 10;
            }
            WriteLine("Task 3");
            WriteLine($"Sum of positive digits of 304001: {sum1}");

            while (numberTwo > 0)
            {
                remainder = numberTwo % 10;
                numberTwo /= 10;

                if (remainder >= 0)
                {
                    count1++;
                }
            }
            WriteLine(count1);
            

        }

    }
}
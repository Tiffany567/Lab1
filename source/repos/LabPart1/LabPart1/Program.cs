using System;
using System.Linq;

namespace LabPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1, number2;
            bool repeat1 = true;
            char doAgain;

            while (repeat1 == true)
            {
                Console.WriteLine("Enter two numbers of the same length.");
                Console.WriteLine("Enter first number:");
                number1 = Console.ReadLine();
                var length1 = number1.Length;
                Console.WriteLine("Enter second number:");
                number2 = Console.ReadLine();
                var length2 = number2.Length;
                    if (length1 == length2)
                    {
                    Console.WriteLine(DigitTotals(number1, number2));
                    //DigitTotals will check if the corresponding digits summed will equal each other.
                    }
                    else
                    {
                        Console.WriteLine("Please put numbers that are the same length.");
                    }
                Console.WriteLine("Do you want to run this program again? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());
                //Program can run again if the user so chooses. 
                if (doAgain == 'Y' || doAgain == 'y')
                {
                    repeat1 = true;
                }
                else
                {
                    repeat1 = false;
                }
            }

        }

        private static bool DigitTotals(string x, string y)
        {
            var arr1 = x.ToCharArray();
            var intarr1 = arr1.Select(a => int.Parse(a.ToString()));
            var arr2 = y.ToCharArray();
            var intarr2 = arr2.Select(b => int.Parse(b.ToString()));
            var sumint = intarr1.Zip(intarr2, (a, b) => (a + b));
            //Used Lambda expression to add corresponding digits
            var sumarr = sumint.ToArray();
            int[] numbers = sumarr;
            if (Array.TrueForAll(numbers, c => c == numbers[0]))
            //Used Lambda expression to compare each element in numbers to the first element in numbers.
                    {
                        bool results= true;
                        return results;
                    }
                    else
                    {
                        bool results = false;
                        return results;

                    }
        }
    }
}

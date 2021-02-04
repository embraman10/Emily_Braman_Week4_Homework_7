using System;

namespace Emily_Braman_Week4_Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables
            int number;
            int digit1;
            int digit2;
            int digit3;
            int digit4;
            int digit5;

            Console.WriteLine("Enter five-digit interger: ");
            number = Convert.ToInt32(Console.ReadLine());

            //split each digit entered
            digit1 = number / 10000;
            digit2 = number % 10000 / 1000;
            digit3 = number % 1000 / 100;
            digit4 = number % 100 / 10;
            digit5 = number % 10;

            Console.WriteLine("The digits in {0} are: {1} {2} {3} {4} {5}", number, digit1, digit2, digit3, digit4, digit5);
            Console.ReadKey();
        }
    }
}

using System;

namespace Homework_2
{
    // enum for task 3
    enum HTTPerror
    {
        Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405

    }

    //enum for task 4
    enum Dog
    {
        Name,
        Mark,
        Age
    }

    class Program
    {
        static void Main(string[] args)
        {

            int numbers_in_range = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number: ");
                float float_number = Convert.ToSingle(Console.ReadLine());

                if (float_number >= -5 & float_number <= 5)
                {
                    numbers_in_range += 1;
                }
            }

            Console.WriteLine($"{numbers_in_range} numbers in range [-5;5]");


            int min;
            int max = 0;

            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            min = number;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Max number - {max}, min number - {min}");


            Console.WriteLine("Enter number of http error");
            int error = Convert.ToInt32(Console.ReadLine());

            switch (error)
            {
                case 400:
                    Console.WriteLine("Bad requests error");
                    break;
                case 401:
                    Console.WriteLine("Unauthorized error");
                    break;
                case 402:
                    Console.WriteLine("Payment required error");
                    break;
                case 403:
                    Console.WriteLine("Not found error");
                    break;
                case 404:
                    Console.WriteLine("Not found");
                    break;
                case 405:
                    Console.WriteLine("Method not allowed error");
                    break;
                default:
                    Console.WriteLine("The error does not exist, or it is simply not added to this code :)");
                    break;
            }

        }
    }
}
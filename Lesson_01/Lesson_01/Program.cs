using System;
namespace Lesson_02
{
    class antonb_task02
    {
        static void PrintFizzBuzz(int start, int stop)
        {
            /* Method prints values from 'start' to 'stop' with next exceptions:
             * "Fizz" when value devides by 3
             * "Buzz" when value devides by 5
             * "FizzBuzz" for both (or 15)
            */
            for (int i = start; i <= stop; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("i={0,3} output> FizzBuzz", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("i={0,3} output> Fizz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("i={0,3} output> Buzz", i);
                }
                else
                {
                    Console.WriteLine("i={0,3} output> {0}", i);
                }

            }
        }
        static void Main(string[] args)
        {
            //Initialize with range from 1 to 100
            PrintFizzBuzz(1, 100);
            //Keep it opened untill key pressing
            Console.ReadKey(false);
        }
    }
}
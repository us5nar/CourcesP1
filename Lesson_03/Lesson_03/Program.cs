using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello, world!";
            int a, b;
            a = 1;
            b = 2;
            int c = 1;
            int d = 1;
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            //Console.WriteLine(isE);
            //int result = 
            Console.WriteLine(hello[1]);
            //if (String.IsNullOrEmpty) -- use for check
            Console.WriteLine(CalcObj(2, 4));
            Console.ReadKey(false);

        }
        static void IntArray(int[] arrayToInt)
        {
            Random random = new Random();
            for (int i = 0; i < arrayToInt.Length; i++)
            {
                arrayToInt[i] = random.Next();
            }
        }
        static void modify(ref int a)
        {
            a = 123;
        }
        static void modifyByOut(out int a)
        {
            a = 78;
        }
        static int CalcObj(object c, object d)
        {
            int first = (int)c;
            int second = (int)d;
            return first + second;

        }
    }
}

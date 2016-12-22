using System;
using System.Collections.Generic;
using System.Text;

namespace EventsUnderstanding
{
    class Program
    //https://habrahabr.ru/post/213809/

    {
        static void Main(string[] args)
        {
            ClassCounter Counter = new ClassCounter();
            Handler_I   Handler1 = new Handler_I();
            Handler_II  Handler2 = new Handler_II();

            //Подписались на событие
            //for udescribe it use -=
            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;

            //run the counter
            Counter.Count();

            Console.ReadKey(false);
        }
    }
}

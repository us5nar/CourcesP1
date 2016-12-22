using System;
using System.Collections.Generic;
using System.Text;

namespace EventsUnderstanding
{
    class ClassCounter
    {
        public delegate void MethodContainer(); // the same signature with our methods void(void)
        public event MethodContainer onCount; //the event baced on the delegate type
        public void Count()
        { for (int i = 0; i < 100;i++)
            {
                if (i == 71){ onCount();}
            }
        }
    }
}

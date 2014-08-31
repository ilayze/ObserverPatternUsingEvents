using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject();
            Observer1 observer1 = new Observer1(s);

            s.SomeMethodThatRaiseTheEvent();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Observer1
    {
        public Observer1(Subject s)
        {
           s.myEvent+=s_myEvent;
        }

        private void s_myEvent(Subject sender, EventArgs e)
        {
            Console.WriteLine("In observer1 method subject int is "+sender.subjectInt);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject
    {

        public delegate void SubjectHandler(Subject s, EventArgs e);
        public event SubjectHandler myEvent;

        public int subjectInt { get; set; }

        public Subject()
        {
            subjectInt = 5;
        }

        public void SomeMethodThatRaiseTheEvent()
        {
            Console.WriteLine("Before raising event");

            if(myEvent!=null)
            {
                myEvent(this,null);
            }
        }
    }
}

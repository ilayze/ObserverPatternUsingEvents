using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Observer1
    {
       
        public void subjectHandler(Subject sender, EventArgs e)
        {
            Console.WriteLine("In observer1 method subject int is "+sender.subjectInt);
        }
    }
}

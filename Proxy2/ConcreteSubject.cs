using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy2
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("I've processed your request.");
        }
    }
}

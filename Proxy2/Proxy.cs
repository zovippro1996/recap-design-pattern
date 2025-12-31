using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy2
{
    public class Proxy : Subject
    {
        Subject? subject;
        string[] registeredUsers;
        string currentUser;

        public Proxy(string currentUser)
        {
            registeredUsers = ["Admin", "Rohit", "Sam"];
            this.currentUser = currentUser;
        }

        public override void DoSomeWork()
        {
            Console.WriteLine($"{currentUser} wants to access into the system.");
            if (registeredUsers.Contains(currentUser))
            {
                Console.WriteLine($"Welcome, {currentUser}.");
                if (subject == null)
                {
                    subject = new ConcreteSubject();
                    subject.DoSomeWork();
                }
            }
            else
            {
                Console.WriteLine($"Sorry {currentUser}, you do not have access into the system.");
            }
        }
    }
}

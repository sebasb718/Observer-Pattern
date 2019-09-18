using System;
using System.Collections.Generic;
using Push_Notifications.Entities;

namespace Push_Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- Observer Pattern -----------------------");

            UserAccount subject = new UserAccount("Sebastian Bernal","sb@gmail.com","sebasb718");
            subject.Register(new SMSObserver());
            subject.Register(new MailObserver());

            Console.WriteLine("-----> Changing Name");
            subject.Name = "bla bla";
            Console.WriteLine("-----> Changing Mail");
            subject.Mail = "bla bla";
            Console.WriteLine("-----> Changing User Name");
            subject.UserName = "bla bla";
            Console.WriteLine();
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }

    public class SMSObserver : IObserver
    {
        public void Alert(string Info)
        {
            Console.WriteLine($"[{this.GetType().Name}] Data ({Info}) has changed on user, sending SMS");
            
        }
    }

    public class MailObserver : IObserver
    {
        public void Alert(string Info)
        {
            Console.WriteLine($"[{this.GetType().Name}] Data ({Info}) has changed on user, sending mail");
        }
    }

    
}

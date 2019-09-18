using System;
using System.Collections.Generic;
using System.Text;

namespace Push_Notifications.Entities
{
    public class UserAccount : IUserAccount
    {
        private List<IObserver> Observers = new List<IObserver>();

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyDataChanged("Name");
            }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set
            {
                mail = value;
                NotifyDataChanged("Mail");
            }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                NotifyDataChanged("UserName");
            }
        }

        public UserAccount(string name, string mail, string userName)
        {
            this.name = name;
            this.mail = mail;
            this.userName = userName;
        }
        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void Unregister(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void NotifyDataChanged(string PropertyName)
        {
            foreach (IObserver observer in Observers)
            {
                observer.Alert(PropertyName);
            }
        }
    }
}

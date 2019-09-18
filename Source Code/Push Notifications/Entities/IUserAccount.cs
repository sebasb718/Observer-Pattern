using System;
using System.Collections.Generic;
using System.Text;

namespace Push_Notifications.Entities
{
    public interface IUserAccount
    {
        string Name { get; set; }
        string UserName { get; set; }
        string Mail { get; set; }

        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void NotifyDataChanged(string PropertyName);
    }
}

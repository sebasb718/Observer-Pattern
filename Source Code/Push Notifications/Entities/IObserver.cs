using System;
using System.Collections.Generic;
using System.Text;

namespace Push_Notifications.Entities
{
    public interface IObserver
    {
        void Alert(string Info);
    }
}

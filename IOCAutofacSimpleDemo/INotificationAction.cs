using IOCAutofacSimpleDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCAutofacSimpleDemo
{
     interface INotificationAction
    {
         void ActOnNotification(Employee employee, string message);
    }
}

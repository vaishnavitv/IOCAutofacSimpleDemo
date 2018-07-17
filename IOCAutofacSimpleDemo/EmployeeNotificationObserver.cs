using IOCAutofacSimpleDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCAutofacSimpleDemo
{
    class EmployeeNotificationObserver
    {
        readonly IList<Employee> employees;
        readonly INotificationAction notificationAction;

        public EmployeeNotificationObserver(IList<Employee> employees, INotificationAction notificationAction)
        {
            this.employees = employees;
            this.notificationAction = notificationAction;
        }

        public void FindExpertsToNotify()
        {
            var experts = employees.Where(e => e.Experience > 8);

            foreach (var item in experts)
            {
                notificationAction.ActOnNotification(item, notificationAction.GetType().ToString());
            }
        }
    }
}

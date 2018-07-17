using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOCAutofacSimpleDemo.DataModels;

namespace IOCAutofacSimpleDemo
{
    class EventLogWriterSender : INotificationAction
    {
        EventLog appLog;
        // Create an event ID to add to the event log
        int eventID = 8;
        public EventLogWriterSender()
        {
            appLog = new EventLog("Application");

            //if (!System.Diagnostics.EventLog.SourceExists("TestApplication"),)
            //{
            //    System.Diagnostics.EventLog.CreateEventSource("TestApplication", "Application");
            //}
            appLog.Source = "TestApplication";
        }
        public void ActOnNotification(Employee employee, string message)
        {
            appLog.WriteEntry(string.Format("Employee {0} triggered email with Context {1}.", employee.Name, message),
                System.Diagnostics.EventLogEntryType.Information,
                        eventID);
        }
    }
}

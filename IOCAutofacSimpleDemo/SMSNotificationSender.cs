using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOCAutofacSimpleDemo.DataModels;

namespace IOCAutofacSimpleDemo
{
    class SMSNotificationSender : INotificationAction
    {
        private readonly TextWriter _textWriter;

        public SMSNotificationSender(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public void ActOnNotification(Employee employee, string message)
        {
            _textWriter.WriteLine(string.Format("Employee {0} triggered email with Context {1}.", employee.Name, message));
        }
    }
}

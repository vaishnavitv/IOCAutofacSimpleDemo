using Autofac;
using IOCAutofacSimpleDemo.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCAutofacSimpleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Jane",  Department="Engineering",   Position = "Sr. Software Engineer", Experience = 9 },
                new Employee { Name = "Margeret",  Department="Engineering",Position = "Intermediate Software Engineer", Experience = 5 },
                new Employee { Name = "Alex",  Department="Quality Assurance",Position = "Validation Engineer", Experience = 3 },
                new Employee { Name = "Philip",  Department="Human Resource",Position = "HR", Experience = 11 },
                new Employee { Name = "Cathy", Department="Human Resource", Position = "Admin Assistant", Experience = 7 }
            };

            ContainerBuilder autofaceContainer = new ContainerBuilder();
            autofaceContainer.Register(c => new EmployeeNotificationObserver(c.Resolve<IList<Employee>>(), c.Resolve<INotificationAction>()));

            autofaceContainer.RegisterType<SMSNotificationSender>().As<INotificationAction>();
            //To log in event viewer we need admin privieldge. Run the app in admin mode
            //autofaceContainer.RegisterType<EventLogWriterSender>().As<INotificationAction>();
            //autofaceContainer.RegisterType<EmailNotificationSender>().As<INotificationAction>();
        
            autofaceContainer.RegisterInstance(employees).As<IList<Employee>>();
            autofaceContainer.RegisterInstance(Console.Out).As<TextWriter>();
            using (var container  = autofaceContainer.Build())
            {
                container.Resolve<EmployeeNotificationObserver>().FindExpertsToNotify();
            }

            Console.ReadKey();
        }
    }
}

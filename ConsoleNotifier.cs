﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class ConsoleNotifier: IEventNotifier
    {


        private List<string> Notificatons { get; }

        public ConsoleNotifier()
        {
            Notificatons = new List<string>();
        }

        public void NotifyAboutEventByType(EventType type, string message)
        {
            var resultMessage = $"For action - {type} you have message: {message}";
            Notificatons.Add(resultMessage);
            Console.WriteLine(resultMessage);
            Console.WriteLine("----------------------------------------");
        }

        public string GetLastNotification()
        {
            return Notificatons.LastOrDefault();
        }

    }
}

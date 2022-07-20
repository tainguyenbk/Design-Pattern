using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Notifiers
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videodata)
            {
                Console.WriteLine(
                    string.Format($"Notify all subscribes via PHONE with new data" +
                                    "\n\tName: {0}" +
                                    "\n\tDescription: {1}" +
                                    "\n\tFile Name: {2}",
                                    videodata.GetTitle(),
                                    videodata.GetDescription(),
                                    videodata.GetFileName()));
            }
        }
    }
}

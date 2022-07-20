using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Base
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetechObserver (Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(Subject subject, object arg)
        {
            _observers.ForEach((observer) => observer.Notify(subject, arg));
        }
    }
}

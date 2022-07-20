using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Base
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(Subject subject, object arg);
    }
}

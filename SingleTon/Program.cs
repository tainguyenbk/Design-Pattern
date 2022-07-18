using System;
using System.Threading;

namespace SingleTon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() => Singleton.GetSingleton().SayHi());
            var thread2 = new Thread(() => Singleton.GetSingleton().SayHi());
            var thread3 = new Thread(() => Singleton.GetSingleton().SayHi());
            var thread4 = new Thread(() => Singleton.GetSingleton().SayHi());

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
        }
    }
}

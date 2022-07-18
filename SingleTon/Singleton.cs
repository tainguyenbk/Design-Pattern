using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    public class Singleton
    {
        private int index;
        private static readonly object lockObject = new object();

        // volatile: goi uniqueInstance voi version moi nhat
        private static volatile Singleton uniqueInstance;
        private Singleton(int index)
        {
            this.index = index;
        }

        public static Singleton GetSingleton()
        {
            // neu uniqueInstance null thi khoa ham GetSingleton lai
            // Dung lock de tranh truong hop tao nhieu Instance khi su dung Thread
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();
                        // Ham ranom gia tri tu 1 den < 4 (1 den 3)
                        uniqueInstance = new Singleton(random.Next(1, 4));
                    }                    
                }
            }
            return uniqueInstance;
        }

        public void SayHi()
        {
            Console.WriteLine("Hello, I am Tai number " + index);
        }
    }
}

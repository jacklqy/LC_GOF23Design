using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Observer
{
    public class Dog : IObserver
    {
        public void Action()
        {
            this.Wang();
        }

        public void Wang()
        {
            Console.WriteLine("{0} Wang", this.GetType().Name);
        }
    }
}

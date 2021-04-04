using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Observer
{
    public class Father : IObserver
    {
        public void Action()
        {
            this.Roar();
        }

        public void Roar()
        {
            Console.WriteLine("{0} Roar", this.GetType().Name);
        }
    }
}

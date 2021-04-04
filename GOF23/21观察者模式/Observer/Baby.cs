using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Observer
{
    public class Baby : IObserver
    {
        public void Action()
        {
            this.Cry();
        }

        public void Cry()
        {
            Console.WriteLine("{0} Cry", this.GetType().Name);
        }
    }
}

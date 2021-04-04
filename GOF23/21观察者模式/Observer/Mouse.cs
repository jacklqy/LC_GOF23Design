using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Observer
{
    public class Mouse : IObserver
    {
        public void Action()
        {
            this.Run();
        }

        public void Run()
        {
            Console.WriteLine("{0} Run", this.GetType().Name);
        }
    }
}

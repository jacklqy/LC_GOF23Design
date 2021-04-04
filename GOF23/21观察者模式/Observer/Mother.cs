using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._21观察者模式.Observer
{
    public class Mother : IObserver
    {
        public void Action()
        {
            this.Whisper();
        }

        public void Whisper()
        {
            Console.WriteLine("{0} Whisper", this.GetType().Name);
        }
    }
}

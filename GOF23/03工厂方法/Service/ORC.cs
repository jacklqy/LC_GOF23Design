using GOF23._02简单工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._03工厂方法.Service
{
    public class ORC : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("This {0}", this.GetType().Name);
        }
    }
}

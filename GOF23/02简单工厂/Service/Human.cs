using GOF23._02简单工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._02简单工厂.Service
{
    public class Human : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("This {0}", this.GetType().Name);
        }
    }
}

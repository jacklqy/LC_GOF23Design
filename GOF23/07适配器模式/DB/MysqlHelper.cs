﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._07适配器模式
{
    public class MysqlHelper : IHelper
    {
        public void Add<T>()
        {
            Console.WriteLine("this is {0} Add", this.GetType().Name);
        }

        public void Delete<T>()
        {
            Console.WriteLine("this is {0} Delete", this.GetType().Name);
        }

        public void Query<T>()
        {
            Console.WriteLine("this is {0} Query", this.GetType().Name);
        }

        public void Update<T>()
        {
            Console.WriteLine("this is {0} Update", this.GetType().Name);
        }
    }
}

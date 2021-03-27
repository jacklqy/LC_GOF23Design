using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._07适配器模式
{
    /// <summary>
    /// 第三方提供的 OpenStack servicestack
    /// 不能修改
    /// </summary>
    public class RedisHelper //: IHelper
    {
        public void AddRedis<T>()
        {
            Console.WriteLine("this is {0} Add", this.GetType().Name);
        }

        public void DeleteRedis<T>()
        {
            Console.WriteLine("this is {0} Delete", this.GetType().Name);
        }

        public void QueryRedis<T>()
        {
            Console.WriteLine("this is {0} Query", this.GetType().Name);
        }

        public void UpdateRedis<T>()
        {
            Console.WriteLine("this is {0} Update", this.GetType().Name);
        }
    }
}

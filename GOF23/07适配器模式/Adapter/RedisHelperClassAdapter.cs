using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._07适配器模式
{
    /// <summary>
    /// 类适配器，通过类的继承方式
    /// </summary>
    public class RedisHelperClassAdapter : RedisHelper, IHelper
    {
        public void Add<T>()
        {
            base.AddRedis<T>();
        }

        public void Delete<T>()
        {
            base.DeleteRedis<T>();
        }

        public void Query<T>()
        {
            base.QueryRedis<T>();
        }

        public void Update<T>()
        {
            base.UpdateRedis<T>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._07适配器模式
{
    /// <summary>
    /// 对象适配器，通过类的组合方式
    /// </summary>
    public class RedisHelperObjectAdapter : IHelper
    {
        //方式一
        //private RedisHelper _RedisHelper = new RedisHelper();

        //方式二 类的组合方式常用
        private RedisHelper _RedisHelper = null;
        public RedisHelperObjectAdapter(RedisHelper redisHelper) //参数还可以是ICacheHelper抽象，具体传入由上层决定
        {
            this._RedisHelper = redisHelper;
        }

        public void Add<T>()
        {
            this._RedisHelper.AddRedis<T>();
        }

        public void Delete<T>()
        {
            this._RedisHelper.DeleteRedis<T>();
        }

        public void Query<T>()
        {
            this._RedisHelper.QueryRedis<T>();
        }

        public void Update<T>()
        {
            this._RedisHelper.UpdateRedis<T>();
        }
    }
}

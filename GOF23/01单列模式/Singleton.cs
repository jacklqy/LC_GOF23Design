using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._01单列模式
{
    /// <summary>
    /// 懒汉式（双if加锁）
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _Singleton = null;
        /// <summary>
        /// 锁，微软官方推荐static readonly
        /// </summary>
        private static readonly object _Singletion_Lock = new object();
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("Singleton被实例化啦...");
        }
        /// <summary>
        /// 对外提供获取实例的统一入口
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            //双if加锁
            if (_Singleton == null)//外面在套一层判断，是为了优化性能，避免对象已经被初始化后，再次请求还需要等待锁。
            {
                lock (_Singletion_Lock)//可以保证任何时候只有一个线程进入，其他线程等待。
                {
                    if (_Singleton == null)
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }

        public void Show()
        {
            Console.WriteLine("Singleton.Show被调用啦...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._01单列模式
{
    /// <summary>
    /// 懒汉式
    /// </summary>
    public sealed class Singleton
    {
        public static Singleton _Singleton = null;
        public static readonly object _Singletion_Lock = new object();
        private Singleton()
        {
            Console.WriteLine("Singleton被实例化啦...");
        }
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

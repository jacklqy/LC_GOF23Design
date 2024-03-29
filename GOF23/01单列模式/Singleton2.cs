﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._01单列模式
{
    /// <summary>
    /// 饿汉式
    /// </summary>
    public sealed class Singleton2
    {
        private static Singleton2 _Singleton2 = null;
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private Singleton2()
        {
            Console.WriteLine("Singleton2被实例化啦...");
        }
        /// <summary>
        /// 静态构造函数：由CLR保证，在第一次使用这个类之前，自动被调用且只调用一次.
        /// 很多初始化都可以写在这里
        /// </summary>
        static Singleton2()
        {
            _Singleton2 = new Singleton2();
        }
        /// <summary>
        /// 对外提供获取实例的统一入口
        /// </summary>
        /// <returns></returns>
        public static Singleton2 GetSingleton()
        {
            return _Singleton2;
        }

        public void Show()
        {
            Console.WriteLine("Singleton2.Show被调用啦...");
        }
    }
}

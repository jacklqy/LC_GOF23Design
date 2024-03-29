﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._01单列模式
{
    /// <summary>
    /// 饿汉式
    /// </summary>
    public sealed class Singleton3
    {
        /// <summary>
        /// 静态字段：由CLR保证，在第一次使用这个类之前，自动被初始化且只初始化一次.
        /// </summary>
        private static Singleton3 _Singleton3 = new Singleton3();
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private Singleton3()
        {
            Console.WriteLine("Singleton3被实例化啦...");
        }

        /// <summary>
        /// 对外提供获取实例的统一入口
        /// </summary>
        /// <returns></returns>
        public static Singleton3 GetSingleton()
        {
            return _Singleton3;
        }

        public void Show()
        {
            Console.WriteLine("Singleton3.Show被调用啦...");
        }
    }
}

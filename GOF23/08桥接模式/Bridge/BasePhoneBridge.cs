using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class BasePhoneBridge
    {
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// 变化封装：将System和Version封装，由上端指定。
        /// 属性注入 (方法注入、构造函数注入、成员变量注入)
        /// </summary>
        public ISystem SystemVersion { get; set; }

        ///// <summary>
        ///// 操作系统
        ///// </summary>
        ///// <returns></returns>
        //public abstract string System();
        ///// <summary>
        ///// 系统版本
        ///// </summary>
        ///// <returns></returns>
        //public abstract string Version();

        /// <summary>
        /// 打电话
        /// </summary>
        public abstract void Call();
        /// <summary>
        /// 发短信
        /// </summary>
        public abstract void Text();
    }
}

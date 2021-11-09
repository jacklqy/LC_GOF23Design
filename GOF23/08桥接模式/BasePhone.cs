using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._08桥接模式
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class BasePhone
    {
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price { get; set; }

        #region 封装变化-》通过抽象方式注入
        /// <summary>
        /// 操作系统
        /// </summary>
        /// <returns></returns>
        public abstract string System();
        /// <summary>
        /// 系统版本
        /// </summary>
        /// <returns></returns>
        public abstract string Version(); 
        #endregion

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

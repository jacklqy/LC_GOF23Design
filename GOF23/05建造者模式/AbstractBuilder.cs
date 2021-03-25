using GOF23._05建造者模式.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式
{
    /// <summary>
    /// 抽象工人
    /// </summary>
    public abstract class AbstractBuilder
    {
        /// <summary>
        /// 引擎
        /// </summary>
        public abstract void Engine();
        /// <summary>
        /// 轮子
        /// </summary>
        public abstract void Wheels();
        /// <summary>
        /// 灯
        /// </summary>
        public abstract void Light();


        /// <summary>
        /// 造车
        /// </summary>
        public abstract Car Car();
    }
}

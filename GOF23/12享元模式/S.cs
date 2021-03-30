using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._12享元模式
{
    /// <summary>
    /// 这个就是单列
    /// </summary>
    public class S : BaseWord
    {
        private static S _S = null;
        /// <summary>
        /// 1、私有化构造函数
        /// 一个耗时耗资源的构造函数
        /// 表明构造对象比较消耗资源
        /// </summary>
        private S()
        {
            //模拟消耗CPU资源
            long iResult = 0;
            for (int i = 0; i < 1000000; i++)
            {
                iResult += i;
            }
            //模拟耗时
            Thread.Sleep(1500);
            Console.WriteLine("{0}被构造...", this.GetType().Name);
        }
        /// <summary>
        /// 2、静态构造函数
        /// </summary>
        static S()
        {
            _S = new S();
        }
        /// <summary>
        /// 3、提供对外获取实例方法
        /// </summary>
        /// <returns></returns>
        public static S CreateInstance()
        {
            return _S;
        }
        public override string Get()
        {
            return this.GetType().Name;
        }
    }
}

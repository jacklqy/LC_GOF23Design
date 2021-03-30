using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._12享元模式
{
    public class L : BaseWord
    {
        /// <summary>
        /// 一个耗时耗资源的构造函数
        /// 表明构造对象比较消耗资源
        /// </summary>
        public L()
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
        public override string Get()
        {
            return this.GetType().Name;
        }
    }
}

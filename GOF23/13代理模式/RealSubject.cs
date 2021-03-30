using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._13代理模式
{
    public class RealSubject : ISubject
    {
        /// <summary>
        /// 耗时的初始化
        /// </summary>
        public RealSubject()
        {
            Thread.Sleep(2000);
            long iResult = 0;
            for (int i = 0; i < 10000000; i++)
            {
                iResult += i;
            }
            Console.WriteLine("RealSubject被构造...");
        }
        /// <summary>
        /// 一个耗时的复杂查询
        /// </summary>
        /// <returns></returns>
        public List<string> GetSomethingLong()
        {
            //日志代理
            //Console.WriteLine("prepare GetSomethingLong write log...");
            //异常代理
            //try
            //{
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            Console.WriteLine("读取大文件信息...");
            Thread.Sleep(1000);
            Console.WriteLine("数据库大数据查询...");
            Thread.Sleep(1000);
            Console.WriteLine("调用远程接口...");
            Thread.Sleep(1000);

            Console.WriteLine("最终合成得到结果。。。一堆的商品列表");
            return new List<string>() { "123", "456", "789" };
        }
        /// <summary>
        /// 一个耗时的复杂操作
        /// </summary>
        public void DoSomethingLong()
        {
            //Console.WriteLine("prepare DoSomethingLong write log...");

            Console.WriteLine("下订单...");
            Thread.Sleep(1000);
            Console.WriteLine("短信通知...");
            Thread.Sleep(1000);
        }
    }
}

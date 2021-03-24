using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GOF23.单列模式
{
    public class Program : OpentDesign
    {
        /// <summary>
        /// 单列有什么用，为什么要用单列，什么时候用单列
        /// 节省资源？    对象常驻内存，重用对象
        ///               及时申请--使用--释放
        /// 同一个实例，不能解决多线程并发问题。
        /// 
        /// 
        /// 什么时候用单列？
        /// 数据库连接池：数据库连接/IO操作--非托管资源--申请/释放消耗性能
        ///               池化资源--内置10个连接--使用来拿，用完放回--避免重复申请和销毁--控制连接数量。
        /// 线程池、流水号生成器、配置文件读取、IOC容器实例
        /// </summary>
        public override void Open()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Singleton singleton = Singleton.GetSingleton();
            //        singleton.Show();
            //    });
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Singleton2 singleton2 = Singleton2.GetSingleton();
            //        singleton2.Show();
            //    });
            //}

            for (int i = 0; i < 5; i++)
            {
                Task.Run(() =>
                {
                    Singleton3 singleton3 = Singleton3.GetSingleton();
                    singleton3.Show();
                });
            }
        }
    }
}

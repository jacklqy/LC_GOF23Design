﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
/// 主要解决：一个全局使用的类频繁地创建与销毁。
/// 何时使用：当您想控制实例数目，节省系统资源的时候。
/// 如何解决：判断系统是否已经有这个单例，如果有则返回，如果没有则创建。
/// 关键代码：构造函数是私有的。
/// 使用场景：
///     1、要求生产唯一序列号。
///     2、WEB 中的计数器，不用每次刷新都在数据库里加一次，用单例先缓存起来。
///     3、创建的一个对象需要消耗的资源过多，比如 I/O 与数据库的连接等。
/// 优点：
///     1、在内存里只有一个实例，减少了内存的开销，尤其是频繁的创建和销毁实例（比如管理学院首页页面缓存）。
///     2、避免对资源的多重占用（比如写文件操作）。
/// 缺点：没有接口，不能继承，与单一职责原则冲突，一个类应该只关心内部逻辑，而不关心外面怎么样来实例化。
/// </summary>
namespace GOF23._01单列模式
{
    public class Program : OpentDesign
    {
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

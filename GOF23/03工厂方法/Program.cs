using GOF23._03工厂方法.Interface;
using GOF23.FactoryMethod._03工厂方法;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 侧重点：工厂方法(单产品)/抽象工厂(产品族)
/// 意图：定义一个创建对象的接口，让其子类自己决定实例化哪一个工厂类，工厂模式使其创建过程延迟到子类进行。
/// 主要解决：主要解决接口选择的问题。
/// 何时使用：我们明确地计划不同条件下创建不同实例时。
/// 如何解决：让其子类实现工厂接口，返回的也是一个抽象的产品。
/// 关键代码：创建过程在其子类执行。
/// 使用场景： 
///     1、日志记录器：记录可能记录到本地硬盘、系统事件、远程服务器等，用户可以选择记录日志到什么地方。 
///     2、数据库访问，当用户不知道最后系统采用哪一类数据库，以及数据库可能有变化时。 
///     3、设计一个连接服务器的框架，需要三个协议，"POP3"、"IMAP"、"HTTP"，可以把这三个作为产品类，共同实现一个接口。
/// 优点： 
///     1、一个调用者想创建一个对象，只要知道其名称就可以了。 
///     2、扩展性高，如果想增加一个产品，只要扩展一个工厂类就可以。 
///     3、屏蔽产品的具体实现，调用者只关心产品的接口。
/// 缺点：每次增加一个产品时，都需要增加一个具体类和对象实现工厂，使得系统中类的个数成倍增加，在一定程度上增加了系统的复杂度，同时也增加了系统具体类的依赖。这并不是什么好事。
/// </summary>
namespace GOF23._03工厂方法
{
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("****************工厂方法******************");

            {
                IFactory humanFactory = new HumanFactory();
                IRace iRaceHuman = humanFactory.CreateInstance();
                iRaceHuman.ShowKing();

                //使用原始的工厂
                IFactory fiveFactory = new FiveFactory();
                IRace iRaceFive = fiveFactory.CreateInstance();
                iRaceFive.ShowKing();

                //使用扩展的工厂(在原始工厂基础上包了一层)
                IFactory fiveFactoryExtend = new FiveFactoryExtend();
                IRace iRaceFiveExtend = fiveFactoryExtend.CreateInstance();
                iRaceFiveExtend.ShowKing();
            }
        }
    }
}

using GOF23._03工厂方法.Interface;
using GOF23.FactoryMethod._03工厂方法;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Factory Method，定义一个用于创建对象的接口，让子类决定实例化哪一个类，工厂方法使一个类的实例化延迟到其子类。
/// 为了遵循扩展开放，修改关闭原则，将简单工厂类转换为工厂方法接口，将其Switch分支分离成子类去继承工厂方法接口类，顺利的将创建对象的过程延迟到子类。
/// </summary>
namespace GOF23._03工厂方法
{
    /// <summary>
    /// 工厂方法：如果需要新增一个类，直接在增加一个工厂类，对具体的依赖，转移到工厂（对扩展开发，对修改封闭）
    /// 屏蔽高层对细节的依赖，将依赖转移到工厂，由工厂统一创建对象，对象实例化的所有细节都在工厂内实现。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            {
                IFactory humanFactory = new HumanFactory();
                IRace iRaceHuman = humanFactory.CreateInstance();
                iRaceHuman.ShowKing();

                //使用原始的工厂
                IFactory fiveFactory = new FiveFactory();
                IRace iRaceFive = fiveFactory.CreateInstance();
                iRaceFive.ShowKing();

                //使用扩展的工厂
                IFactory fiveFactoryExtend = new FiveFactoryExtend();
                IRace iRaceFiveExtend = fiveFactoryExtend.CreateInstance();
                iRaceFiveExtend.ShowKing();
            }
        }
    }
}

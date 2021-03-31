using GOF23._04抽象工厂.Factory;
using GOF23._04抽象工厂.Interface;
using GOF23._04抽象工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 侧重点：工厂方法(单产品)/抽象工厂(产品族)
/// 意图：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
/// 主要解决：主要解决接口选择的问题。
/// 何时使用：系统的产品有多于一个的产品族，而系统只消费其中某一族的产品。
/// 如何解决：在一个产品族里面，定义多个产品。
/// 关键代码：在一个工厂里聚合多个同类产品。
/// 使用场景： 
///     1、QQ 换皮肤，一整套一起换。 
///     2、生成不同操作系统的程序。
/// 优点：当一个产品族中的多个对象被设计成一起工作时，它能保证客户端始终只使用同一个产品族中的对象。
/// 缺点：产品族扩展非常困难，要增加一个系列的某一产品，既要在抽象的 Creator 里加代码，又要在具体的里面加代码。
/// </summary>
namespace GOF23._04抽象工厂
{
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("****************抽象工厂******************");

            {
                AbstractFactory factoryShu = new FactoryShu();
                IGroup group = factoryShu.CreateGroup();
                IGenerals generals = factoryShu.CreateGenerals();
                //IAdviser adviser = factoryShu.CreateAdviser();
                group.ShowGroup();
                generals.ShowGenerals();
                //adviser.ShowAdviser();
            }
            Console.WriteLine("****************************************");
            {
                AbstractFactory factoryWei = new FactoryWei();
                IGroup group = factoryWei.CreateGroup();
                IGenerals generals = factoryWei.CreateGenerals();
                group.ShowGroup();
                generals.ShowGenerals();
            }
            Console.WriteLine("****************************************");
            {
                AbstractFactory factoryWu = new FactoryWu();
                IGroup group = factoryWu.CreateGroup();
                IGenerals generals = factoryWu.CreateGenerals();
                group.ShowGroup();
                generals.ShowGenerals();
            }
        }
    }
}

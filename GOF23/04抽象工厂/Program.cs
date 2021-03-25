using GOF23._04抽象工厂.Factory;
using GOF23._04抽象工厂.Interface;
using GOF23._04抽象工厂.Service;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Abstract Factory，提供一个创建一系列相关或相互依赖对象的接口，而无需指定他们具体的类。
/// </summary>
namespace GOF23._04抽象工厂
{
    /// <summary>
    /// 抽象工厂的限制和应用场景
    /// 倾斜的可扩展设计
    /// 应用场景：如果我们需要创建一组对象，而且这一组对象包含不同的版本，后期可以随意扩展产品族
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("抽象工厂");
            Console.WriteLine("****************************************");
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

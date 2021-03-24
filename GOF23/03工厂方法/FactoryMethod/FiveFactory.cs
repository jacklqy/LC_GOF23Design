using GOF23._03工厂方法.Interface;
using GOF23._03工厂方法.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace GOF23.FactoryMethod._03工厂方法
{
    /// <summary>
    /// 工厂类  .net框架原始工厂
    /// </summary>
    public class FiveFactory : IFactory
    {
        public virtual IRace CreateInstance()
        {
            //在此去获取需要构造的信息参数
            IRace iRace = new Five("jack", 123, new object());//还有些具体业务
            return iRace;
        }

    }

    /// <summary>
    /// 我们扩展的工厂类
    /// </summary>
    public class FiveFactoryExtend : FiveFactory
    {
        public override IRace CreateInstance()
        {
            Console.WriteLine("这里是我们扩展的工厂");
            //也可以自己去实例化对象
            return base.CreateInstance();
        }

    }
}

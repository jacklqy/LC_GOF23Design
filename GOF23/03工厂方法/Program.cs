using GOF23._03工厂方法.Interface;
using GOF23.FactoryMethod._03工厂方法;
using System;
using System.Collections.Generic;
using System.Text;

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

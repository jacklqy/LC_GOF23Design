using GOF23._05建造者模式.Model;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
/// </summary>
namespace GOF23._05建造者模式
{
    /// <summary>
    /// 建造者模式主要是关注一个复杂对象的创建，包含了多个步骤(及包含多个对象合成)才能创建好。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            //{
            //    //福特汽车建造
            //    AbstractBuilder builderFord = new BuilderFord();
            //    builderFord.Engine();
            //    builderFord.Wheels();
            //    builderFord.Light();
            //    builderFord.Car();
            //}
            //Console.WriteLine("**********************************");
            //{
            //    //比亚迪汽车建造
            //    AbstractBuilder builderBYD = new BuilderBYD();
            //    builderBYD.Engine();
            //    builderBYD.Wheels();
            //    builderBYD.Light();
            //    builderBYD.Car();
            //}

            {
                //福特汽车建造
                AbstractBuilder builderFord = new BuilderFord();
                Director director = new Director(builderFord);
                Car car = director.GetCar();
            }
            Console.WriteLine("**********************************");
            {
                //比亚迪汽车建造
                AbstractBuilder builderBYD = new BuilderBYD();
                Director director = new Director(builderBYD);
                Car car = director.GetCar();
            }
        }
    }
}

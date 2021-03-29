using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23
{
    public class StartDesign
    {
        public void Go()
        {

            #region 创建型设计模式(关注对象的创建 6个)

            #region 单列模式
            //OpentDesign design = new GOF23._01单列模式.Program();
            //design.Open();
            #endregion

            #region 简单工厂
            //OpentDesign design = new GOF23._02简单工厂.Program();
            //design.Open();
            #endregion

            #region 工厂方法
            //OpentDesign design = new GOF23._03工厂方法.Program();
            //design.Open();
            #endregion

            #region 抽象工厂
            //OpentDesign design = new GOF23._04抽象工厂.Program();
            //design.Open();
            #endregion

            #region 建造者模式
            //OpentDesign design = new GOF23._05建造者模式.Program();
            //design.Open();
            #endregion

            #region 建造者模式
            //OpentDesign design = new GOF23._06原型模式.Program();
            //design.Open();
            #endregion

            #endregion

            #region 结构型设计模式(关注类与类之间的关系---继承/组合/聚合/依赖)
            ///继承：继承是强耦合关系，父类拥有的东西，子类都会拥有，而且父类不能换
            ///组合：组合的类的行为是由自身控制的，上端可传入不同的类来实现不同的行为。
            ///组合优于继承

            #region 建造者模式
            //OpentDesign design = new GOF23._07适配器模式.Program();
            //design.Open();
            #endregion

            #region 桥接模式
            //OpentDesign design = new GOF23._08桥接模式.Program();
            //design.Open();
            #endregion

            #region 组合模式
            //OpentDesign design = new GOF23._09组合模式.Program();
            //design.Open();
            #endregion

            #region 装饰器模式
            //OpentDesign design = new GOF23._10装饰器模式.Program();
            //design.Open();
            #endregion

            #region 外观模式
            OpentDesign design = new GOF23._11外观模式.Program();
            design.Open();
            #endregion

            #endregion

            #region 行为型设计模式(关注对象与行为的分离)

            #endregion

        }

    }
}

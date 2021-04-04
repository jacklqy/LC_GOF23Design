using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23
{
    /// <summary>
    /// 什么是设计模式？
    /// 设计模式：面向对象语言开发过程中，遇到的种种场景和问题，提出的解决问题的方案和思路，最终沉淀下来的解决问题的方法。
    ///           不会过时，即使是新的跨平台框架里面，思想是不变的
    /// </summary>
    public class StartDesign
    {
        public void Go()
        {

            #region 创建型设计模式(关注对象的创建 6个)

            #region 单列模式
            ////控制整个进程中只创建一个对象
            //OpentDesign design = new GOF23._01单列模式.Program();
            //design.Open();
            #endregion

            #region 简单工厂(没有被纳入23种设计模式)
            ////把对象的创建转移到工厂
            //OpentDesign design = new GOF23._02简单工厂.Program();
            //design.Open();
            #endregion

            #region 工厂方法
            ////把对象的创建转移到工厂的同时，工厂是可以扩展的
            //OpentDesign design = new GOF23._03工厂方法.Program();
            //design.Open();
            #endregion

            #region 抽象工厂
            ////一个工厂有多个职责
            //OpentDesign design = new GOF23._04抽象工厂.Program();
            //design.Open();
            #endregion

            #region 建造者模式
            ////通过Builder创建一些复杂的对象
            //OpentDesign design = new GOF23._05建造者模式.Program();
            //design.Open();
            #endregion

            #region 原型模式
            ////通过clone方式创建对象
            //OpentDesign design = new GOF23._06原型模式.Program();
            //design.Open();
            #endregion

            #endregion

            #region 结构型设计模式(关注类与类之间的关系---继承/组合/ (聚合/依赖) 7个)
            ///继承：继承是强耦合关系，父类拥有的东西，子类都会拥有，而且父类不能换
            ///组合：组合的类的行为是由自身控制的，上端可传入不同的类来实现不同的行为。
            ///组合优于继承

            #region 适配器模式
            ////是为了把某些类适配起来，不能用的类，通过适配器转换让其可以用起来
            //OpentDesign design = new GOF23._07适配器模式.Program();
            //design.Open();
            #endregion

            #region 桥接模式
            ////把变化的元素封装起来，然后通过桥的方式去访问
            //OpentDesign design = new GOF23._08桥接模式.Program();
            //design.Open();
            #endregion

            #region 组合模式
            ////把一对多转换成一对一
            //OpentDesign design = new GOF23._09组合模式.Program();
            //design.Open();
            #endregion

            #region 装饰器模式
            ////在运行的过程中不断的去增加功能
            //OpentDesign design = new GOF23._10装饰器模式.Program();
            //design.Open();
            #endregion

            #region 外观模式(门面模式)
            ////为子系统中的一组接口提供一个一致的界面
            //OpentDesign design = new GOF23._11外观模式.Program();
            //design.Open();
            #endregion

            #region 享元模式
            ////对象的复用，池化管理
            //OpentDesign design = new GOF23._12享元模式.Program();
            //design.Open();
            #endregion

            #region 代理模式
            ////统一入口
            //OpentDesign design = new GOF23._13代理模式.Program();
            //design.Open();
            #endregion

            #endregion

            #region 行为型设计模式(关注对象与行为的分离 11个)

            #region 解释器模式
            ////可以将一个需要解释执行的语言中的句子表示为一个抽象语法树
            //OpentDesign design = new GOF23._14解释器模式.Program();
            //design.Open();
            #endregion

            #region 模板模式
            ////定义业务处理流程，实现了通用部分，把可变部分留作扩展点。
            //OpentDesign design = new GOF23._15模板模式.Program();
            //design.Open();
            #endregion

            #region 责任链模式
            ////有多个对象可以处理同一个请求，具体哪个对象处理该请求由运行时刻自动确定。比如请假审批流程、工作流
            //OpentDesign design = new GOF23._16责任链模式.Program();
            //design.Open();
            #endregion

            #region 命令模式
            ////将一个请求封装成一个对象，从而使您可以用不同的请求对客户进行参数化
            //OpentDesign design = new GOF23._17命令模式.Program();
            //design.Open();
            #endregion

            #region 迭代器模式
            ////提供一个通用的方式去访问不同的集合
            //OpentDesign design = new GOF23._18迭代器模式.Program();
            //design.Open();
            #endregion

            #region 中介者模式
            ////用一个中介对象来封装一系列的对象交互，中介者使各对象不需要显式地相互引用
            //OpentDesign design = new GOF23._19中介者模式.Program();
            //design.Open();
            #endregion

            #region 备忘录模式
            ////在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态
            //OpentDesign design = new GOF23._20备忘录模式.Program();
            //design.Open();
            #endregion

            #region 观察者模式
            ////定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新
            //OpentDesign design = new GOF23._21观察者模式.Program();
            //design.Open();
            #endregion

            #region 状态模式
            //允许对象在内部状态发生改变时改变它的行为，对象看起来好像修改了它的类
            OpentDesign design = new GOF23._22状态模式.Program();
            design.Open();
            #endregion

            #endregion

        }

    }
}

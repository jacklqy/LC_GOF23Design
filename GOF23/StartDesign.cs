using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23
{
    /// <summary>
    /// 什么是设计模式？
    /// 设计模式：面向对象语言开发过程中，遇到的种种场景和问题，提出的解决问题的方案和思路，最终沉淀下来的解决问题的方法。
    ///           不会过时，即使是新的跨平台框架里面，思想是不变的
    ///           共同的部分抽象出来,封装变化,由上端传递
    /// 值类型： 所有的值类型都集成自 System.ValueType 上，除非加声明?否则不可为null，保存在 堆栈（Stack，先进后出）上，常见的值类型有：整形、浮点型、bool、枚举等。
    /// 引用类型：所有的引用类型都继承自System.Object 上，引用类型保存在 托管堆（Head，先进先出）上，常见的类型有：数组、字符串、接口、委托、object等。
    /// 每一个对象，当被创建的一刻开始，就有被销毁的时候(GC),可能是{}块执行完后，可能是static静态的需应用程序关闭后才会释放。GC是通过判断对象及其子对象有没有指向有效的引用。循环引用，网状结构等的实现会变得简单。GC的标志也压缩算法能有效的检测这些关系，并将不再被引用的网状结构整体删除。
    /// 正确理解对象的堆栈存储方式和生命周期；夸线程共享数据安全：AsyncLocal
    /// 
    /// 巧妙的允许访问修饰符：public、private、protected、internal
    /// 巧妙的运用方法修饰符(多态)：abstract、virtual 和 overred、new
    /// 理解编译时确定和运行时确定：编译时决定：const；运行时确定：普通方法子类复写、new父类方法、readonly、static
    /// 正确运用和理解this/base，以及通过this/base进行相应的传值和对象调用
    /// 创建型：对象的创建
    /// 结构型：类之间的关系，继承、组合-》组合优于继承。接口或抽象常见注入方式：属性注入、构造函数注入、方法注入。
    /// 行为型：甩锅大法(行为转移、封装变化，由上端传递-》本质就是：接口或抽象常见注入方式：属性注入、构造函数注入、方法注入。)、content上下文、继承、组合、类型嵌套、类型嵌套递归
    /// 对象、对象嵌套、包一层
    /// 类的层次结构理清了，那就能够理解对应的设计模式--》你(具体)中有我(抽象)/我(具体)中有你(抽象)
    /// </summary>
    public class StartDesign
    {
        /// <summary>
        /// 入口
        /// </summary>
        public void Go()
        {
            //本质：对象引用、对象嵌套引用、对象组合方式、对象创建方式---》》》面向对象思维
            //this、base的正确使用

            #region 创建型设计模式(关注对象的创建 6个)

            #region 1、单列模式
            ////控制整个进程中只创建一个对象
            //OpentDesign design = new GOF23._01单列模式.Program();
            //design.Open();
            #endregion

            #region 2、简单工厂(没有被纳入23种设计模式)
            ////把对象的创建转移到工厂
            //OpentDesign design = new GOF23._02简单工厂.Program();
            //design.Open();
            #endregion

            #region 3、工厂方法
            ////把对象的创建转移到工厂的同时，工厂是可以扩展的
            //OpentDesign design = new GOF23._03工厂方法.Program();
            //design.Open();
            #endregion

            #region 4、抽象工厂
            ////一个工厂有多个职责
            //OpentDesign design = new GOF23._04抽象工厂.Program();
            //design.Open();
            #endregion

            #region 5、建造者模式
            ////通过Builder创建一些复杂的对象
            //OpentDesign design = new GOF23._05建造者模式.Program();
            //design.Open();
            #endregion

            #region 6、原型模式
            ////通过clone方式创建对象
            OpentDesign design = new GOF23._06原型模式.Program();
            design.Open();
            #endregion

            #endregion

            #region 结构型设计模式(关注类与类(对象与对象)之间的关系---继承/组合/ (聚合/依赖) 7个)
            ///继承：继承是强耦合关系，父类拥有的东西，子类都会拥有，而且父类不能换
            ///组合：组合的类的行为是由自身控制的，上端可传入不同的类来实现不同的行为。
            ///组合优于继承

            #region 7、适配器模式
            ////是为了把某些类适配起来，不能用的类，通过适配器转换让其可以用起来
            //OpentDesign design = new GOF23._07适配器模式.Program();
            //design.Open();
            #endregion

            #region 8、桥接模式
            ////把变化的元素封装起来，然后通过桥的方式去访问
            //OpentDesign design = new GOF23._08桥接模式.Program();
            //design.Open();
            #endregion

            #region 9、组合模式
            ////把一对多转换成一对一
            //OpentDesign design = new GOF23._09组合模式.Program();
            //design.Open();
            #endregion

            #region 10、装饰器模式
            ////在运行的过程中不断的去增加功能
            //OpentDesign design = new GOF23._10装饰器模式.Program();
            //design.Open();
            #endregion

            #region 11、外观模式(门面模式)
            ////为子系统中的一组接口提供一个一致的界面
            //OpentDesign design = new GOF23._11外观模式.Program();
            //design.Open();
            #endregion

            #region 12、享元模式
            ////对象的复用，池化管理
            //OpentDesign design = new GOF23._12享元模式.Program();
            //design.Open();
            #endregion

            #region 13、代理模式
            ////统一入口
            //OpentDesign design = new GOF23._13代理模式.Program();
            //design.Open();
            #endregion

            #endregion

            #region 行为型设计模式(关注对象与行为的分离 11个)
            //Context是行为型设计模式的标配，行为会无止境的到处转移。方法需要参数，执行结果...

            #region 14、解释器模式
            ////可以将一个需要解释执行的语言中的句子表示为一个抽象语法树
            //OpentDesign design = new GOF23._14解释器模式.Program();
            //design.Open();
            #endregion

            #region 15、模板模式
            ////定义业务处理流程，实现了通用部分，把可变部分留作扩展点。
            //OpentDesign design = new GOF23._15模板模式.Program();
            //design.Open();
            #endregion

            #region 16、责任链模式
            ////有多个对象可以处理同一个请求，具体哪个对象处理该请求由运行时刻自动确定。比如请假审批流程、工作流
            //OpentDesign design = new GOF23._16责任链模式.Program();
            //design.Open();
            #endregion

            #region 17、命令模式
            ////将一个请求封装成一个对象，从而使您可以用不同的请求对客户进行参数化
            //OpentDesign design = new GOF23._17命令模式.Program();
            //design.Open();
            #endregion

            #region 18、迭代器模式
            ////提供一个通用的方式去访问不同的集合
            //OpentDesign design = new GOF23._18迭代器模式.Program();
            //design.Open();
            #endregion

            #region 19、中介者模式
            //用一个中介对象来封装一系列的对象交互，中介者使各对象不需要显式地相互引用
            //OpentDesign design = new GOF23._19中介者模式.Program();
            //design.Open();
            #endregion

            #region 20、备忘录模式
            ////在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态
            //OpentDesign design = new GOF23._20备忘录模式.Program();
            //design.Open();
            #endregion

            #region 21、观察者模式
            ////定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新
            //OpentDesign design = new GOF23._21观察者模式.Program();
            //design.Open();
            #endregion

            #region 22、状态模式
            //允许对象在内部状态发生改变时改变它的行为，对象看起来好像修改了它的类
            //OpentDesign design = new GOF23._22状态模式.Program();
            //design.Open();
            #endregion

            #region 23、策略模式
            ////定义一系列的算法,把它们一个个封装起来, 并且使它们可相互替换
            //OpentDesign design = new GOF23._23策略模式.Program();
            //design.Open();
            #endregion

            #region 24、访问者模式
            ////
            //OpentDesign design = new GOF23._24访问者模式.Program();
            //design.Open();
            #endregion

            #endregion

        }

    }
}

using GOF23._10装饰器模式.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式
{
    /// <summary>
    /// 意图：动态地给一个对象添加一些额外的职责。就增加功能来说，装饰器模式相比生成子类更为灵活。
    /// 主要解决：一般的，我们为了扩展一个类经常使用继承方式实现，由于继承为类引入静态特征，并且随着扩展功能的增多，子类会很膨胀。
    /// 何时使用：在不想增加很多子类的情况下扩展类。
    /// 如何解决：将具体功能职责划分，同时继承装饰者模式。
    /// 关键代码： 
    ///     1、Component 类充当抽象角色，不应该具体实现。 
    ///     2、修饰类引用和继承 Component 类，具体扩展类重写父类方法。
    /// 应用实例： 
    ///     1、孙悟空有 72 变，当他变成"庙宇"后，他的根本还是一只猴子，但是他又有了庙宇的功能。 
    ///     2、不论一幅画有没有画框都可以挂在墙上，但是通常都是有画框的，并且实际上是画框被挂在墙上。在挂在墙上之前，画可以被蒙上玻璃，装到框子里；这时画、玻璃和画框形成了一个物体。
    /// 使用场景： 
    ///     1、扩展一个类的功能。 
    ///     2、动态增加功能，动态撤销。
    /// 优点：装饰类和被装饰类可以独立发展，不会相互耦合，装饰模式是继承的一个替代模式，装饰模式可以动态扩展一个实现类的功能。
    /// 缺点：多层装饰比较复杂。
    /// 
    /// 《AOP面向切面编程》
    /// OOP->AOP
    /// OOP：面向对象编程---继承 封装 多态
    /// 
    /// 继承和组合 完成功能了扩展，且没有修改原有代码，没有破坏原有封装。
    /// </summary>
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("********************装饰器模式**************");

            {
                ////
                //AbstractStudent studentFree = new StudentFree()
                //{
                //    Id = 111,
                //    Name = "jack111"
                //};
                //studentFree.Study();

                ////集成方式实现扩展
                //AbstractStudent studentVideo = new StudentFreeVideo()
                //{
                //    Id = 222,
                //    Name = "jack222"
                //};
                //studentVideo.Study();

                ////组合方式实现扩展
                //StudentCombination studentCombination = new StudentCombination(studentVideo);
                //studentCombination.Study();
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&苦难是一种财务，它打不垮你就会让你更强大&&&&&&&&&&&&&&&&&");

            {
                AbstractStudent student = new StudentFree() //这里是由运行时决定的，不是由编译时决定的。
                {
                    Id = 111,
                    Name = "jack111"
                };

                //BaseDecorator decorator = new BaseDecorator(student);
                //decorator.Study();

                //AbstractStudent decorator = new BaseDecorator(student);//里氏替换原则
                //decorator.Study();

                //需求场景：
                //能不能不修改原有代码，也能扩展功能。---开闭原则，对扩展开放，对修改关闭。
                //又来新需求啦：课前预习+作业巩固练习+老师课后答疑 ，需求很多，而且还要灵活定制
                //一个业务功能在完成后，希望能够任意的扩展功能，订制顺序，而且不破坏封装。

                //俄罗斯套娃,C#内存分配机制,把引用类型变量的引用换个地址  --》和递归调用和相似-》类型嵌套

                //要结合递归思想和引用类型地址的指向去理解
                student = new BaseDecorator(student);//这里可以注释掉 --》组合模式、装饰器模式、责任链模式、中介者模式-》很相似

                student = new StudentDecoratorAnswer(student);//课后，和放置顺序有关
                student = new StudentDecoratorHomeWork(student);//课后，和放置顺序有关
                student = new StudentDecoratorVideo(student);//课后，和放置顺序有关
                student = new StudentDecoratorPreview(student);//课前，和放置顺序无关

                student.Study();

                //笔试题：2个变量，在不声明第三个变量的基础上，交换值。
                int i = 3;
                int k = 4;
                int m = i + k;//7
                i = m - i;//4
                k = m - i;//3

                i = i + k;//7
                k = i - k;//3
                i = i - k;//4
            }
        }
    }
}

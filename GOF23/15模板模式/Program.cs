﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
    /// <summary>
    /// 意图：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
    /// 主要解决：一些方法通用，却在每一个子类都重新写了这一方法。
    /// 何时使用：有一些通用的方法。
    /// 如何解决：将这些通用算法抽象出来。
    /// 关键代码：在抽象类实现，其他步骤在子类实现。
    /// 应用实例： 
    ///     1、在造房子的时候，地基、走线、水管都一样，只有在建筑的后期才有加壁橱加栅栏等差异。 
    ///     2、西游记里面菩萨定好的 81 难，这就是一个顶层的逻辑骨架。 
    ///     3、spring 中对 Hibernate 的支持，将一些已经定好的方法封装起来，比如开启事务、获取 Session、关闭 Session 等，程序员不重复写那些已经规范好的代码，直接丢一个实体就可以保存。
    /// 优点： 
    ///     1、封装不变部分，扩展可变部分。 
    ///     2、提取公共代码，便于维护。 
    ///     3、行为由父类控制，子类实现。
    /// 缺点：每一个不同的实现都需要一个子类来实现，导致类的个数增加，使得系统更加庞大。
    /// 使用场景： 
    ///     1、有多个子类共有的方法，且逻辑相同。 
    ///     2、重要的、复杂的方法，可以考虑作为模板方法。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 抽象方法/虚方法/普通方法
        /// 2 模板方法设计模式，钩子方法(其实指的就是virtual虚方法)
        /// 3 模板方法在框架中的应用
        /// 设计模式：面向对象开发过程中，会遇到各种场景和问题，解决方案和思路沉淀下来，就是设计模式。解决问题的套路。
        /// 
        /// 简单、强大、无所不在、框架搭建必备
        /// 模板方法：帮我们定义了通用的业务执行流程或处理流程，实现了通用部分，可变部分留作扩展点，把可变的(定义为抽象方法)和部分可变(定义为虚方法)的交由子类实现
        /// 框架搭建：定义业务处理流程，实现了通用部分，把可变部分留作扩展点。
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("************模板模式***********");

            {
                Console.WriteLine("**************知识点同步*************");
                MethodTest.Show();
            }
            {
                Console.WriteLine("**************TemplateMethod*************");
                Client client = new Client();
                client.Query(1, "jack9527", "000000");
            }
            {
                Console.WriteLine("**************定期客户ClientRegular*************");
                //抽象/虚 方法的调用，是运行时决定的，也就是右边决定的
                ClientTemplate regular = new ClientRegular();
                regular.Query(1, "小明", "000000");

                Console.WriteLine("**************活期客户ClientCurrent*************");
                //抽象/虚 方法的调用，是运行时决定的，也就是右边决定的
                ClientTemplate current = new ClientCurrent();
                current.Query(1, "小张", "000000");

                Console.WriteLine("**************VIP客户ClientCurrent*************");
                //抽象/虚 方法的调用，是运行时决定的，也就是右边决定的
                ClientTemplate vip = new ClientVip();
                vip.Query(1, "小卢", "000000");
            }
        }
    }
}

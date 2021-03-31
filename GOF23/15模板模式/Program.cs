using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._15模板模式
{
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

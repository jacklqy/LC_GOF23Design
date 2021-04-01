using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._17命令模式
{
    /// <summary>
    /// 意图：将一个请求封装成一个对象，从而使您可以用不同的请求对客户进行参数化。
    /// 主要解决：在软件系统中，行为请求者与行为实现者通常是一种紧耦合的关系，但某些场合，比如需要对行为进行记录、撤销或重做、事务等处理时，这种无法抵御变化的紧耦合的设计就不太合适。
    /// 何时使用：在某些场合，比如要对行为进行"记录、撤销/重做、事务"等处理，这种无法抵御变化的紧耦合是不合适的。在这种情况下，如何将"行为请求者"与"行为实现者"解耦？将一组行为抽象为对象，可以实现二者之间的松耦合。
    /// 如何解决：通过调用者调用接受者执行命令，顺序：调用者→命令→接受者。
    /// 关键代码：定义三个角色：1、received 真正的命令执行对象 2、Command 3、invoker 使用命令对象的入口
    /// 应用实例：struts 1 中的 action 核心控制器 ActionServlet 只有一个，相当于 Invoker，而模型层的类会随着不同的应用有不同的模型类，相当于具体的 Command。
    /// 优点： 
    ///     1、降低了系统耦合度。 
    ///     2、新的命令可以很容易添加到系统中去。
    /// 缺点：使用命令模式可能会导致某些系统有过多的具体命令类。
    /// 使用场景：认为是命令的地方都可以使用命令模式，比如： 
    ///     1、GUI 中每一个按钮都是一条命令。 
    ///     2、模拟 CMD。
    ///     3、操作数据库时，每一次的核心业务操作，包装成命令，执行前写入日志或统一执行。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 命令模式介绍和列子
        /// 2 命令模式实现异步队列
        /// 3 数据恢复、命令撤销
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("***************命令模式************");

            {
                //Document document = new Document();

                //document.Read();
                //document.Write();

                //while (true)
                //{
                //    string input = Console.ReadLine();
                //    if (input.Equals("r"))
                //        document.Read();
                //    else if (input.Equals("w"))
                //        document.Write();
                //    else
                //        Console.WriteLine("请重新输入");
                //}

                //将Document对象的属性和行为拆分到多个命令中去

                ////业务场景需求：现在是输入r输出Read，输入w输出Write，现在用户需要自定义快捷键，怎么办呢？
                ////1、可以放xml文件或其它配置文件
                //var config = new ConfigurationBuilder().AddJsonFile("appsetting.json", optional: true, reloadOnChange: false).Build();
                //while (true)
                //{
                //    string input = Console.ReadLine();
                //    string action = config[input];
                //    if (!string.IsNullOrEmpty(action) && action.Equals("Read"))
                //        document.Read();
                //    else if (!string.IsNullOrEmpty(action) && action.Equals("Write"))
                //        document.Write();
                //    else
                //        Console.WriteLine("请重新输入");
                //}
            }

            {
                //命令模式三大角色：命令Command、执行者received、调用者invoker
                var config = new ConfigurationBuilder().AddJsonFile("appsetting.json", optional: true, reloadOnChange: false).Build();
                Document document = new Document();
                IReceiver receiver = new Receiver1();//也可以配置+反射
                while (true)
                {
                    string input = Console.ReadLine();
                    string action = config[input];
                    BaseCommand command = (BaseCommand)Activator.CreateInstance(action.Split(',')[1], action.Split(',')[0]).Unwrap();
                    command.Set(document);
                    command.SetReceiver(receiver);
                    //command.Excute();
                    Invoker invoker = new Invoker(command);
                    invoker.Excute();
                    //总共包了三层
                }
            }
        }
    }
}

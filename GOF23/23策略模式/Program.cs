using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOF23._23策略模式
{
    /// <summary>
    /// 意图：定义一系列的算法,把它们一个个封装起来, 并且使它们可相互替换。
    /// 主要解决：在有多种算法相似的情况下，使用 if...else 所带来的复杂和难以维护。
    /// 何时使用：一个系统有许多许多类，而区分它们的只是他们直接的行为。
    /// 如何解决：将这些算法封装成一个一个的类，任意地替换。
    /// 关键代码：实现同一个接口。
    /// 应用实例： 
    ///     1、诸葛亮的锦囊妙计，每一个锦囊就是一个策略。 
    ///     2、旅行的出游方式，选择骑自行车、坐汽车，每一种旅行方式都是一个策略。 
    ///     3、JAVA AWT 中的 LayoutManager。
    /// 优点： 
    ///     1、算法可以自由切换。 
    ///     2、避免使用多重条件判断。 
    ///     3、扩展性良好。
    /// 缺点： 
    ///     1、策略类会增多。 
    ///     2、所有策略类都需要对外暴露。
    /// 使用场景： 
    ///     1、如果在一个系统里面有许多类，它们之间的区别仅在于它们的行为，那么使用策略模式可以动态地让一个对象在许多行为中选择一种行为。 
    ///     2、一个系统需要动态地在几种算法中选择一种。 
    ///     3、如果一个对象有很多的行为，如果不用恰当的模式，这些行为就只好使用多重的条件选择语句来实现。
    /// 注意事项：如果一个系统的策略多于四个，就需要考虑使用混合模式，解决策略类膨胀的问题。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 策略模式(Strategy)
        /// 2 策略模式和简单工厂的结合
        /// 3 策略模式的应用：应对业务员处理中，会有多种相似的处理方式(算法)，然后封装成算法+抽象+Context，此外，调用环节也有扩展的要求。
        /// 好处：***算法封装，有抽象可以扩展；调用环节转移，可以扩展；***
        /// 缺陷：上端必须知道全部算法，而且知道映射关系。
        /// 
        /// 设计模式是为了解决一类问题二存在的，往往解决一类问题的同时会带来新的问题，会有对应的解决方案。设计模式不是万能的。
        /// 
        /// 程序设计：不关心功能性，关注的非功能性的要求，程序的扩展性--可读性--健壮性
        /// 
        /// 其实一样的功能，可以多样的实现，但是不同的实现，真的可以看出不同的水准，擅长什么，是很容易暴露的，看花容易绣花难。
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("*********************策略模式*****************");

            {
                //Console.WriteLine("下面是一个计算器展示demo");
                //while (true)
                //{
                //    #region UI前端逻辑 接受用户输入并验证
                //    int iInputLeft = 0;
                //    int iInputRight = 0;
                //    string operate = "";
                //    Console.WriteLine("输入第一个(整数)：");
                //    string sInputLeft = Console.ReadLine();
                //    if (!int.TryParse(sInputLeft, out iInputLeft))
                //    {
                //        Console.WriteLine("输入数字无效，请重新输入");
                //        continue;
                //    }
                //    Console.WriteLine("输入计算符号(+-*/)：");
                //    operate = Console.ReadLine();
                //    if (!new List<string> { "+", "-", "*", "/" }.Contains(operate))
                //    {
                //        Console.WriteLine("输入计算符号无效，请重新输入");
                //        continue;
                //    }

                //    Console.WriteLine("输入第二个(整数)：");
                //    string sInputRight = Console.ReadLine();
                //    if (!int.TryParse(sInputRight, out iInputRight))
                //    {
                //        Console.WriteLine("输入数字无效，请重新输入");
                //        continue;
                //    } 
                //    #endregion

                //    #region 后台逻辑 业务逻辑
                //    int iResult = 0;
                //    switch (operate)//我们经常说的一句话：业务逻辑都暴露在上端了，需要封装转移一下。pop面向过程编程->oop面向对象编程
                //    {
                //        case "+":
                //            iResult = iInputLeft + iInputRight;
                //            break;
                //        case "-":
                //            iResult = iInputLeft - iInputRight;
                //            break;
                //        case "*":
                //            iResult = iInputLeft * iInputRight;
                //            break;
                //        case "/":
                //            iResult = iInputLeft / iInputRight;
                //            break;
                //        default:
                //            Console.WriteLine("输入符号异常，请重新输入");
                //            break;
                //    }
                //    Console.WriteLine("计算为：{0}{1}{2}={3}", iInputLeft, operate, iInputRight, iResult);

                //    #endregion
                //}
            }

            {
                Console.WriteLine("下面是一个计算器展示demo");
                var config = new ConfigurationBuilder().AddJsonFile("appsetting.json", optional: true, reloadOnChange: false).Build();
                while (true)
                {
                    #region UI前端逻辑 接受用户输入并验证
                    int iInputLeft = 0;
                    int iInputRight = 0;
                    string operate = "";
                    Console.WriteLine("输入第一个(整数)：");
                    string sInputLeft = Console.ReadLine();
                    if (!int.TryParse(sInputLeft, out iInputLeft))
                    {
                        Console.WriteLine("输入数字无效，请重新输入");
                        continue;
                    }
                    Console.WriteLine("输入计算符号(+-*/)：");
                    operate = Console.ReadLine();
                    if (!config["CaCulationType"].Split(',').Contains(operate))
                    {
                        Console.WriteLine("输入计算符号无效，请重新输入");
                        continue;
                    }

                    Console.WriteLine("输入第二个(整数)：");
                    string sInputRight = Console.ReadLine();
                    if (!int.TryParse(sInputRight, out iInputRight))
                    {
                        Console.WriteLine("输入数字无效，请重新输入");
                        continue;
                    }
                    #endregion

                    #region 后台逻辑 业务逻辑
                    ICaculation iCaculation = null;
                    //switch (operate)//从pop到oop了，屏蔽细节。1转移了算法逻辑
                    //{
                    //    case "+":
                    //        iCaculation = new Plus();
                    //        break;
                    //    case "-":
                    //        iCaculation = new Minus();
                    //        break;
                    //    case "*":
                    //        iCaculation = new Mutiply();
                    //        break;
                    //    case "/":
                    //        iCaculation = new Devision();
                    //        break;
                    //    default:
                    //        Console.WriteLine("输入符号异常，请重新输入");
                    //        break;
                    //}
                    //int iResult = iCaculation.Caculation(iInputLeft, iInputRight);
                    //3 转移了算法创建以及映射关系，封装了一下
                    iCaculation = Factory.GetCaculationReflection(operate);//Factory.GetCaculation(operate);
                    //包一层
                    CaculationContext context = new CaculationContext(iCaculation, iInputLeft, iInputRight);//CaculationContext可以不用每次都new，只需一个实例就可以
                    //2 转移了算法的调用逻辑
                    int iResult = context.Action();
                    Console.WriteLine("计算为：{0}{1}{2}={3}", iInputLeft, operate, iInputRight, iResult);

                    #endregion
                }
            }
        }
    }
}

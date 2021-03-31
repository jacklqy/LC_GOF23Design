using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GOF23._13代理模式
{
    /// <summary>
    /// 1 手写实现：日志代理 延迟代理 权限代理 单例代理 缓存代理 异常代理
    /// 2 解读AOP面向切面编程
    /// Proxy 是一个极简的设计模式---AOP实践最核心的
    /// Proxy---本身没有提供业务，只是做一些代理---火车票代售点、VPN、翻墙软件等...
    /// 简单模式蕴含着不简单的扩展
    /// 
    /// AOP面向切面编程：在不破坏封装的前提下，可以动态的扩展功能
    /// 1、日志代理：直接通过ProxySubject代理来添加---保证了RealSubject“纯洁性”，避免修改RealSubject，而且扩展功能对修改关闭。
    /// 2、异常代理：---try-catch---通过升级ProxySubject代理，避免修改RealSubject。
    /// 3、单例代理：进程中某个对象只有一个实例，可以在ProxySubject代理完成，避免修改RealSubject。
    /// 4、缓存代理：系统性能优化的第一步就是使用缓存。封装一个第三方缓存，代理查询时，优先缓存，提升性能，避免修改RealSubject。
    /// 5、延迟代理：你们在开发过程中，哪里见过延迟？ef延迟查询、Linq、多线程、泛型声明、前端延迟加载、Lazy、队列。架构师说的一切可以推迟的东西，都推迟一下。升级下ProxySubject代理内ISubject对象实例化逻辑，延迟到真实需要用的时候才初始化，避免修改RealSubject。
    /// 6、权限代理：鉴权-授权-认证，方法不能直接调用，需要验证权限-登录。权限验证逻辑是很麻烦的，多种多样，不能都放在RealSubject里面，通过升级ProxySubject代理，避免修改RealSubject。
    /// 总结：6个代理，通过升级ProxySubject，避免修改RealSubject，完成扩展功能。这就是AOP面向切面编程的核心追求，在不破坏封装的前提下，去动态扩展功能。
    /// 但是，无论是装饰器模式，还是代理模式，都是静态的！AOP如果真的要实战，必须的动态的。
    /// 
    /// Filter  ioc框架的AOP----AOP
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 意图：为其他对象提供一种代理以控制对这个对象的访问。
        /// 主要解决：在直接访问对象时带来的问题，比如说：要访问的对象在远程的机器上。在面向对象系统中，有些对象由于某些原因（比如对象创建开销很大，或者某些操作需要安全控制，或者需要进程外的访问），直接访问会给使用者或者系统结构带来很多麻烦，我们可以在访问此对象时加上一个对此对象的访问层。
        /// 何时使用：想在访问一个类时做一些控制。
        /// 如何解决：增加中间层。
        /// 关键代码：实现与被代理类组合。
        /// 应用实例： 
        ///     1、Windows 里面的快捷方式。 
        ///     2、猪八戒去找高翠兰结果是孙悟空变的，可以这样理解：把高翠兰的外貌抽象出来，高翠兰本人和孙悟空都实现了这个接口，猪八戒访问高翠兰的时候看不出来这个是孙悟空，所以说孙悟空是高翠兰代理类。 
        ///     3、买火车票不一定在火车站买，也可以去代售点。 
        ///     4、一张支票或银行存单是账户中资金的代理。支票在市场交易中用来代替现金，并提供对签发人账号上资金的控制。 
        ///     5、spring aop。
        /// 使用场景：按职责来划分，通常有以下使用场景： 
        ///     1、远程代理。 
        ///     2、虚拟代理。 
        ///     3、Copy-on-Write 代理。 
        ///     4、保护（Protect or Access）代理。 
        ///     5、Cache代理。 
        ///     6、防火墙（Firewall）代理。 
        ///     7、同步化（Synchronization）代理。 
        ///     8、智能引用（Smart Reference）代理。
        /// 优点： 
        ///     1、职责清晰。 
        ///     2、高扩展性。 
        ///     3、智能化。
        /// 缺点： 
        ///     1、由于在客户端和真实主题之间增加了代理对象，因此有些类型的代理模式可能会造成请求的处理速度变慢。 
        ///     2、实现代理模式需要额外的工作，有些代理模式的实现非常复杂。
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("**************代理模式************");

            {
                Console.WriteLine("没有代理的情况下直接调用真实的业务类...");
                ISubject subject = new RealSubject();
                subject.GetSomethingLong();
                subject.DoSomethingLong();
            }

            {
                Console.WriteLine("有代理的情况下直接调用真实的业务类...");
                ISubject subject = new ProxySubject();
                subject.GetSomethingLong();
                subject.DoSomethingLong();
            }

            {
                //模拟延迟代理
                ISubject subject = new ProxySubject();//构造完对象，并没有立即去使用
                Thread.Sleep(1000);
                Console.WriteLine("DoSomething Else1...");
                Thread.Sleep(1000);
                Console.WriteLine("DoSomething Else2...");
                Thread.Sleep(1000);
                Console.WriteLine("DoSomething Else3...");

                //模拟设置整个应用程序共享值设置
                //CallContext.SetData("CurrentUser","探lu者");

                subject.GetSomethingLong();//这里才真的用到这个对象，假如对象持有多个资源，那岂不是浪费了---占着茅坑不拉屎
                subject.DoSomethingLong();
            }
        }
    }
}

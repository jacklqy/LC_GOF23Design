using GOF23._19中介者模式.Character;
using GOF23._19中介者模式.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._19中介者模式
{
    /// <summary>
    /// 意图：用一个中介对象来封装一系列的对象交互，中介者使各对象不需要显式地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
    /// 主要解决：对象与对象之间存在大量的关联关系，这样势必会导致系统的结构变得很复杂，同时若一个对象发生改变，我们也需要跟踪与之相关联的对象，同时做出相应的处理。
    /// 何时使用：多个类相互耦合，形成了网状结构。
    /// 如何解决：将上述网状结构分离为星型结构。
    /// 关键代码：对象 Colleague 之间的通信封装到一个类中单独处理。
    /// 应用实例： 
    ///     1、中国加入 WTO 之前是各个国家相互贸易，结构复杂，现在是各个国家通过 WTO 来互相贸易。 
    ///     2、机场调度系统。 
    ///     3、MVC 框架，其中C（控制器）就是 M（模型）和 V（视图）的中介者。
    /// 优点： 
    ///     1、降低了类的复杂度，将一对多转化成了一对一。 
    ///     2、各个类之间的解耦。 3、符合迪米特原则。
    /// 缺点：中介者会庞大，变得复杂难以维护。
    /// 使用场景： 
    ///     1、系统中对象之间存在比较复杂的引用关系，导致它们之间的依赖关系结构混乱而且难以复用该对象。 
    ///     2、想通过一个中间类来封装多个类中的行为，而又不想生成太多的子类。
    /// 注意事项：不应当在职责混乱的时候使用。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 中介者模式（Mediator Pattern）
        /// 2 中介者模式的优缺点和应用
        /// 3 数据库设计的中介者模式(用户和菜单关系-》用户和菜单关系表，即中介者)
        /// 租房购买买房中间人等...
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("****************中介者模式*************");

            {
                Console.WriteLine("****************一对一发送消息*************");
                BaseCharacter teacher = new Teacher()
                {
                    Name = "Eleven"
                };
                BaseCharacter master = new Master()
                {
                    Name = "探lu者"
                };
                BaseCharacter student = new Student()
                {
                    Name = "yoyo"
                };
                teacher.SendMessage("今晚八点上课啦", master);
                Console.WriteLine("*****************************");
                master.SendMessage("老师，收到，马上通知大家", teacher);
                Console.WriteLine("*****************************");
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student);
            }
            //现在是一对一通知，如果消息是通知所有学员呢？
            {
                Console.WriteLine("****************一对多发送消息*************");
                BaseCharacter teacher = new Teacher()
                {
                    Name = "Eleven"
                };
                BaseCharacter master = new Master()
                {
                    Name = "探lu者"
                };
                BaseCharacter student1 = new Student()
                {
                    Name = "yoyo1"
                };
                BaseCharacter student2 = new Student()
                {
                    Name = "yoyo2"
                };
                BaseCharacter student3 = new Student()
                {
                    Name = "yoyo3"
                };
                BaseCharacter student4 = new Student()
                {
                    Name = "yoyo4"
                };
                teacher.SendMessage("今晚八点上课啦", master);
                Console.WriteLine("*****************************");
                master.SendMessage("老师，收到，马上通知大家", teacher);
                Console.WriteLine("*****************************");
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student1);
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student2);
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student3);
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student4);
                Console.WriteLine("*****************************");
                Console.WriteLine("*****************************");
                Console.WriteLine("*****************************");
                Console.WriteLine("*****************************");
                //改进后一对多通过中介者去发送消息--群发
                BaseMediator mediator = new BaseMediator();
                mediator.AddCharacter(master);
                mediator.AddCharacter(student1);
                mediator.AddCharacter(student2);
                mediator.AddCharacter(student3);
                mediator.AddCharacter(student4);
                mediator.SendMessage("今天晚上八点上课，大家不要错过哦", master);
            }

            {
                
            }
        }
    }
}

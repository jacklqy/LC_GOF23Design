using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
    /// <summary>
    /// 意图：避免请求发送者与接收者耦合在一起，让多个对象都有可能接收请求，将这些对象连接成一条链，并且沿着这条链传递请求，直到有对象处理它为止。
    /// 主要解决：职责链上的处理者负责处理请求，客户只需要将请求发送到职责链上即可，无须关心请求的处理细节和请求的传递，所以职责链将请求的发送者和请求的处理者解耦了。
    /// 何时使用：在处理消息的时候以过滤很多道。
    /// 如何解决：拦截的类都实现统一接口。
    /// 关键代码：Handler 里面聚合它自己，在 HandlerRequest 里判断是否合适，如果没达到条件则向下传递，向谁传递之前 set 进去。
    /// 应用实例： 
    ///     1、红楼梦中的"击鼓传花"。 
    ///     2、JS 中的事件冒泡。 
    ///     3、JAVA WEB 中 Apache Tomcat 对 Encoding 的处理，Struts2 的拦截器，jsp servlet 的 Filter。
    /// 优点：
    ///     1、降低耦合度。它将请求的发送者和接收者解耦。 
    ///     2、简化了对象。使得对象不需要知道链的结构。 
    ///     3、增强给对象指派职责的灵活性。通过改变链内的成员或者调动它们的次序，允许动态地新增或者删除责任。 
    ///     4、增加新的请求处理类很方便。
    /// 缺点： 
    ///     1、不能保证请求一定被接收。 
    ///     2、系统性能将受到一定影响，而且在进行代码调试时不太方便，可能会造成循环调用。 
    ///     3、可能不容易观察运行时的特征，有碍于除错。
    /// 使用场景： 
    ///     1、有多个对象可以处理同一个请求，具体哪个对象处理该请求由运行时刻自动确定。 
    ///     2、在不明确指定接收者的情况下，向多个对象中的一个提交一个请求。 
    ///     3、可动态指定一组对象处理请求。
    /// </summary>
    public class Program : OpentDesign
    {
        /// <summary>
        /// 1 责任链模式：逻辑封装和转移
        /// 2 框架设计中的各种责任链模式
        /// 3 从开发到架构的思考
        /// 4 延伸AspNetCore管道模型设计
        /// 
        /// 设计模式：面向对象语言开发过程中，遇到的种种场景和问题，提出的解决问题的方案和思路，最终沉淀下来的解决问题的方法。
        /// 行为型设计模式：关注对象和行为的分离
        /// **********面向对象的23种设计模式---责任链模式---行为型设计模式的巅峰之作**********
        /// </summary>
        public override void Open()
        {
            //业务场景：模拟请假申请流程。
            //目标：从菜鸟--中级--高级--优秀高级--架构师
            Console.WriteLine("*******************责任链模式******************");
            
            {
                //菜鸟开发：pop面向过程开发思想
                //一看就是代码翻译机，需求怎么交代我们就怎么翻译，完全没有自己的加工,面向过程式编程。
                //请假人不可能去找所有的领导
                //***把全部的业务逻辑都暴露在上端***
                Console.WriteLine("*******************模拟请假申请流程******************");
                ApplyContext context = new ApplyContext()
                {
                    Id = 1098,
                    Name = "Jack",
                    Hour = 100,
                    Description = "参加XXX线下沙龙北京站活动",
                    AuditRemark = "",
                    AuditResult = false
                };
                //首先是项目经理审批
                Console.WriteLine("这里是项目经理 {0} 审批", "fool");
                if (context.Hour <= 8)
                {
                    context.AuditResult = true;
                    context.AuditRemark = "enjoy your vacation!";
                }
                else
                {
                    //找主管审批
                    Console.WriteLine("这里是主管 {0} 审批", "我也不知道了");
                    if (context.Hour <= 16)
                    {
                        context.AuditResult = true;
                        context.AuditRemark = "enjoy your vacation!";
                    }
                    //...
                }
            }

            {
                //中级开发：oop面向对象开发思想，考虑对象--请假条+主管+经理...
                //封装业务逻辑，避免上层看到，继承复用代码，多态
                //也是个代码搬运工，也是过翻译机，无非加了点oop思想，因为没有自己的思考。---这只是翻译，表面上正确，实际上不可用的代码
                //开发不仅是翻译，还得有思想
                //请假人不可能去找所有的领导
                //***转移了审批逻辑***
                ApplyContext context = new ApplyContext()
                {
                    Id = 1098,
                    Name = "Jack",
                    Hour = 100,
                    Description = "参加XXX线下沙龙北京站活动",
                    AuditRemark = "",
                    AuditResult = false
                };
                AbstractAuditor pm = new PM()
                {
                    Name = "王经理"
                };
                pm.Audit(context);
                if (!context.AuditResult)
                {
                    AbstractAuditor charge = new Charge()
                    {
                        Name = "王主管"
                    };
                    charge.Audit(context);

                    if (!context.AuditResult)
                    {
                        AbstractAuditor manager = new Manager()
                        {
                            Name = "王总"
                        };
                        manager.Audit(context);
                        //如果还没有审核通过呢？....
                    }
                }
            }

            {
                //高级开发：程序员一思考就进入高级了---申请应该是自动流转，对象的职责要增加
                //请假人只需找自己对应的上级
                //假如审批流程变化了，就需要修改代码了，缺乏前瞻性
                //***转移了申请转发逻辑***
                ApplyContext context = new ApplyContext()
                {
                    Id = 1098,
                    Name = "Jack",
                    Hour = 100,
                    Description = "参加XXX线下沙龙北京站活动",
                    AuditRemark = "",
                    AuditResult = false
                };
                AbstractAuditor pm = new PM()
                {
                    Name = "王经理"
                };
                pm.Audit(context);
            }

            {
                //优秀的高级开发：有前瞻性，考虑到审批流程变化。流程就可以变化了，能更好的应对业务的升级变迁---开闭原则
                //还一种实现方式：反射+配置文件
                ApplyContext context = new ApplyContext()
                {
                    Id = 1098,
                    Name = "Jack",
                    Hour = 100,
                    Description = "参加XXX线下沙龙北京站活动",
                    AuditRemark = "",
                    AuditResult = false
                };

                #region 这里可以搞一个工厂方法模式、建造者模式Builder封装一下，减少代码量
                AbstractAuditor pm = new PM()
                {
                    Name = "王经理"
                };
                AbstractAuditor charge = new Charge()
                {
                    Name = "王主管"
                };
                AbstractAuditor manager = new Manager()
                {
                    Name = "王总"
                };
                AbstractAuditor chif = new Chif()
                {
                    Name = "王总监"
                };
                AbstractAuditor ceo = new Ceo()
                {
                    Name = "王CEO"
                };
                #endregion

                #region 审批流程配置，可以根据数据库或配置文件动态配置审批流程节点(C#内存分配机制-》类型嵌套)
                pm.SetNext(charge);//项目经理的下一审批环节是主管
                charge.SetNext(manager);//主管的下一审批环节是总经理
                manager.SetNext(chif);//总经理的下一审批环节是总监
                chif.SetNext(ceo);//总监的下一审批环节是CEO 
                #endregion

                //开始发起审批，流程可以任意配置
                pm.Audit(context);
            }

            {
                //优秀的高级开发在程序设计上已经ok了，怎么到架构师呢？
                //1、架构师首先是有着丰富的程序设计经验，然后还需要能融会贯通
                //2、能高度抽象业务，然后恰如其分的去应用各种程序设计思想---重点
                //3、解决的问题不在是面向具体业务，而是面向框架

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._16责任链模式
{
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

                #region 审批流程配置，可以根据数据库或配置文件动态配置审批流程节点
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
                //2、能高度抽象业务，然后恰如其分的去应用各种程序设计思想
                //3、解决的问题不在是面向具体业务，而是面向框架

            }
        }
    }
}

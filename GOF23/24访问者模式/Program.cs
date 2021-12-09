using GOF23._24访问者模式.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式
{
    public class Program : OpentDesign
    {
        public override void Open()
        {
            Console.WriteLine("**********************访问者模式*******************");

            {
                List<Student> studentList = new List<Student>()
                {
                    new StudentVip()
                    {
                        Id=1,
                        Name="jack001"
                    },
                    new StudentVip()
                    {
                        Id=2,
                        Name="jack002"
                    },
                    new StudentFree()
                    {
                        Id=3,
                        Name="rose003"
                    }
                };
                //方式一
                //foreach (var student in studentList)
                //{
                //    student.Study();
                //    ////还要看视频
                //    //if(student is StudentVip)//业务逻辑暴露给了上层
                //    //{
                //    //    Console.WriteLine("免费获取全套的公开课视频代码合集");
                //    //}
                //    //else
                //    //{
                //    //    Console.WriteLine("只能获取当次课的公开课视频代码");
                //    //}
                //    student.GetVideo();
                //}


                /// 需求：
                /// 公开课学员在不同的时间段，获取权限不同
                /// 1 只有代码没有视频
                /// 2 根据暗号获取当次课的视频
                /// 3 找助教获取当次课的视频
                Console.WriteLine("******************不同需求切换*****************");

                {
                    //1 只有代码没有视频
                    Console.WriteLine("******************VisitorPast*****************");
                    VisitorAbstract visitor3 = new VisitorPast();//封装变化
                    foreach (var student in studentList)
                    {
                        student.Study();
                        student.GetVideoVisitor(visitor3);//对象与行为分离
                    }
                }
                {
                    //2 根据暗号获取当次课的视频
                    Console.WriteLine("******************VisitorTemp*****************");
                    VisitorAbstract visitor2 = new VisitorTemp();//封装变化
                    foreach (var student in studentList)
                    {
                        student.Study();
                        student.GetVideoVisitor(visitor2);//对象与行为分离
                    }
                }
                {
                    //3 找助教获取当次课的视频
                    Console.WriteLine("******************VisitorCurrent*****************");
                    VisitorAbstract visitor1 = new VisitorCurrent();//封装变化
                    foreach (var student in studentList)
                    {
                        student.Study();
                        student.GetVideoVisitor(visitor1);//对象与行为分离
                    }
                }

                //思考：如果要增加一个StudentSVip呢？--切斜的可扩展设计
                //这个就没有办法了，如果增加了StudentSVip那么VisitorAbstract抽象类就需要增加对象的方法，其它实现子类就必须要实现。
            }
        }
    }
}

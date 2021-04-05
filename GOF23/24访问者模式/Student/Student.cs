using GOF23._24访问者模式.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式
{
    /// <summary>
    /// 学生
    /// </summary>
    public abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long QQ { get; set; }
        /// <summary>
        /// 学习
        /// </summary>
        public void Study()
        {
            Console.WriteLine("{0}跟着探lu者老师学习.net高级开发", this.Name);
        }

        public abstract void GetVideo();

        public abstract void GetVideoVisitor(VisitorAbstract visitor);

        ///// <summary>
        ///// 获取视频 父类不能依赖子类
        ///// </summary>
        //public void GetVideo()
        //{
        //    if (this is StudentVip)
        //    {
        //        Console.WriteLine("免费获取全套的公开课视频代码合集");
        //    }
        //    else
        //    {
        //        Console.WriteLine("只能获取当次课的公开课视频代码");
        //    }
        //}
    }
}

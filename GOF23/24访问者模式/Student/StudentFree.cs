using GOF23._24访问者模式.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式
{
    /// <summary>
    /// 公开课学生
    /// </summary>
    public class StudentFree : Student
    {
        public string CourseFree { get; set; }

        /// <summary>
        /// 获取视频
        /// 
        /// 需求：
        /// 公开课学员在不同的时间段，获取权限不同
        /// 1 只有代码没有视频
        /// 2 根据暗号获取当次课的视频
        /// 3 找助教获取当次课的视频
        /// </summary>
        public override void GetVideo()
        {
            ////if逻辑封装转移
            //if () { }
            //else if () { }
            //else { }

            //在建立一堆子类，每一个子类对应一个if分支，分别去完成。true
            //在建立多个方法，每一个方法对应一个分支，分别去完成。false

            Console.WriteLine("只能获取当次课的公开课视频代码");
        }

        public override void GetVideoVisitor(VisitorAbstract visitor)
        {
            //双重分派
            visitor.GetVideoFree(this);//this表示当前实例
        }
    }
}

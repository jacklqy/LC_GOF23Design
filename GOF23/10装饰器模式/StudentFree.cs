using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式
{
    /// <summary>
    /// 公开课学员
    /// </summary>
    public class StudentFree : AbstractStudent
    {
        public override void Show()
        {
            Console.WriteLine("my name is {0}", this.Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} 正在观看视频直播学习~~~~", base.Name);
            //如果有功能扩展，OOP就不得不去修改现有代码，破坏现有的封装---这种方式不好
            //Console.WriteLine("获取视频+课件+代码的回看");
            //能不能不修改原有代码，也能扩展功能。---开闭原则，对扩展开放，对修改关闭。

            //又来新需求啦：课前预习+作业巩固练习+老师课后答疑 ，需求很多，而且还要灵活定制
            //一个业务功能在完成后，希望能够任意的扩展功能，订制顺序，而且不破坏封装。
        }
    }

    /// <summary>
    /// 方式一：类继承
    /// </summary>
    public class StudentFreeVideo : StudentFree
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("获取视频+课件+代码的回看");
        }
    }
    /// <summary>
    /// 方式二：类组合
    /// </summary>
    public class StudentCombination
    {
        private AbstractStudent _Student = null;
        public StudentCombination(AbstractStudent student)
        {
            this._Student = student;
        }
        public void Study()
        {
            this._Student.Study();
            Console.WriteLine("获取视频+课件+代码的回看");
        }
    }
}

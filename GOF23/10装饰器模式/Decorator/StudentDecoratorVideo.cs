using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式.Decorator
{
    /// <summary>
    /// 课后视频
    /// </summary>
    public class StudentDecoratorVideo : BaseDecorator
    {
        public StudentDecoratorVideo(AbstractStudent student) : base(student)
        {

        }

        public override void Show()
        {
            base.Show();
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("获取课后视频+课件+代码的回看");
        }
    }
}

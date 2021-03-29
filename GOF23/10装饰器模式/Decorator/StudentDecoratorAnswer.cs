using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式.Decorator
{
    /// <summary>
    /// 课后答疑
    /// </summary>
    public class StudentDecoratorAnswer : BaseDecorator
    {
        public StudentDecoratorAnswer(AbstractStudent student) : base(student)
        {

        }

        public override void Show()
        {
            base.Show();
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("老师课后在线答疑");
        }
    }
}

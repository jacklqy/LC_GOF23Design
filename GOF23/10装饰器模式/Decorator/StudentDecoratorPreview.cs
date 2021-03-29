using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式.Decorator
{
    /// <summary>
    /// 课前预习
    /// </summary>
    public class StudentDecoratorPreview : BaseDecorator
    {
        public StudentDecoratorPreview(AbstractStudent student) : base(student)
        {

        }

        public override void Show()
        {
            base.Show();
        }

        public override void Study()
        {
            Console.WriteLine("课前完成预习准备");
            base.Study();
        }
    }
}

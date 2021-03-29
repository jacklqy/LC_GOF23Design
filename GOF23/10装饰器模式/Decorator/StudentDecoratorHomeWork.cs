using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式.Decorator
{
    /// <summary>
    /// 课后练习
    /// </summary>
    public class StudentDecoratorHomeWork : BaseDecorator
    {
        public StudentDecoratorHomeWork(AbstractStudent student) : base(student)
        {

        }

        public override void Show()
        {
            base.Show();
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("巩固课后练习，学以致用");
        }
    }
}

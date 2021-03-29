using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式.Decorator
{
    /// <summary>
    /// 装饰器基类
    /// 继承+组合
    /// </summary>
    public class BaseDecorator : AbstractStudent
    {
        private AbstractStudent _Student = null;
        public BaseDecorator(AbstractStudent student)
        {
            this._Student = student;
        }

        public override void Show()
        {
            this._Student.Show();
        }

        public override void Study()
        {
            this._Student.Study();
        }
    }
}

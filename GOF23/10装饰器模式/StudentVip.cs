using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式
{
    /// <summary>
    /// VIP课学员
    /// </summary>
    public class StudentVip : AbstractStudent
    {
        public override void Show()
        {
            Console.WriteLine("this is {0} 开始看视频学习啦", this.Name);
        }

        public override void Study()
        {
            Console.WriteLine("this {0}.{1} {2}", this.GetType().Name, "Study", this.Name);
        }
    }
}

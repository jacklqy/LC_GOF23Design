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
            Console.WriteLine("my name is {0}，VIP课学员。", this.Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} VIP课学员正在观看视频直播学习~~~~", base.Name);
        }
    }
}

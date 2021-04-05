using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式.Visitor
{
    /// <summary>
    /// 访问者：只有代码没有视频
    /// </summary>
    public class VisitorPast : VisitorAbstract
    {
        public override void GetVideoFree(Student studentFree)
        {
            Console.WriteLine("studentFree->只有代码没有视频");
        }

        public override void GetVideoVip(Student studentVip)
        {
            Console.WriteLine("studentVip->只有代码没有视频");
        }
    }
}

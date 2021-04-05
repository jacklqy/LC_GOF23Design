using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式.Visitor
{
    /// <summary>
    /// 访问者：根据暗号获取当次课的视频
    /// </summary>
    public class VisitorTemp : VisitorAbstract
    {
        public override void GetVideoFree(Student studentFree)
        {
            Console.WriteLine("studentFree->根据暗号获取当次课的视频");
        }

        public override void GetVideoVip(Student studentVip)
        {
            Console.WriteLine("studentVip->根据暗号获取当次课的视频");
        }
    }
}

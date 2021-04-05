using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._24访问者模式.Visitor
{
    /// <summary>
    /// 访问者抽象
    /// </summary>
    public abstract class VisitorAbstract
    {
        public abstract void GetVideoFree(Student studentFree);

        public abstract void GetVideoVip(Student studentVip);
    }
}

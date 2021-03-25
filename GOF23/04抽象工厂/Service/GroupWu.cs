using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 吴国主公
    /// </summary>
    public class GroupWu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0}：孙权", this.GetType().Name);
        }
    }
}

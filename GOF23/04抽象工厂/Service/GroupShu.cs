using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 蜀国主公
    /// </summary>
    public class GroupShu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0}：刘备", this.GetType().Name);
        }
    }
}

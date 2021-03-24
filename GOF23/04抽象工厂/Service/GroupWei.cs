using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 魏国主公
    /// </summary>
    public class GroupWei : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0}：曹操", this.GetType().Name);
        }
    }
}

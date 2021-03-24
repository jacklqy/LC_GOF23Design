using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 吴国武将
    /// </summary>
    public class GeneralsWu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}：黄盖、甘宁、太史慈、韩当、凌统", this.GetType().Name);
        }
    }
}

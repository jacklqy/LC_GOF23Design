using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 蜀国谋士
    /// </summary>
    class AdviserShu : IAdviser
    {
        public void ShowAdviser()
        {
            Console.WriteLine("{0}：卧龙凤雏姜维", this.GetType().Name);
        }
    }
}

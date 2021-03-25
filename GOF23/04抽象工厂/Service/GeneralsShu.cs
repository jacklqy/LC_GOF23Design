using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 蜀国武将
    /// </summary>
    class GeneralsShu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}：关羽、张飞、赵云、马超、黄忠", this.GetType().Name);
        }
    }
}

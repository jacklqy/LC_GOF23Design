using GOF23._04抽象工厂.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._04抽象工厂.Service
{
    /// <summary>
    /// 魏国武将
    /// </summary>
    class GeneralsWei : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}：许诸、典韦、夏侯渊、徐晃、张辽", this.GetType().Name);
        }
    }
}

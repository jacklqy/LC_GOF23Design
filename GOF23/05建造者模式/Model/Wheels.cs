using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式.Model
{
    /// <summary>
    /// 轮子
    /// </summary>
    public class Wheels
    {
        public string Name { get; set; }
        public Wheels(string name)
        {
            this.Name = name;
        }
    }
}

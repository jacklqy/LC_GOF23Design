using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式.Model
{
    /// <summary>
    /// 灯
    /// </summary>
    public class Light
    {
        public string Name { get; set; }
        public Light(string name)
        {
            this.Name = name;
        }
    }
}

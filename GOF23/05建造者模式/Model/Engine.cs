using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._05建造者模式.Model
{
    /// <summary>
    /// 引擎
    /// </summary>
    public class Engine
    {
        public string Name { get; set; }
        public Engine(string name)
        {
            this.Name = name;
        }
    }
}

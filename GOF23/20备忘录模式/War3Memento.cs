using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._20备忘录模式
{
    /// <summary>
    /// 魔兽争霸备忘
    /// </summary>
    public class War3Memento
    {
        public string Hero { get; private set; }
        public string Army { get; private set; }
        public string Resource { get; private set; }
        public War3Memento(string hero, string army, string resource)
        {
            this.Hero = hero;
            this.Army = army;
            this.Resource = resource;
        }
    }
}

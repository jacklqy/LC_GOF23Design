using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._10装饰器模式
{
    public abstract class AbstractStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Study();
        public abstract void Show();
    }
}

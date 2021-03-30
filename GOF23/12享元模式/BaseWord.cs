using System;
using System.Collections.Generic;
using System.Text;

namespace GOF23._12享元模式
{
    /// <summary>
    /// 字母抽象类
    /// </summary>
    public abstract class BaseWord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public abstract string Get();
    }
}
